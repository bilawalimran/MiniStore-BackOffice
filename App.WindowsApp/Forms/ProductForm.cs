using App.Core.Models;
using App.Core.Utilites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm(ProductFormModeEnum mode, Product? p)
        {
            InitializeComponent();
            nuPrice.Maximum = Decimal.MaxValue;
            nuStock.Maximum = Int32.MaxValue;

            comCtg.Items.Clear();
            comCtg.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            comCtg.SelectedIndex = 0;

            combStatus.Items.Clear();
            combStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            combStatus.SelectedIndex = 0;


            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }
            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;
            }
            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {
                txtId.Text = p.Id;
                txtName.Text = p.Name;
                comCtg.SelectedItem = p.Category;
                combStatus.SelectedItem = p.Status;
                nuPrice.Value = p.Price;
                nuStock.Value = p.Stock;
            }

        }
    }
}
