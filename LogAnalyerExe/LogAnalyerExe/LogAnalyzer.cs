using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace LogAnalyerExe
{
    public partial class LogAnalyzer : Form
    {
        [DllImport("LogAnalyzer.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void LogAnalyze(char[] szPath, char[] szFile, char[] szSearch);

        public LogAnalyzer()
        {
            InitializeComponent();
        }

      
        private void SearchPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if( result == DialogResult.OK )
            {
                string szText = folderBrowserDialog1.SelectedPath;
                SearchPathText.Text = szText;
            }
        }

        private void RunSearch_Click(object sender, EventArgs e)
        {
            byte[] szFilePath = Encoding.Default.GetBytes(SearchPathText.Text);
            byte[] szSearchRegex = Encoding.Default.GetBytes(SearchRegex_Text.Text);
            byte[] szFileRegex = Encoding.Default.GetBytes(FileRegex_Text.Text);

            string szFilePathA = Encoding.ASCII.GetString(szFilePath);
            string szSearchRegexA = Encoding.ASCII.GetString(szSearchRegex);
            string szFileRegexA = Encoding.ASCII.GetString(szFileRegex);

            LogAnalyze(szFilePathA.ToCharArray(), szFileRegexA.ToCharArray(), szSearchRegexA.ToCharArray());

            MessageBox.Show("로그 추출이 완료 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

    }
}
