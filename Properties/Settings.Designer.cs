﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PDFToCmyk.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-level3 {IN} {OUT}")]
        public string Pdf2ps {
            get {
                return ((string)(this["Pdf2ps"]));
            }
            set {
                this["Pdf2ps"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-dBATCH -dNOPAUSE -sDEVICE=pdfwrite -sOutputFile={OUT} -sProcessColorModel=Device" +
            "CMYK -sColorConversionStrategy=CMYK {IN}")]
        public string Ps2pdf {
            get {
                return ((string)(this["Ps2pdf"]));
            }
            set {
                this["Ps2pdf"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-f 1 -l 1 -singlefile -png -r 300 {IN}")]
        public string Pdf2png {
            get {
                return ((string)(this["Pdf2png"]));
            }
            set {
                this["Pdf2png"] = value;
            }
        }
    }
}
