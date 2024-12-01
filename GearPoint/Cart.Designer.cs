namespace GearPoint
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.roundedPanel1 = new GearPoint.RoundedPanel();
            this.CartListGrid1 = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CartListGrid = new System.Windows.Forms.DataGridView();
            this.TotalResultlabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.BackButton = new RoundButton();
            this.ProceedPaymentButton = new RoundButton();
            this.roundedPictureBox1 = new GearPoint.RoundedPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartListGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(585, 80);
            this.dataGridView1.TabIndex = 4;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.PowderBlue;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Controls.Add(this.CartListGrid1);
            this.roundedPanel1.Controls.Add(this.CartListGrid);
            this.roundedPanel1.Controls.Add(this.TotalResultlabel);
            this.roundedPanel1.Controls.Add(this.TotalLabel);
            this.roundedPanel1.Controls.Add(this.BackButton);
            this.roundedPanel1.Controls.Add(this.ProceedPaymentButton);
            this.roundedPanel1.Location = new System.Drawing.Point(36, 98);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(497, 752);
            this.roundedPanel1.TabIndex = 6;
            // 
            // CartListGrid1
            // 
            this.CartListGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.CartListGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartListGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Gender,
            this.Size,
            this.Quantity,
            this.Total});
            this.CartListGrid1.Location = new System.Drawing.Point(19, 25);
            this.CartListGrid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CartListGrid1.Name = "CartListGrid1";
            this.CartListGrid1.RowHeadersWidth = 51;
            this.CartListGrid1.RowTemplate.Height = 24;
            this.CartListGrid1.Size = new System.Drawing.Size(455, 631);
            this.CartListGrid1.TabIndex = 8;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.Width = 125;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // CartListGrid
            // 
            this.CartListGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.CartListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartListGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.CartListGrid.Location = new System.Drawing.Point(19, 25);
            this.CartListGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CartListGrid.Name = "CartListGrid";
            this.CartListGrid.RowHeadersWidth = 51;
            this.CartListGrid.RowTemplate.Height = 24;
            this.CartListGrid.Size = new System.Drawing.Size(455, 631);
            this.CartListGrid.TabIndex = 7;
            // 
            // TotalResultlabel
            // 
            this.TotalResultlabel.AutoSize = true;
            this.TotalResultlabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TotalResultlabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalResultlabel.Location = new System.Drawing.Point(377, 702);
            this.TotalResultlabel.Name = "TotalResultlabel";
            this.TotalResultlabel.Size = new System.Drawing.Size(70, 27);
            this.TotalResultlabel.TabIndex = 6;
            this.TotalResultlabel.Text = "$0.00";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TotalLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(325, 684);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(53, 19);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "Total:";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BackButton.BorderRadius = 30;
            this.BackButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.BackButton.Location = new System.Drawing.Point(19, 674);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(81, 60);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // ProceedPaymentButton
            // 
            this.ProceedPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.ProceedPaymentButton.BorderRadius = 30;
            this.ProceedPaymentButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedPaymentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.ProceedPaymentButton.Location = new System.Drawing.Point(107, 676);
            this.ProceedPaymentButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProceedPaymentButton.Name = "ProceedPaymentButton";
            this.ProceedPaymentButton.Size = new System.Drawing.Size(212, 60);
            this.ProceedPaymentButton.TabIndex = 3;
            this.ProceedPaymentButton.Text = "Proceed to Payment";
            this.ProceedPaymentButton.UseVisualStyleBackColor = false;
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPictureBox1.BackgroundImage")));
            this.roundedPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundedPictureBox1.CornerRadius = 40;
            this.roundedPictureBox1.Location = new System.Drawing.Point(27, 14);
            this.roundedPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Size = new System.Drawing.Size(111, 53);
            this.roundedPictureBox1.TabIndex = 5;
            this.roundedPictureBox1.TabStop = false;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(571, 878);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundedPictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Cart";
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartListGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CartListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPictureBox roundedPictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label TotalLabel;
        private RoundButton BackButton;
        private RoundButton ProceedPaymentButton;
        private System.Windows.Forms.Label TotalResultlabel;
        private System.Windows.Forms.DataGridView CartListGrid;
        private System.Windows.Forms.DataGridView CartListGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}