namespace _2048GameWinForms
{
    partial class GamePanel
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
            this.Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Score.Location = new System.Drawing.Point(12, 21);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(116, 41);
            this.Score.TabIndex = 16;
            this.Score.Text = "Score 0";
            this.Score.Click += new System.EventHandler(this.label1_Click);
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 339);
            this.Controls.Add(this.Score);
            this.Name = "GamePanel";
            this.Text = "2048";
            this.Load += new System.EventHandler(this.GamePanel_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label Score;
    }
}