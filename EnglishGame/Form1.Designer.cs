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
            this.SuspendLayout();
            // 
            // EnglishWordLabel
            // 
            this.EnglishWordLabel.AutoSize = true;
            this.EnglishWordLabel.Location = new System.Drawing.Point(350, 150);
            this.EnglishWordLabel.Name = "EnglishWordLabel";
            this.EnglishWordLabel.Size = new System.Drawing.Size(43, 16);
            this.EnglishWordLabel.TabIndex = 0;
            this.EnglishWordLabel.Text = "AAAA";
            this.EnglishWordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LearnEnglish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 464);
            this.Controls.Add(this.EnglishWordLabel);
            this.Name = "LearnEnglish";
            this.Text = "LearnEnglish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label EnglishWordLabel;
    }
}

