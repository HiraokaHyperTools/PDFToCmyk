using PDFToCmyk.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFToCmyk {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e) {
            String fpTmpPS = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N")) + ".ps";
            try {

                lStat.Text = "pdftops で ps へ変換中"; Update();

                {
                    ProcessStartInfo psi = new ProcessStartInfo("pdftops.exe",
                        Settings.Default.Pdf2ps
                            .Replace("{IN}", "\"" + tbPdfIn.Text + "\"")
                            .Replace("{OUT}", "\"" + fpTmpPS + "\"")
                        );
                    psi.CreateNoWindow = true;
                    psi.WorkingDirectory = Application.StartupPath;
                    psi.UseShellExecute = false;
                    Process p = Process.Start(psi);
                    p.WaitForExit();
                    if (p.ExitCode != 0) {
                        MessageBox.Show(this, "変換失敗!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                lStat.Text = "gswin32c で PDF を作成中"; Update();

                {
                    ProcessStartInfo psi = new ProcessStartInfo("gswin32c.exe",
                        Settings.Default.Ps2pdf
                            .Replace("{IN}", "\"" + fpTmpPS + "\"")
                            .Replace("{OUT}", "\"" + tbPdfOut.Text + "\"")
                        );
                    psi.CreateNoWindow = true;
                    psi.WorkingDirectory = Application.StartupPath;
                    psi.UseShellExecute = false;
                    Process p = Process.Start(psi);
                    p.WaitForExit();
                    if (p.ExitCode != 0) {
                        MessageBox.Show(this, "変換失敗!", Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
            finally {
                if (File.Exists(fpTmpPS)) {
                    File.Delete(fpTmpPS);
                }
            }

            lStat.Text = "プレビューを作成しています"; Update();

            oldPos = panel1.AutoScrollPosition;
            //pbPreview.Image = null;

            if (!bwLoader.IsBusy) {
                bwLoader.RunWorkerAsync(tbPdfOut.Text);
            }

            if (object.ReferenceEquals(sender, bConvertAndOpen)) {
                Process.Start(tbPdfOut.Text);
            }
        }

        Point oldPos;

        private void button1_Click(object sender, EventArgs e) {
            ofdPdf.FileName = tbPdfIn.Text;
            if (ofdPdf.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                tbPdfIn.Text = ofdPdf.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            sfdPdf.FileName = tbPdfOut.Text;
            if (sfdPdf.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                tbPdfOut.Text = sfdPdf.FileName;
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
            e.Effect = e.AllowedEffect & (e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            var alfp = e.Data.GetData(DataFormats.FileDrop) as String[];
            if (alfp != null) {
                foreach (var fp in alfp) {
                    tbPdfIn.Text = fp;
                    tbPdfOut.Text = fp;
                    break;
                }
            }
        }

        private void bwLoader_DoWork(object sender, DoWorkEventArgs e) {
            String fpPdf = (String)e.Argument;

            {
                ProcessStartInfo psi = new ProcessStartInfo("pdftoppm.exe",
                    Settings.Default.Pdf2png
                        .Replace("{IN}", "\"" + fpPdf + "\"")
                        );
                psi.CreateNoWindow = true;
                psi.WorkingDirectory = Application.StartupPath;
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                Process p = Process.Start(psi);
                Bitmap pic = new Bitmap(p.StandardOutput.BaseStream);
                p.WaitForExit();
                e.Result = pic;
            }
        }

        private void bwLoader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Error == null && e.Result is Bitmap) {
                pbPreview.Image = e.Result as Bitmap;
                panel1.AutoScrollPosition = new Point(-oldPos.X, -oldPos.Y);

                lStat.Text = "プレビュー作成しました"; Update();
            }
            else {
                pbPreview.Image = null;
                lStat.Text = "プレビュー作成に失敗しました"; Update();
            }
        }
    }
}
