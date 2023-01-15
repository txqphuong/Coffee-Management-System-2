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
    public partial class Frm_InHoaDon : Form
    {
        public string maHD = "";
        Util con = new Util();
        public Frm_InHoaDon()
        {
            InitializeComponent();
        }

        private void Frm_InHoaDon_Load(object sender, EventArgs e)
        {
            rp_HoaDon rp = new rp_HoaDon();
            rp.SetDatabaseLogon(con.StrServerName, con.StrDatabaseName);
            ParameterFieldDefinitions pfield = rp.DataDefinition.ParameterFields;

            ParameterFieldDefinition pfMaHD = pfield["pMaHD"];
            ParameterDiscreteValue pdvMaHD = new ParameterDiscreteValue();
            pdvMaHD.Value = maHD;
            pfMaHD.CurrentValues.Clear();
            pfMaHD.CurrentValues.Add(pdvMaHD);
            pfMaHD.ApplyCurrentValues(pfMaHD.CurrentValues);

            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
        }
    }
}
