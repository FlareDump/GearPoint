namespace GearPoint
{
    partial class StartingPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingPoint));
            this.STI_LOGO = new System.Windows.Forms.PictureBox();
            this.admin_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.STI_LOGO)).BeginInit();
            this.SuspendLayout();
            // 
            // STI_LOGO
            // 
            this.STI_LOGO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("STI_LOGO.BackgroundImage")));
            this.STI_LOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.STI_LOGO.Location = new System.Drawing.Point(-91, 196);
            this.STI_LOGO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.STI_LOGO.Name = "STI_LOGO";
            this.STI_LOGO.Size = new System.Drawing.Size(720, 439);
            this.STI_LOGO.TabIndex = 0;
            this.STI_LOGO.TabStop = false;
            // 
            // admin_btn
            // 
            this.admin_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("admin_btn.BackgroundImage")));
            this.admin_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.admin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.admin_btn.Location = new System.Drawing.Point(501, 15);
            this.admin_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(53, 49);
            this.admin_btn.TabIndex = 1;
            this.admin_btn.UseVisualStyleBackColor = true;
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.start_btn.FlatAppearance.BorderSize = 0;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(188)))));
            this.start_btn.Location = new System.Drawing.Point(28, 758);
            this.start_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(511, 84);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "Tap here to start....";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // StartingPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(571, 878);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.admin_btn);
            this.Controls.Add(this.STI_LOGO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StartingPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STI GearPoint";
            ((System.ComponentModel.ISupportInitialize)(this.STI_LOGO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox STI_LOGO;
        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Button start_btn;
    }
}

