namespace GearPoint
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.roundedPictureBox1 = new GearPoint.RoundedPictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RefNumber = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmBtn = new RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPictureBox1.BackgroundImage")));
            this.roundedPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundedPictureBox1.CornerRadius = 40;
            this.roundedPictureBox1.Location = new System.Drawing.Point(9, 9);
            this.roundedPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Size = new System.Drawing.Size(75, 43);
            this.roundedPictureBox1.TabIndex = 7;
            this.roundedPictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(289, 65);
            this.dataGridView1.TabIndex = 6;
            // 
            // RefNumber
            // 
            this.RefNumber.AutoSize = true;
            this.RefNumber.Font = new System.Drawing.Font("Helvetica", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefNumber.Location = new System.Drawing.Point(61, 97);
            this.RefNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RefNumber.Name = "RefNumber";
            this.RefNumber.Size = new System.Drawing.Size(106, 38);
            this.RefNumber.TabIndex = 8;
            this.RefNumber.Text = "label1";
            this.RefNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Reference Number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.ConfirmBtn.BorderRadius = 30;
            this.ConfirmBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.ConfirmBtn.Location = new System.Drawing.Point(86, 149);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(69, 36);
            this.ConfirmBtn.TabIndex = 10;
            this.ConfirmBtn.Text = "Close";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 196);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RefNumber);
            this.Controls.Add(this.roundedPictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Receipt";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedPictureBox roundedPictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label RefNumber;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label2;
        private RoundButton ConfirmBtn;
    }
}