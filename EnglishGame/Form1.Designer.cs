namespace EnglishGame
{
    partial class LearnEnglish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnglishWordLabel = new System.Windows.Forms.Label();
            this.userInputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnglishWordLabel
            // 
            this.EnglishWordLabel.AutoSize = true;
            this.EnglishWordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishWordLabel.Location = new System.Drawing.Point(339, 157);
            this.EnglishWordLabel.Name = "EnglishWordLabel";
            this.EnglishWordLabel.Size = new System.Drawing.Size(62, 21);
            this.EnglishWordLabel.TabIndex = 0;
            this.EnglishWordLabel.Text = "AAAA";
            this.EnglishWordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userInputBox
            // 
            this.userInputBox.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputBox.Location = new System.Drawing.Point(212, 249);
            this.userInputBox.Name = "userInputBox";
            this.userInputBox.Size = new System.Drawing.Size(353, 37);
            this.userInputBox.TabIndex = 1;
            this.userInputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userInputBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.userInputBox_PreviewKeyDown);
            // 
            // LearnEnglish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 464);
            this.Controls.Add(this.userInputBox);
            this.Controls.Add(this.EnglishWordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LearnEnglish";
            this.Text = "LearnEnglish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label EnglishWordLabel;
        private System.Windows.Forms.TextBox userInputBox;
    }
}

