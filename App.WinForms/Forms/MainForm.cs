using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.WinForms.Views;

namespace App.WinForms.Forms
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<Type,UserControl> _views = new Dictionary<Type,UserControl>();
        public MainForm()
        {
            InitializeComponent();
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
            ShowView(() => new ProductsView());
            //this.pnlContent.Controls.Clear();
            //this.pnlContent.Controls.Add(new ProductsView());
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
        private void ShowView<T>(Func<T> factory) where T:UserControl
        {
            var key = typeof(T);

            if(!_views.TryGetValue(key, out var view))
            {
                view = factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;
            }

            if(!pnlContent.Controls.Contains(view))
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            }

            view.BringToFront();
        }
    }
}
