namespace MEVS
{
    partial class MesB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MesB));
            this.Title = new System.Windows.Forms.Label();
            this.Det = new System.Windows.Forms.Label();
            this.YesBtn = new System.Windows.Forms.Label();
            this.NoBtn = new System.Windows.Forms.Label();
            this.CanBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(49, 17);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(286, 40);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Det
            // 
            this.Det.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Det.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.Det.Location = new System.Drawing.Point(35, 65);
            this.Det.Name = "Det";
            this.Det.Size = new System.Drawing.Size(314, 118);
            this.Det.TabIndex = 1;
            this.Det.Text = "Detail";
            this.Det.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // YesBtn
            // 
            this.YesBtn.AutoSize = true;
            this.YesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.YesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesBtn.ForeColor = System.Drawing.Color.White;
            this.YesBtn.Location = new System.Drawing.Point(81, 195);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(58, 29);
            this.YesBtn.TabIndex = 2;
            this.YesBtn.Text = "Yes";
            this.YesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            this.YesBtn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.YesBtn_PreviewKeyDown);
            // 
            // NoBtn
            // 
            this.NoBtn.AutoSize = true;
            this.NoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoBtn.ForeColor = System.Drawing.Color.White;
            this.NoBtn.Location = new System.Drawing.Point(248, 195);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(47, 29);
            this.NoBtn.TabIndex = 3;
            this.NoBtn.Text = "No";
            this.NoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            this.NoBtn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.NoBtn_PreviewKeyDown);
            // 
            // CanBtn
            // 
            this.CanBtn.AutoSize = true;
            this.CanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanBtn.ForeColor = System.Drawing.Color.White;
            this.CanBtn.Location = new System.Drawing.Point(167, 195);
            this.CanBtn.Name = "CanBtn";
            this.CanBtn.Size = new System.Drawing.Size(50, 29);
            this.CanBtn.TabIndex = 4;
            this.CanBtn.Text = "OK";
            this.CanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CanBtn.Click += new System.EventHandler(this.CanBtn_Click);
            this.CanBtn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CanBtn_PreviewKeyDown);
            // 
            // MesB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(100)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(385, 244);
            this.Controls.Add(this.CanBtn);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.Det);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MesB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MesB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.Label Det;
        public System.Windows.Forms.Label YesBtn;
        public System.Windows.Forms.Label NoBtn;
        public System.Windows.Forms.Label CanBtn;
    }
}