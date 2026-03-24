namespace App.WindowsApp.Forms
{
    partial class ProductForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblStatus = new Label();
            lblId = new Label();
            txtName = new TextBox();
            comCtg = new ComboBox();
            combStatus = new ComboBox();
            nuPrice = new NumericUpDown();
            nuStock = new NumericUpDown();
            txtId = new TextBox();
            flowLayoutPanel = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuStock).BeginInit();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(lblName, 0, 0);
            tableLayoutPanel1.Controls.Add(lblCategory, 0, 1);
            tableLayoutPanel1.Controls.Add(lblPrice, 0, 2);
            tableLayoutPanel1.Controls.Add(lblStock, 0, 3);
            tableLayoutPanel1.Controls.Add(lblStatus, 0, 4);
            tableLayoutPanel1.Controls.Add(lblId, 0, 5);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(comCtg, 1, 1);
            tableLayoutPanel1.Controls.Add(combStatus, 1, 4);
            tableLayoutPanel1.Controls.Add(nuPrice, 1, 2);
            tableLayoutPanel1.Controls.Add(nuStock, 1, 3);
            tableLayoutPanel1.Controls.Add(txtId, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(748, 300);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Left;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Left;
            lblCategory.Location = new Point(3, 50);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 50);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Left;
            lblPrice.Location = new Point(3, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 50);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Dock = DockStyle.Left;
            lblStock.Location = new Point(3, 150);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 50);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Left;
            lblStatus.Location = new Point(3, 200);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 50);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Left;
            lblId.Location = new Point(3, 250);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 50);
            lblId.TabIndex = 5;
            lblId.Text = "ID";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(152, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(593, 23);
            txtName.TabIndex = 6;
            // 
            // comCtg
            // 
            comCtg.Dock = DockStyle.Fill;
            comCtg.FormattingEnabled = true;
            comCtg.Location = new Point(152, 53);
            comCtg.Name = "comCtg";
            comCtg.Size = new Size(593, 23);
            comCtg.TabIndex = 7;
            // 
            // combStatus
            // 
            combStatus.Dock = DockStyle.Fill;
            combStatus.FormattingEnabled = true;
            combStatus.Location = new Point(152, 203);
            combStatus.Name = "combStatus";
            combStatus.Size = new Size(593, 23);
            combStatus.TabIndex = 8;
            // 
            // nuPrice
            // 
            nuPrice.Dock = DockStyle.Fill;
            nuPrice.Location = new Point(152, 103);
            nuPrice.Name = "nuPrice";
            nuPrice.Size = new Size(593, 23);
            nuPrice.TabIndex = 9;
            // 
            // nuStock
            // 
            nuStock.Dock = DockStyle.Fill;
            nuStock.Location = new Point(152, 153);
            nuStock.Name = "nuStock";
            nuStock.Size = new Size(593, 23);
            nuStock.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(152, 253);
            txtId.Name = "txtId";
            txtId.Size = new Size(593, 23);
            txtId.TabIndex = 11;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(btnCancel);
            flowLayoutPanel.Controls.Add(btnSave);
            flowLayoutPanel.Dock = DockStyle.Bottom;
            flowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel.Location = new Point(0, 358);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(748, 76);
            flowLayoutPanel.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(670, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(589, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 434);
            Controls.Add(flowLayoutPanel);
            Controls.Add(tableLayoutPanel1);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuStock).EndInit();
            flowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;
        private Label lblStatus;
        private Label lblId;
        private TextBox txtName;
        private ComboBox comCtg;
        private ComboBox combStatus;
        private NumericUpDown nuPrice;
        private NumericUpDown nuStock;
        private FlowLayoutPanel flowLayoutPanel;
        private TextBox txtId;
        private Button btnCancel;
        private Button btnSave;
    }
}