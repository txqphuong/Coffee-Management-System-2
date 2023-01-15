using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom11_QLQuanCafe.DAL;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Nhom11_QLQuanCafe.GUI
{
    public partial class Frm_InHDNhap : Form
    {
        public string maHDNhap = "";
        Util con = new Util();
        public Frm_InHDNhap()
        {
            InitializeComponent();
        }

        private void Frm_InHDNhap_Load(object sender, EventArgs e)
        {
            rp_HDNhap rp = new rp_HDNhap();
            rp.SetDatabaseLogon(con.StrServerName, con.StrDatabaseName);
            ParameterFieldDefinitions pfield = rp.DataDefinition.ParameterFields;

            ParameterFieldDefinition pfMaHD = pfield["PMaHDNhap"];
            ParameterDiscreteValue pdvMaHD = new ParameterDiscreteValue();
            pdvMaHD.Value = maHDNhap;
            pfMaHD.CurrentValues.Clear();
            pfMaHD.CurrentValues.Add(pdvMaHD);
            pfMaHD.ApplyCurrentValues(pfMaHD.CurrentValues);

            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
        }
    }
}
