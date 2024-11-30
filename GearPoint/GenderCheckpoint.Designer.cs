namespace GearPoint
{
    partial class GenderCheckpoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenderCheckpoint));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roundedPictureBox1 = new GearPoint.RoundedPictureBox();
            this.MALEButton1 = new RoundButton();
            this.FEMALEButton2 = new RoundButton();
            this.BACKButton4 = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(585, 80);
            this.dataGridView1.TabIndex = 1;
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPictureBox1.BackgroundImage")));
            this.roundedPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundedPictureBox1.CornerRadius = 40;
            this.roundedPictureBox1.Location = new System.Drawing.Point(19, 14);
            this.roundedPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Size = new System.Drawing.Size(111, 53);
            this.roundedPictureBox1.TabIndex = 2;
            this.roundedPictureBox1.TabStop = false;
            // 
            // MALEButton1
            // 
            this.MALEButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MALEButton1.BackgroundImage")));
            this.MALEButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MALEButton1.BorderRadius = 50;
            this.MALEButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MALEButton1.Location = new System.Drawing.Point(153, 139);
            this.MALEButton1.Margin = new System.Windows.Forms.Padding(0);
            this.MALEButton1.Name = "MALEButton1";
            this.MALEButton1.Size = new System.Drawing.Size(251, 250);
            this.MALEButton1.TabIndex = 30;
            this.MALEButton1.UseVisualStyleBackColor = true;
            this.MALEButton1.Click += new System.EventHandler(this.MALEButton1_Click);
            // 
            // FEMALEButton2
            // 
            this.FEMALEButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FEMALEButton2.BackgroundImage")));
            this.FEMALEButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FEMALEButton2.BorderRadius = 50;
            this.FEMALEButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FEMALEButton2.Location = new System.Drawing.Point(152, 441);
            this.FEMALEButton2.Margin = new System.Windows.Forms.Padding(0);
            this.FEMALEButton2.Name = "FEMALEButton2";
            this.FEMALEButton2.Size = new System.Drawing.Size(251, 250);
            this.FEMALEButton2.TabIndex = 31;
            this.FEMALEButton2.UseVisualStyleBackColor = true;
            this.FEMALEButton2.Click += new System.EventHandler(this.FEMALEButton2_Click);
            // 
            // BACKButton4
            // 
            this.BACKButton4.BackColor = System.Drawing.Color.Yellow;
            this.BACKButton4.BorderRadius = 30;
            this.BACKButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BACKButton4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACKButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(188)))));
            this.BACKButton4.Location = new System.Drawing.Point(221, 755);
            this.BACKButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BACKButton4.Name = "BACKButton4";
            this.BACKButton4.Size = new System.Drawing.Size(101, 49);
            this.BACKButton4.TabIndex = 33;
            this.BACKButton4.Text = "Back";
            this.BACKButton4.UseVisualStyleBackColor = false;
            this.BACKButton4.Click += new System.EventHandler(this.BACKButton4_Click);
            // 
            // GenderCheckpoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(571, 899);
            this.Controls.Add(this.BACKButton4);
            this.Controls.Add(this.FEMALEButton2);
            this.Controls.Add(this.MALEButton1);
            this.Controls.Add(this.roundedPictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GenderCheckpoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STI GearPoint";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RoundedPictureBox roundedPictureBox1;
        private RoundButton MALEButton1;
        private RoundButton FEMALEButton2;
        private RoundButton BACKButton4;
    }
}