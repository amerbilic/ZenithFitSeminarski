using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenithFit.Model;

namespace ZenithFit.WinUI.Procurements
{
    public partial class frmProcurementsSearch : Form
    {
        private readonly APIService _serviceProcurements = new APIService("Procurements");
        private readonly APIService _serviceProcurementDetails = new APIService("ProcurementDetails");
        public frmProcurementsSearch()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            List<Model.Procurements> Total = await _serviceProcurements.Get<List<Model.Procurements>>(null);
            List<Model.Procurements> list = new List<Model.Procurements>();

            foreach(var item in Total)
            {
                Model.Procurements newitem = new Model.Procurements();

                if(dtpDate1.Value <= item.ProcurementDate && item.ProcurementDate <= dtpDate2.Value)
                {
                    newitem = item;
                    list.Add(newitem);

                }
            }

            dgvProcurements.DataSource = list;
               
        }

        private async void dgvProcurements_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvProcurements.SelectedRows[0].Cells[0].Value;

            Model.Procurements newitem = await _serviceProcurements.GetbyId<Model.Procurements>(id);

            List<Model.ProcurementDetails> list = await _serviceProcurementDetails.Get<List<Model.ProcurementDetails>>(null);

            List<Model.ProcurementDetails> result = new List<ProcurementDetails>();

            foreach (var item in list)
            {
                if (item.ProcurementId == newitem.ProcurementId)
                {

                    result.Add(item);
                }
            }

            dgvProcurementDetails.DataSource = result;
        }
    }
}
