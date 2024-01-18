using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WineryExportWS
{
    public partial class frmMain : Form
    {
        WsWinery.WswineryclassSoapClient wswinery = new WsWinery.WswineryclassSoapClient();
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database.Apridatabase(Properties.Settings.Default.StringaConnessione);


            DataTable DtCampagna = Database.Leggitabella("Select * from concampagna order by codice desc", "Campagna");
            CmbCampagna.DataSource = DtCampagna;
            CmbCampagna.ValueMember = "Codice";
            CmbCampagna.DisplayMember = "Descrizione";





            
            AbilitaEsportazione.Checked = Properties.Settings.Default.AbilitaEsportazione;
            this.SecondiIntervallo.Text = Properties.Settings.Default.SecondiIntervallo.ToString();
            this.cartella.Text = Properties.Settings.Default.CartellaFileExport;
            timer1.Interval = Properties.Settings.Default.SecondiIntervallo * 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EndpointAddress xx = new



            // wswinery.Endpoint.Address = (EndpointAddress) Properties.Settings.Default.IndirizzoWS;
            EndpointAddress Indirizzo = new EndpointAddress(Properties.Settings.Default.IndirizzoWS);
            wswinery.Endpoint.Address = Indirizzo;

            string sRisultato = "";

            sRisultato=wswinery.Login(Properties.Settings.Default.Username, Properties.Settings.Default.Password, Properties.Settings.Default.Partitaiva);



        }

        private void impostazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InviaFileAnalisi();



        }
        private void InviaFileAnalisi()
        {

            EndpointAddress Indirizzo = new EndpointAddress(Properties.Settings.Default.IndirizzoWS);
            wswinery.Endpoint.Address = Indirizzo;
            StatusLabel.Text = "Connessione in corso a: " + Properties.Settings.Default.IndirizzoWS;

            string sRisultato = "";
            try
            {
                sRisultato = wswinery.Login(Properties.Settings.Default.Username, Properties.Settings.Default.Password, Properties.Settings.Default.Partitaiva);

                StatusLabel.Text = "Connessione: " + sRisultato;



                if (sRisultato.Equals("OK"))
                {
                    ControllaFile();
                }
                else
                {
                    StatusLabel.Text = "Credenziali non valide";
                }

            }
            catch (Exception ex)
            {
                StatusLabel.Text = ex.Message;
            }

        }
        private void ControllaFile()
        {
            try
            {
                StatusLabel.Text = "Recupero file da percorso: " + Properties.Settings.Default.CartellaFileExport;

                string[] nfiles = System.IO.Directory.GetFiles(Properties.Settings.Default.CartellaFileExport);

                foreach (string xfile in nfiles)
                {
                    Boolean bEsporta = true;

                    string snomefile = System.IO.Path.GetFileName(xfile);
                     if (System.IO.File.Exists(Properties.Settings.Default.CartellaFileExport  + "/inviatiOK/" + snomefile))
                    {
                        bEsporta = false;
                        StatusLabel.Text = "Il file " + snomefile + " è già presente nella cartella INVIATIOK. Il file non verrà reinviato";
                    }

                     if (bEsporta)
                    { 
                        byte[] bytes = System.IO.File.ReadAllBytes(xfile);
                        string estensione = System.IO.Path.GetExtension(xfile).Substring(1);
                        string snomefileTemp = wswinery.ID_ReceiveFile(bytes, estensione);
                        string esito=      wswinery.ProcessafileStrumento(snomefileTemp,Properties.Settings.Default.Username,Properties.Settings.Default.Password,Properties.Settings.Default.Partitaiva, System.IO.Path.GetFileName(xfile));
                        string sNomeFileElaborato = "";
                        if (esito.Equals("OK"))
                        {
                            sNomeFileElaborato = Properties.Settings.Default.CartellaFileExport + "/inviatiOK";
                        }
                        else
                        {
                            sNomeFileElaborato = Properties.Settings.Default.CartellaFileExport + "/inviatiKO";
                        }
                    
                        try
                        {
                            System.IO.Directory.CreateDirectory(sNomeFileElaborato);
                        }
                        catch(Exception ex)
                        {

                        }

                        sNomeFileElaborato = sNomeFileElaborato + "/"  + System.IO.Path.GetFileName(xfile);
                        System.IO.File.Copy(xfile, sNomeFileElaborato);
                        //System.IO.File.Delete(xfile);

                    }


                }
            }
            catch(Exception ex)
            {
                StatusLabel.Text = ex.Message;
            }
            

        }

        private void AbilitaEsportazione_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = AbilitaEsportazione.Checked;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEsportaconferimenti_Click(object sender, EventArgs e)
        {
            EsportaConferimenti();
        }
        private void EsportaConferimenti()
        {

            EndpointAddress Indirizzo = new EndpointAddress(Properties.Settings.Default.IndirizzoWS);
            wswinery.Endpoint.Address = Indirizzo;
            StatusLabel.Text = "Connessione in corso a: " + Properties.Settings.Default.IndirizzoWS;

            string sRisultato = "";
            try
            {
                sRisultato = wswinery.Login(Properties.Settings.Default.Username, Properties.Settings.Default.Password, Properties.Settings.Default.Partitaiva);

                StatusLabel.Text = "Connessione: " + sRisultato;



                if (sRisultato.Equals("OK"))
                {
                    EsportaInfoConferimenti((string)CmbCampagna.SelectedValue);
                }
                else
                {
                    StatusLabel.Text = "Credenziali non valide";
                }

            }
            catch (Exception ex)
            {
                StatusLabel.Text = ex.Message;
            }

        }
        private void EsportaInfoConferimenti(string Idcampagna)
        {
            DataTable DtPesate = Database.Leggitabella("select Codice,Progressivo,IDSocio,DataEntrata,OraEntrata,PesoNetto,IDConVarietàUve from Pesate where idCampagna='" + Idcampagna + "'","Pesate");
            DataTable Dtvarieta = Database.Leggitabella("select * from Convarietauve" , "Varieta");
            DataTable DtSoci = Database.Leggitabella("select * from Soci", "Soci");
            DataSet Tabelle = new DataSet();
            Tabelle.Tables.Add(DtPesate);
            Tabelle.Tables.Add(Dtvarieta);
            Tabelle.Tables.Add(DtSoci);
            String Nomefile = "";
            Nomefile=System.IO.Path.GetDirectoryName( Assembly.GetEntryAssembly().Location);
            Nomefile = System.IO.Path.Combine(Nomefile, "Conferimenti.xml");

            Tabelle.WriteXml(Nomefile);


            byte[] bytes = System.IO.File.ReadAllBytes(Nomefile);
            string estensione = System.IO.Path.GetExtension(Nomefile).Substring(1);
            string snomefileTemp = wswinery.ID_ReceiveFile(bytes, estensione);
            string esito = wswinery.Processafileconferimenti(snomefileTemp, Properties.Settings.Default.Username, Properties.Settings.Default.Password, Properties.Settings.Default.Partitaiva);
            string sNomeFileElaborato = "";
            if (esito.Equals("OK"))
            {
                MessageBox.Show("Invio Concluso");
            }
            else
            {
               
            }

        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            InviaFileAnalisi();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
