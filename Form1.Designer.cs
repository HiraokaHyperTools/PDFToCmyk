namespace PDFToCmyk {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tbPdfIn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPdfOut = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bConvert = new System.Windows.Forms.Button();
            this.ofdPdf = new System.Windows.Forms.OpenFileDialog();
            this.sfdPdf = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lStat = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.bwLoader = new System.ComponentModel.BackgroundWorker();
            this.bConvertAndOpen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "もとの PDF";
            // 
            // tbPdfIn
            // 
            this.tbPdfIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPdfIn.Location = new System.Drawing.Point(12, 33);
            this.tbPdfIn.Name = "tbPdfIn";
            this.tbPdfIn.Size = new System.Drawing.Size(647, 28);
            this.tbPdfIn.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(665, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "参照";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "CMYK PDF";
            // 
            // tbPdfOut
            // 
            this.tbPdfOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPdfOut.Location = new System.Drawing.Point(12, 88);
            this.tbPdfOut.Name = "tbPdfOut";
            this.tbPdfOut.Size = new System.Drawing.Size(647, 28);
            this.tbPdfOut.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(665, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "参照";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bConvert
            // 
            this.bConvert.Location = new System.Drawing.Point(12, 122);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(134, 76);
            this.bConvert.TabIndex = 6;
            this.bConvert.Text = "変換";
            this.bConvert.UseVisualStyleBackColor = true;
            this.bConvert.Click += new System.EventHandler(this.button3_Click);
            // 
            // ofdPdf
            // 
            this.ofdPdf.DefaultExt = "pdf";
            this.ofdPdf.Filter = "*.pdf|*.pdf";
            // 
            // sfdPdf
            // 
            this.sfdPdf.DefaultExt = "pdf";
            this.sfdPdf.Filter = "*.pdf|*.pdf";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lStat);
            this.groupBox1.Location = new System.Drawing.Point(292, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 76);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "変換の状況?";
            // 
            // lStat
            // 
            this.lStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lStat.Location = new System.Drawing.Point(3, 24);
            this.lStat.Name = "lStat";
            this.lStat.Size = new System.Drawing.Size(442, 49);
            this.lStat.TabIndex = 0;
            this.lStat.Text = "...";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 241);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "プレビュー pdftoppm (poppler)";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pbPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 214);
            this.panel1.TabIndex = 0;
            // 
            // pbPreview
            // 
            this.pbPreview.Location = new System.Drawing.Point(0, 0);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(100, 100);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPreview.TabIndex = 1;
            this.pbPreview.TabStop = false;
            // 
            // bwLoader
            // 
            this.bwLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwLoader_DoWork);
            this.bwLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwLoader_RunWorkerCompleted);
            // 
            // bConvertAndOpen
            // 
            this.bConvertAndOpen.Location = new System.Drawing.Point(152, 122);
            this.bConvertAndOpen.Name = "bConvertAndOpen";
            this.bConvertAndOpen.Size = new System.Drawing.Size(134, 76);
            this.bConvertAndOpen.TabIndex = 7;
            this.bConvertAndOpen.Text = "変換＆開く";
            this.bConvertAndOpen.UseVisualStyleBackColor = true;
            this.bConvertAndOpen.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(752, 457);
            this.Controls.Add(this.bConvertAndOpen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bConvert);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbPdfOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPdfIn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MinimumSize = new System.Drawing.Size(399, 399);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDFToCmyk";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPdfIn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPdfOut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bConvert;
        private System.Windows.Forms.OpenFileDialog ofdPdf;
        private System.Windows.Forms.SaveFileDialog sfdPdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lStat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker bwLoader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Button bConvertAndOpen;
    }
}

