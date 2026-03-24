using System.Windows.Forms;

namespace App.WindowsApp.Views
{
    partial class DashboardView
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
            tblDashboard = new TableLayoutPanel();
            flpKPI = new FlowLayoutPanel();
            panel1 = new Panel();
            lblSaleV = new Label();
            lblSalesT = new Label();
            panel2 = new Panel();
            lblOrderV = new Label();
            lblOrderT = new Label();
            panel3 = new Panel();
            lblRevenueV = new Label();
            lblRevenueT = new Label();
            pnlLowStock = new Panel();
            lvLowStock = new ListView();
            colProduct = new ColumnHeader();
            colStock = new ColumnHeader();
            lblLowStock = new Label();
            pnlRecentOrders = new Panel();
            lvRecentOrders = new ListView();
            colOrders = new ColumnHeader();
            colCustomer = new ColumnHeader();
            colTotal = new ColumnHeader();
            colStatus = new ColumnHeader();
            lblRecentOrders = new Label();
            tblDashboard.SuspendLayout();
            flpKPI.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pnlLowStock.SuspendLayout();
            pnlRecentOrders.SuspendLayout();
            SuspendLayout();
            // 
            // tblDashboard
            // 
            tblDashboard.ColumnCount = 1;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDashboard.Controls.Add(flpKPI, 0, 0);
            tblDashboard.Controls.Add(pnlLowStock, 0, 1);
            tblDashboard.Controls.Add(pnlRecentOrders, 0, 2);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(0, 0);
            tblDashboard.Margin = new Padding(4, 3, 4, 3);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.RowCount = 3;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.Size = new Size(925, 486);
            tblDashboard.TabIndex = 0;
            // 
            // flpKPI
            // 
            flpKPI.Controls.Add(panel1);
            flpKPI.Controls.Add(panel2);
            flpKPI.Controls.Add(panel3);
            flpKPI.Dock = DockStyle.Fill;
            flpKPI.Location = new Point(4, 3);
            flpKPI.Margin = new Padding(4, 3, 4, 3);
            flpKPI.Name = "flpKPI";
            flpKPI.Size = new Size(917, 132);
            flpKPI.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblSaleV);
            panel1.Controls.Add(lblSalesT);
            panel1.Location = new Point(4, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 115);
            panel1.TabIndex = 0;
            // 
            // lblSaleV
            // 
            lblSaleV.AutoSize = true;
            lblSaleV.Location = new Point(134, 46);
            lblSaleV.Margin = new Padding(4, 0, 4, 0);
            lblSaleV.Name = "lblSaleV";
            lblSaleV.Size = new Size(25, 15);
            lblSaleV.TabIndex = 1;
            lblSaleV.Text = "100";
            // 
            // lblSalesT
            // 
            lblSalesT.AutoSize = true;
            lblSalesT.Location = new Point(15, 46);
            lblSalesT.Margin = new Padding(4, 0, 4, 0);
            lblSalesT.Name = "lblSalesT";
            lblSalesT.Size = new Size(33, 15);
            lblSalesT.TabIndex = 0;
            lblSalesT.Text = "Sales";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblOrderV);
            panel2.Controls.Add(lblOrderT);
            panel2.Location = new Point(245, 3);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(233, 115);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // lblOrderV
            // 
            lblOrderV.AutoSize = true;
            lblOrderV.Location = new Point(140, 46);
            lblOrderV.Margin = new Padding(4, 0, 4, 0);
            lblOrderV.Name = "lblOrderV";
            lblOrderV.Size = new Size(19, 15);
            lblOrderV.TabIndex = 1;
            lblOrderV.Text = "50";
            // 
            // lblOrderT
            // 
            lblOrderT.AutoSize = true;
            lblOrderT.Location = new Point(26, 46);
            lblOrderT.Margin = new Padding(4, 0, 4, 0);
            lblOrderT.Name = "lblOrderT";
            lblOrderT.Size = new Size(37, 15);
            lblOrderT.TabIndex = 0;
            lblOrderT.Text = "Order";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblRevenueV);
            panel3.Controls.Add(lblRevenueT);
            panel3.Location = new Point(486, 3);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(233, 115);
            panel3.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            lblRevenueV.AutoSize = true;
            lblRevenueV.Location = new Point(139, 46);
            lblRevenueV.Margin = new Padding(4, 0, 4, 0);
            lblRevenueV.Name = "lblRevenueV";
            lblRevenueV.Size = new Size(31, 15);
            lblRevenueV.TabIndex = 1;
            lblRevenueV.Text = "5000";
            // 
            // lblRevenueT
            // 
            lblRevenueT.AutoSize = true;
            lblRevenueT.Location = new Point(41, 46);
            lblRevenueT.Margin = new Padding(4, 0, 4, 0);
            lblRevenueT.Name = "lblRevenueT";
            lblRevenueT.Size = new Size(52, 15);
            lblRevenueT.TabIndex = 0;
            lblRevenueT.Text = "Revenue";
            // 
            // pnlLowStock
            // 
            pnlLowStock.Controls.Add(lvLowStock);
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Dock = DockStyle.Fill;
            pnlLowStock.Location = new Point(4, 141);
            pnlLowStock.Margin = new Padding(4, 3, 4, 3);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(917, 168);
            pnlLowStock.TabIndex = 1;
            pnlLowStock.Paint += panel4_Paint;
            // 
            // lvLowStock
            // 
            lvLowStock.Columns.AddRange(new ColumnHeader[] { colProduct, colStock });
            lvLowStock.Location = new Point(43, 53);
            lvLowStock.Margin = new Padding(4, 3, 4, 3);
            lvLowStock.Name = "lvLowStock";
            lvLowStock.Size = new Size(851, 91);
            lvLowStock.TabIndex = 1;
            lvLowStock.UseCompatibleStateImageBehavior = false;
            lvLowStock.View = View.Details;
            // 
            // colProduct
            // 
            colProduct.Text = "Product";
            // 
            // colStock
            // 
            colStock.Text = "Stock";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStock.Location = new Point(40, 22);
            lblLowStock.Margin = new Padding(4, 0, 4, 0);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(67, 13);
            lblLowStock.TabIndex = 0;
            lblLowStock.Text = "Low Stock";
            // 
            // pnlRecentOrders
            // 
            pnlRecentOrders.Controls.Add(lvRecentOrders);
            pnlRecentOrders.Controls.Add(lblRecentOrders);
            pnlRecentOrders.Dock = DockStyle.Fill;
            pnlRecentOrders.Location = new Point(4, 315);
            pnlRecentOrders.Margin = new Padding(4, 3, 4, 3);
            pnlRecentOrders.Name = "pnlRecentOrders";
            pnlRecentOrders.Size = new Size(917, 168);
            pnlRecentOrders.TabIndex = 2;
            // 
            // lvRecentOrders
            // 
            lvRecentOrders.Columns.AddRange(new ColumnHeader[] { colOrders, colCustomer, colTotal, colStatus });
            lvRecentOrders.Location = new Point(43, 44);
            lvRecentOrders.Margin = new Padding(4, 3, 4, 3);
            lvRecentOrders.Name = "lvRecentOrders";
            lvRecentOrders.Size = new Size(851, 119);
            lvRecentOrders.TabIndex = 1;
            lvRecentOrders.UseCompatibleStateImageBehavior = false;
            lvRecentOrders.View = View.Details;
            // 
            // colOrders
            // 
            colOrders.Text = "Orders";
            // 
            // colCustomer
            // 
            colCustomer.Text = "Customer";
            // 
            // colTotal
            // 
            colTotal.Text = "Total";
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            // 
            // lblRecentOrders
            // 
            lblRecentOrders.AutoSize = true;
            lblRecentOrders.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentOrders.Location = new Point(40, 15);
            lblRecentOrders.Margin = new Padding(4, 0, 4, 0);
            lblRecentOrders.Name = "lblRecentOrders";
            lblRecentOrders.Size = new Size(89, 13);
            lblRecentOrders.TabIndex = 0;
            lblRecentOrders.Text = "Recent Orders";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblDashboard);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashboardView";
            Size = new Size(925, 486);
            tblDashboard.ResumeLayout(false);
            flpKPI.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            pnlRecentOrders.ResumeLayout(false);
            pnlRecentOrders.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.FlowLayoutPanel flpKPI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSaleV;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOrderV;
        private System.Windows.Forms.Label lblOrderT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.ColumnHeader colProduct;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.ListView lvRecentOrders;
        private System.Windows.Forms.ColumnHeader colOrders;
        private System.Windows.Forms.ColumnHeader colCustomer;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Label lblRecentOrders;
    }
}
