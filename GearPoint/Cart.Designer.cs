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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundedPanel1 = new GearPoint.RoundedPanel();
            this.CartListGrid1 = new System.Windows.Forms.DataGridView();
            this.TotalResultlabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.BackButton = new RoundButton();
            this.ProceedPaymentButton = new RoundButton();
            this.roundedPictureBox1 = new GearPoint.RoundedPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartListGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(439, 65);
            this.dataGridView1.TabIndex = 4;
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
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.PowderBlue;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Controls.Add(this.CartListGrid1);
            this.roundedPanel1.Controls.Add(this.TotalResultlabel);
            this.roundedPanel1.Controls.Add(this.TotalLabel);
            this.roundedPanel1.Controls.Add(this.BackButton);
            this.roundedPanel1.Controls.Add(this.ProceedPaymentButton);
            this.roundedPanel1.Location = new System.Drawing.Point(8, 80);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(413, 611);
            this.roundedPanel1.TabIndex = 6;
            // 
            // CartListGrid1
            // 
            this.CartListGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.CartListGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartListGrid1.DefaultCellStyle = dataGridViewCellStyle1;
            this.CartListGrid1.Location = new System.Drawing.Point(12, 13);
            this.CartListGrid1.Margin = new System.Windows.Forms.Padding(2);
            this.CartListGrid1.Name = "CartListGrid1";
            this.CartListGrid1.RowHeadersWidth = 51;
            this.CartListGrid1.RowTemplate.Height = 24;
            this.CartListGrid1.Size = new System.Drawing.Size(388, 519);
            this.CartListGrid1.TabIndex = 8;
            this.CartListGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartListGrid1_CellContentClick);
            CartListGrid1.CellValueChanged += CartListGrid1_CellValueChanged;
            // 
            // TotalResultlabel
            // 
            this.TotalResultlabel.AutoSize = true;
            this.TotalResultlabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TotalResultlabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalResultlabel.Location = new System.Drawing.Point(247, 566);
            this.TotalResultlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalResultlabel.Name = "TotalResultlabel";
            this.TotalResultlabel.Size = new System.Drawing.Size(59, 22);
            this.TotalResultlabel.TabIndex = 6;
            this.TotalResultlabel.Text = "$0.00";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TotalLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(241, 548);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(44, 16);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "Total:";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BackButton.BorderRadius = 30;
            this.BackButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.BackButton.Location = new System.Drawing.Point(14, 548);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(61, 49);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ProceedPaymentButton
            // 
            this.ProceedPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.ProceedPaymentButton.BorderRadius = 30;
            this.ProceedPaymentButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedPaymentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.ProceedPaymentButton.Location = new System.Drawing.Point(80, 549);
            this.ProceedPaymentButton.Margin = new System.Windows.Forms.Padding(2);
            this.ProceedPaymentButton.Name = "ProceedPaymentButton";
            this.ProceedPaymentButton.Size = new System.Drawing.Size(159, 49);
            this.ProceedPaymentButton.TabIndex = 3;
            this.ProceedPaymentButton.Text = "Proceed to Payment";
            this.ProceedPaymentButton.UseVisualStyleBackColor = false;
            this.ProceedPaymentButton.Click += new System.EventHandler(this.ProceedPaymentButton_Click);
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPictureBox1.BackgroundImage")));
            this.roundedPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundedPictureBox1.CornerRadius = 40;
            this.roundedPictureBox1.Location = new System.Drawing.Point(20, 11);
            this.roundedPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Size = new System.Drawing.Size(83, 43);
            this.roundedPictureBox1.TabIndex = 5;
            this.roundedPictureBox1.TabStop = false;
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(428, 726);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundedPictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.Load += new System.EventHandler(this.Cart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartListGrid1)).EndInit();
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
        private System.Windows.Forms.DataGridView CartListGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}