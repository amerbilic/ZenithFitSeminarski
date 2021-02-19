using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenithFit.WinUI.Articles;
using ZenithFit.WinUI.Categories;
using ZenithFit.WinUI.Clients;
using ZenithFit.WinUI.Manufacturers;
using ZenithFit.WinUI.Messages;
using ZenithFit.WinUI.Orders;
using ZenithFit.WinUI.Procurements;
using ZenithFit.WinUI.Reports;
using ZenithFit.WinUI.Suppliers;
using ZenithFit.WinUI.Users;
using ZenithFit.WinUI.Warehouses;

namespace ZenithFit.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersDetails frm = new frmUsersDetails();
            frm.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmArticles frm = new frmArticles();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }

        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories frm = new frmCategories();
            frm.Show();
        }


        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProcurementsSearch frm = new frmProcurementsSearch();
            frm.Show();
        }

        private void newProcurementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcurementsNew frm = new frmProcurementsNew();
            frm.Show();
        }

        private void searchToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmWarehousesSearch frm = new frmWarehousesSearch();
            frm.Show();
        }

        private void newWarehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWarehousesNew frm = new frmWarehousesNew();
            frm.Show();
        }

        private void searchToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmArticlesSearch frm = new frmArticlesSearch();
            frm.Show();
        }

        private void searchToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmSuppliersSearch frm = new frmSuppliersSearch();
            frm.Show();
        }

        private void newSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuppliersNew frm = new frmSuppliersNew();
            frm.Show();
        }

        private void searchToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmManufacturersSearch frm = new frmManufacturersSearch();
            frm.Show();
        }

        private void searchToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmOrdersSearch frm = new frmOrdersSearch();
            frm.Show();
        }

        private void newManufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManufacturersNew frm = new frmManufacturersNew();
            frm.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportsIndex frm = new frmReportsIndex();
            frm.Show();
        }

        private void searchToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmClientsSearch frm = new frmClientsSearch();
            frm.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMessagesView frm = new frmMessagesView();
            frm.Show();
        }
    }
}
