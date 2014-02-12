namespace LogAnalyerExe
{
    partial class LogAnalyzer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SearchPathText = new System.Windows.Forms.TextBox();
            this.SearchRegex_Text = new System.Windows.Forms.TextBox();
            this.RunSearch = new System.Windows.Forms.Button();
            this.FileRegex_Text = new System.Windows.Forms.TextBox();
            this.FileExpression_label = new System.Windows.Forms.Label();
            this.SearchEpression_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchPath
            // 
            this.SearchPath.Location = new System.Drawing.Point(363, 28);
            this.SearchPath.Name = "SearchPath";
            this.SearchPath.Size = new System.Drawing.Size(82, 25);
            this.SearchPath.TabIndex = 0;
            this.SearchPath.Text = "경로";
            this.SearchPath.UseVisualStyleBackColor = true;
            this.SearchPath.Click += new System.EventHandler(this.SearchPath_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\";
            // 
            // SearchPathText
            // 
            this.SearchPathText.Location = new System.Drawing.Point(22, 31);
            this.SearchPathText.Name = "SearchPathText";
            this.SearchPathText.Size = new System.Drawing.Size(325, 21);
            this.SearchPathText.TabIndex = 1;
            // 
            // SearchRegex_Text
            // 
            this.SearchRegex_Text.Location = new System.Drawing.Point(109, 114);
            this.SearchRegex_Text.Name = "SearchRegex_Text";
            this.SearchRegex_Text.Size = new System.Drawing.Size(237, 21);
            this.SearchRegex_Text.TabIndex = 2;
            this.SearchRegex_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RunSearch
            // 
            this.RunSearch.Location = new System.Drawing.Point(363, 75);
            this.RunSearch.Name = "RunSearch";
            this.RunSearch.Size = new System.Drawing.Size(81, 60);
            this.RunSearch.TabIndex = 3;
            this.RunSearch.Text = "검색";
            this.RunSearch.UseVisualStyleBackColor = true;
            this.RunSearch.Click += new System.EventHandler(this.RunSearch_Click);
            // 
            // FileRegex_Text
            // 
            this.FileRegex_Text.Location = new System.Drawing.Point(109, 75);
            this.FileRegex_Text.Name = "FileRegex_Text";
            this.FileRegex_Text.Size = new System.Drawing.Size(237, 21);
            this.FileRegex_Text.TabIndex = 4;
            this.FileRegex_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FileExpression_label
            // 
            this.FileExpression_label.AutoSize = true;
            this.FileExpression_label.Location = new System.Drawing.Point(22, 81);
            this.FileExpression_label.Name = "FileExpression_label";
            this.FileExpression_label.Size = new System.Drawing.Size(81, 12);
            this.FileExpression_label.TabIndex = 5;
            this.FileExpression_label.Text = "> 파일 regex:";
            // 
            // SearchEpression_label
            // 
            this.SearchEpression_label.AutoSize = true;
            this.SearchEpression_label.Location = new System.Drawing.Point(22, 117);
            this.SearchEpression_label.Name = "SearchEpression_label";
            this.SearchEpression_label.Size = new System.Drawing.Size(81, 12);
            this.SearchEpression_label.TabIndex = 6;
            this.SearchEpression_label.Text = "> 검색 regex:";
            // 
            // LogAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 171);
            this.Controls.Add(this.SearchEpression_label);
            this.Controls.Add(this.FileExpression_label);
            this.Controls.Add(this.FileRegex_Text);
            this.Controls.Add(this.RunSearch);
            this.Controls.Add(this.SearchRegex_Text);
            this.Controls.Add(this.SearchPathText);
            this.Controls.Add(this.SearchPath);
            this.Name = "LogAnalyzer";
            this.Text = "LogExtractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox SearchPathText;
        private System.Windows.Forms.TextBox SearchRegex_Text;
        private System.Windows.Forms.Button RunSearch;
        private System.Windows.Forms.TextBox FileRegex_Text;
        private System.Windows.Forms.Label FileExpression_label;
        private System.Windows.Forms.Label SearchEpression_label;


    }
}

