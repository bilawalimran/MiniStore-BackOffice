namespace App.WindowsApp.Views
{
    partial class ProductsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblProducts = new TableLayoutPanel();
            pnlToolbar = new Panel();
            tsProducts = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            pnlFilters = new Panel();
            tblFilters = new TableLayoutPanel();
            lblSearch = new Label();
            lblCategory = new Label();
            lblStockStatus = new Label();
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            cmbStockStatus = new ComboBox();
            pnlGrid = new Panel();
            dgvProducts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tblProducts.SuspendLayout();
            pnlToolbar.SuspendLayout();
            tsProducts.SuspendLayout();
            pnlFilters.SuspendLayout();
            tblFilters.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tblProducts
            // 
            tblProducts.ColumnCount = 1;
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tblProducts.Controls.Add(pnlToolbar, 0, 0);
            tblProducts.Controls.Add(pnlFilters, 0, 1);
            tblProducts.Controls.Add(pnlGrid, 0, 2);
            tblProducts.Dock = DockStyle.Fill;
            tblProducts.Location = new Point(0, 0);
            tblProducts.Margin = new Padding(4, 3, 4, 3);
            tblProducts.Name = "tblProducts";
            tblProducts.Padding = new Padding(19, 18, 19, 18);
            tblProducts.RowCount = 3;
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tblProducts.Size = new Size(883, 462);
            tblProducts.TabIndex = 0;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.White;
            pnlToolbar.Controls.Add(tsProducts);
            pnlToolbar.Dock = DockStyle.Fill;
            pnlToolbar.Location = new Point(23, 21);
            pnlToolbar.Margin = new Padding(4, 3, 4, 3);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(837, 59);
            pnlToolbar.TabIndex = 0;
            // 
            // tsProducts
            // 
            tsProducts.Dock = DockStyle.Fill;
            tsProducts.GripStyle = ToolStripGripStyle.Hidden;
            tsProducts.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, toolStripSeparator, tsbRefresh });
            tsProducts.Location = new Point(0, 0);
            tsProducts.Name = "tsProducts";
            tsProducts.Size = new Size(837, 59);
            tsProducts.TabIndex = 0;
            tsProducts.Text = "toolStrip1";
            tsProducts.ItemClicked += tsProducts_ItemClicked;
            // 
            // tsbAdd
            // 
            tsbAdd.Image = Properties.Resources.square_plus;
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(49, 56);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = Properties.Resources.edit;
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(47, 56);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.Image = Properties.Resources.eye;
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(52, 56);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = Properties.Resources.trash;
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(60, 56);
            tsbDelete.Text = "Delete";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 59);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = Properties.Resources.refresh1;
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(66, 56);
            tsbRefresh.Text = "Refresh";
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.White;
            pnlFilters.Controls.Add(tblFilters);
            pnlFilters.Dock = DockStyle.Fill;
            pnlFilters.Location = new Point(23, 86);
            pnlFilters.Margin = new Padding(4, 3, 4, 3);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(14, 12, 14, 12);
            pnlFilters.Size = new Size(837, 91);
            pnlFilters.TabIndex = 1;
            // 
            // tblFilters
            // 
            tblFilters.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblFilters.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblFilters.ColumnCount = 3;
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.Controls.Add(lblSearch, 0, 0);
            tblFilters.Controls.Add(lblCategory, 1, 0);
            tblFilters.Controls.Add(lblStockStatus, 2, 0);
            tblFilters.Controls.Add(txtSearch, 0, 1);
            tblFilters.Controls.Add(cmbCategory, 1, 1);
            tblFilters.Controls.Add(cmbStockStatus, 2, 1);
            tblFilters.Dock = DockStyle.Fill;
            tblFilters.Location = new Point(14, 12);
            tblFilters.Margin = new Padding(4, 3, 4, 3);
            tblFilters.Name = "tblFilters";
            tblFilters.RowCount = 2;
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilters.Size = new Size(809, 67);
            tblFilters.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(5, 1);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(314, 32);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(328, 1);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(233, 32);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Dock = DockStyle.Fill;
            lblStockStatus.Location = new Point(570, 1);
            lblStockStatus.Margin = new Padding(4, 0, 4, 0);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(234, 32);
            lblStockStatus.TabIndex = 2;
            lblStockStatus.Text = "Stock Status";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(5, 37);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(314, 23);
            txtSearch.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(328, 37);
            cmbCategory.Margin = new Padding(4, 3, 4, 3);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(233, 23);
            cmbCategory.TabIndex = 4;
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.FormattingEnabled = true;
            cmbStockStatus.Location = new Point(570, 37);
            cmbStockStatus.Margin = new Padding(4, 3, 4, 3);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(234, 23);
            cmbStockStatus.TabIndex = 5;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvProducts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(23, 183);
            pnlGrid.Margin = new Padding(4, 3, 4, 3);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(14);
            pnlGrid.Size = new Size(837, 258);
            pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCategory, colPrice, colStock, colStatus });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(14, 14);
            dgvProducts.Margin = new Padding(4, 3, 4, 3);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(809, 230);
            dgvProducts.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "ID";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblProducts);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProductsView";
            Size = new Size(883, 462);
            Load += ProductsView_Load;
            tblProducts.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            tsProducts.ResumeLayout(false);
            tsProducts.PerformLayout();
            pnlFilters.ResumeLayout(false);
            tblFilters.ResumeLayout(false);
            tblFilters.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblProducts;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.ToolStrip tsProducts;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TableLayoutPanel tblFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStockStatus;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colStatus;
    }
}
