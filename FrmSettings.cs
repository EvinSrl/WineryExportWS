using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WineryExportWS
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            SalvaImpostazioni();
        }
        private void SalvaImpostazioni()
        {
            Properties.Settings.Default.Username = Username.Text;
            Properties.Settings.Default.Password = Password.Text;
            Properties.Settings.Default.Partitaiva = PartitaIva.Text;
            Properties.Settings.Default.CodiceAzienda = CodiceAzienda.Text;
             Properties.Settings.Default.CartellaFileExport = CartellaExport.Text;

            Properties.Settings.Default.SecondiIntervallo = (int)SecondiIntervallo.Value;
            Properties.Settings.Default.IndirizzoWS = IndirizooWs.Text;
            Properties.Settings.Default.AbilitaEsportazione = AbilitaEsportazione.Checked;

            Properties.Settings.Default.Save();
        }



        private void FrmSettings_Load(object sender, EventArgs e)
        {
            CaricaImpostazioni();
        }
        private void CaricaImpostazioni()
        {
            Username.Text = Properties.Settings.Default.Username;

            Password.Text = Properties.Settings.Default.Password;
            PartitaIva.Text = Properties.Settings.Default.Partitaiva;
            CodiceAzienda.Text = Properties.Settings.Default.CodiceAzienda;
            CartellaExport.Text = Properties.Settings.Default.CartellaFileExport;
            SecondiIntervallo.Value = Properties.Settings.Default.SecondiIntervallo;
            IndirizooWs.Text = Properties.Settings.Default.IndirizzoWS;
            this.AbilitaEsportazione.Checked = Properties.Settings.Default.AbilitaEsportazione;

        }
    }
}
