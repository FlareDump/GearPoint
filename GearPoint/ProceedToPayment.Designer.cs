namespace GearPoint
{
    partial class ProceedToPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProceedToPayment));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roundedPictureBox1 = new GearPoint.RoundedPictureBox();
            this.DIRIMAKITAANGGIPALIT = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new RoundButton();
            this.ProceedPaymentButton = new RoundButton();
            this.roundedPanel1 = new GearPoint.RoundedPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-9, -1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(585, 80);
            this.dataGridView1.TabIndex = 6;
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPictureBox1.BackgroundImage")));
            this.roundedPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundedPictureBox1.CornerRadius = 40;
            this.roundedPictureBox1.Location = new System.Drawing.Point(23, 15);
            this.roundedPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Size = new System.Drawing.Size(111, 53);
            this.roundedPictureBox1.TabIndex = 7;
            this.roundedPictureBox1.TabStop = false;
            // 
            // DIRIMAKITAANGGIPALIT
            // 
            this.DIRIMAKITAANGGIPALIT.FormattingEnabled = true;
            this.DIRIMAKITAANGGIPALIT.ItemHeight = 16;
            this.DIRIMAKITAANGGIPALIT.Location = new System.Drawing.Point(25, 46);
            this.DIRIMAKITAANGGIPALIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DIRIMAKITAANGGIPALIT.Name = "DIRIMAKITAANGGIPALIT";
            this.DIRIMAKITAANGGIPALIT.Size = new System.Drawing.Size(415, 580);
            this.DIRIMAKITAANGGIPALIT.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order Summary:";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BackButton.BorderRadius = 30;
            this.BackButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.BackButton.Location = new System.Drawing.Point(25, 647);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(113, 81);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click_1);
            // 
            // ProceedPaymentButton
            // 
            this.ProceedPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.ProceedPaymentButton.BorderRadius = 30;
            this.ProceedPaymentButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedPaymentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.ProceedPaymentButton.Location = new System.Drawing.Point(247, 647);
            this.ProceedPaymentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProceedPaymentButton.Name = "ProceedPaymentButton";
            this.ProceedPaymentButton.Size = new System.Drawing.Size(179, 81);
            this.ProceedPaymentButton.TabIndex = 11;
            this.ProceedPaymentButton.Text = "Confirm";
            this.ProceedPaymentButton.UseVisualStyleBackColor = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.PowderBlue;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Controls.Add(this.DIRIMAKITAANGGIPALIT);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.ProceedPaymentButton);
            this.roundedPanel1.Controls.Add(this.BackButton);
            this.roundedPanel1.Location = new System.Drawing.Point(23, 101);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(461, 743);
            this.roundedPanel1.TabIndex = 12;
            // 
            // ProceedToPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 876);
            this.Controls.Add(this.roundedPictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.roundedPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProceedToPayment";
            this.Text = "ProceedToPayment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPictureBox roundedPictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox DIRIMAKITAANGGIPALIT;
        private System.Windows.Forms.Label label1;
        private RoundButton BackButton;
        private RoundButton ProceedPaymentButton;
        private RoundedPanel roundedPanel1;
    }
}