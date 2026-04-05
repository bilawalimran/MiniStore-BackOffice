using App.Core.Services;
using App.WindowsApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.WindowsApp.Forms

{
    public partial class MainForm : Form
    {
        InMemoryProductService _productService = new InMemoryProductService();
        InMemoryCustomerService _customerService = new InMemoryCustomerService();
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
        public MainForm()
        {
            InitializeComponent();
            _productService = new InMemoryProductService();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowView(() => new DashboardView());
            //this.pnlContent.Controls.Clear();
            //this.pnlContent.Controls.Add(new DashboardView());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(new ProductsView(_productService));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picUserIcon_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        private void btnOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ShowView(() => new CustomerView(_customerService));
        }

        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(T);

            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;
            }

            if (!pnlContent.Controls.Contains(view))
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            }

            view.BringToFront();
        }
    }
}
