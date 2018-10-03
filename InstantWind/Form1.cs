using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace InstantWind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            WebClient client = new WebClient();
            String downloadedString = client.DownloadString("http://wx.ivao.aero/metar.php");

            List<string> metars = new List<string>();

            lblRwy.Text = cmbRwy.SelectedItem.ToString();

            string icaoDaCercare = txtICAO.Text;
            lblICAO.Text = "AD: " + icaoDaCercare;
            string ventoTrovato = "";

            metars = downloadedString.Split('\n').ToList();

            for (int i = 0; i < metars.Count() - 1; i++)
            {
                if (metars[i].Substring(0, 4) == icaoDaCercare)
                {
                    ventoTrovato = metars[i];
                    break;
                }
                /*else
                {
                    throw new Exception();
                }*/
            }

            bool hasGust = false;
            try
            {
                ventoTrovato = ventoTrovato.Substring(13, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsupported ICAO code.", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int gust = 0;
            int vel_vento_med_gust = 0;
            if (ventoTrovato.Contains("G"))
            {
                hasGust = true;
                gust = Int32.Parse(ventoTrovato.Substring(6, 2));

                //in caso di raffiche si fa la media
                string prova = ventoTrovato.Substring(3, 2);
                vel_vento_med_gust = (int)((Int32.Parse(ventoTrovato.Substring(3, 2)) + gust) / 2);
            }
            else
            {
                ventoTrovato = ventoTrovato.Substring(0, 7);
            }

            lblMETARwind.Text = ventoTrovato;


            if (!hasGust)
            {
                /* WIND TDZ */
                Random rTDZ = new Random();
                int dir_vento_TDZ = Int32.Parse(ventoTrovato.Substring(0, 3));
                int vel_vento_TDZ = Int32.Parse(ventoTrovato.Substring(3, 2));

                // CALCOLO NUOVA DIREZIONE VENTO: precedente + o - 25 gradi
                int new_dir_vento_TDZ = rTDZ.Next((dir_vento_TDZ - 25), (dir_vento_TDZ + 25));

                if (new_dir_vento_TDZ > 360) new_dir_vento_TDZ -= 360;
                if (new_dir_vento_TDZ < 0) new_dir_vento_TDZ += 360;

                // CALCOLO NUOVA VELOCITA' VENTO: precedente + o - 10% del valore
                int new_vel_vento_TDZ = rTDZ.Next(((int)((vel_vento_TDZ * 10) / 100)), (vel_vento_TDZ + (int)((vel_vento_TDZ * 10) / 100)));

                if (vel_vento_TDZ < 0) vel_vento_TDZ = 0;


                lblTDZ.Text = new_dir_vento_TDZ.ToString() + " DEG / " + new_vel_vento_TDZ.ToString() + " KT";

                /* WIND MID */
                Random rMID = new Random();
                int dir_vento_MID = Int32.Parse(ventoTrovato.Substring(0, 3));
                int vel_vento_MID = Int32.Parse(ventoTrovato.Substring(3, 2));

                int new_dir_vento_MID = rTDZ.Next((dir_vento_MID - 15), (dir_vento_MID + 15));
                if (new_dir_vento_MID > 360) new_dir_vento_MID -= 360;
                if (new_dir_vento_MID < 0) new_dir_vento_MID += 360;

                int new_vel_vento_MID = rTDZ.Next((vel_vento_MID - 5), (vel_vento_MID + 6));
                if (vel_vento_MID < 0) vel_vento_MID = 0;

                lblMID.Text = new_dir_vento_MID.ToString() + " DEG / " + new_vel_vento_MID.ToString() + " KT";

                /* WIND END */
                Random rEND = new Random();
                int dir_vento_END = Int32.Parse(ventoTrovato.Substring(0, 3));
                int vel_vento_END = Int32.Parse(ventoTrovato.Substring(3, 2));

                int new_dir_vento_END = rTDZ.Next((dir_vento_END - 15), (dir_vento_END + 15));
                if (new_dir_vento_END > 360) new_dir_vento_END -= 360;
                if (new_dir_vento_END < 0) new_dir_vento_END += 360;

                int new_vel_vento_END = rTDZ.Next((vel_vento_END - 5), (vel_vento_END + 6));
                if (vel_vento_END < 0) vel_vento_END = 0;

                lblEND.Text = new_dir_vento_END.ToString() + " DEG / " + new_vel_vento_END.ToString() + " KT";
            }

            else
            {
                /* WIND TDZ */
                Random rTDZ = new Random();
                int dir_vento_TDZ = Int32.Parse(ventoTrovato.Substring(0, 3));
                int vel_vento_TDZ = vel_vento_med_gust;

                // CALCOLO NUOVA DIREZIONE VENTO: precedente + o - 25 gradi
                int new_dir_vento_TDZ = rTDZ.Next((dir_vento_TDZ - 25), (dir_vento_TDZ + 25));

                if (new_dir_vento_TDZ > 360) new_dir_vento_TDZ -= 360;
                if (new_dir_vento_TDZ < 0) new_dir_vento_TDZ += 360;

                // CALCOLO NUOVA VELOCITA' VENTO: precedente + o - 10% del valore
                int new_vel_vento_TDZ = rTDZ.Next(((int)((vel_vento_TDZ * 10) / 100)), (vel_vento_TDZ + (int)((vel_vento_TDZ * 10) / 100)));

                if (vel_vento_TDZ < 0) vel_vento_TDZ = 0;


                lblTDZ.Text = new_dir_vento_TDZ.ToString() + " DEG / " + new_vel_vento_TDZ.ToString() + " KT";

                /* WIND MID */
                Random rMID = new Random();
                int dir_vento_MID = Int32.Parse(ventoTrovato.Substring(0, 3));
                int vel_vento_MID = vel_vento_med_gust;

                int new_dir_vento_MID = rTDZ.Next((dir_vento_MID - 15), (dir_vento_MID + 15));
                if (new_dir_vento_MID > 360) new_dir_vento_MID -= 360;
                if (new_dir_vento_MID < 0) new_dir_vento_MID += 360;

                int new_vel_vento_MID = rTDZ.Next((vel_vento_MID - 5), (vel_vento_MID + 6));
                if (vel_vento_MID < 0) vel_vento_MID = 0;

                lblMID.Text = new_dir_vento_MID.ToString() + " DEG / " + new_vel_vento_MID.ToString() + " KT";

                /* WIND END */
                Random rEND = new Random();
                int dir_vento_END = Int32.Parse(ventoTrovato.Substring(0, 3));
                int vel_vento_END = vel_vento_med_gust;

                int new_dir_vento_END = rTDZ.Next((dir_vento_END - 15), (dir_vento_END + 15));
                if (new_dir_vento_END > 360) new_dir_vento_END -= 360;
                if (new_dir_vento_END < 0) new_dir_vento_END += 360;

                int new_vel_vento_END = rTDZ.Next((vel_vento_END - 5), (vel_vento_END + 6));
                if (vel_vento_END < 0) vel_vento_END = 0;

                lblEND.Text = new_dir_vento_END.ToString() + " DEG / " + new_vel_vento_END.ToString() + " KT";
            }

            lblMETARwind.Text = ventoTrovato;

            timer1.Enabled = true;
            rtngSTATUS.FillColor = Color.DarkOrange;


            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtICAO.Text != "")
            {
                WebClient client = new WebClient();
                String downloadedString = client.DownloadString("http://wx.ivao.aero/metar.php");

                List<string> metars = new List<string>();


                string icaoDaCercare = txtICAO.Text;
                lblICAO.Text = "AD: " + icaoDaCercare;
                string ventoTrovato = "";

                metars = downloadedString.Split('\n').ToList();

                for (int i = 0; i < metars.Count() - 1; i++)
                {
                    if (metars[i].Substring(0, 4) == icaoDaCercare)
                    {
                        ventoTrovato = metars[i];
                        break;
                    }
                    /*else
                    {
                        throw new Exception();
                    }*/
                }

                bool hasGust = false;
                ventoTrovato = ventoTrovato.Substring(13, 10);
                int gust = 0;
                int vel_vento_med_gust = 0;
                if (ventoTrovato.Contains("G"))
                {
                    hasGust = true;
                    gust = Int32.Parse(ventoTrovato.Substring(6, 2));

                    //in caso di raffiche si fa la media
                    string prova = ventoTrovato.Substring(3, 2);
                    vel_vento_med_gust = (int)((Int32.Parse(ventoTrovato.Substring(3, 2)) + gust) / 2);
                }
                else
                {
                    ventoTrovato = ventoTrovato.Substring(0, 7);
                }

                lblMETARwind.Text = ventoTrovato;


                if (!hasGust)
                {
                    /* WIND TDZ */
                    Random rTDZ = new Random();
                    int dir_vento_TDZ = Int32.Parse(ventoTrovato.Substring(0, 3));
                    int vel_vento_TDZ = Int32.Parse(ventoTrovato.Substring(3, 2));

                    // CALCOLO NUOVA DIREZIONE VENTO: precedente + o - 25 gradi
                    int new_dir_vento_TDZ = rTDZ.Next((dir_vento_TDZ - 25), (dir_vento_TDZ + 25));

                    if (new_dir_vento_TDZ > 360) new_dir_vento_TDZ -= 360;
                    if (new_dir_vento_TDZ < 0) new_dir_vento_TDZ += 360;

                    // CALCOLO NUOVA VELOCITA' VENTO: precedente + o - 10% del valore
                    int new_vel_vento_TDZ = rTDZ.Next(((int)((vel_vento_TDZ * 10) / 100)), (vel_vento_TDZ + (int)((vel_vento_TDZ * 10) / 100)));

                    if (vel_vento_TDZ < 0) vel_vento_TDZ = 0;


                    lblTDZ.Text = new_dir_vento_TDZ.ToString() + " DEG / " + new_vel_vento_TDZ.ToString() + " KT";

                    /* WIND MID */
                    Random rMID = new Random();
                    int dir_vento_MID = Int32.Parse(ventoTrovato.Substring(0, 3));
                    int vel_vento_MID = Int32.Parse(ventoTrovato.Substring(3, 2));

                    int new_dir_vento_MID = rTDZ.Next((dir_vento_MID - 15), (dir_vento_MID + 15));
                    if (new_dir_vento_MID > 360) new_dir_vento_MID -= 360;
                    if (new_dir_vento_MID < 0) new_dir_vento_MID += 360;

                    int new_vel_vento_MID = rTDZ.Next((vel_vento_MID - 5), (vel_vento_MID + 6));
                    if (vel_vento_MID < 0) vel_vento_MID = 0;

                    lblMID.Text = new_dir_vento_MID.ToString() + " DEG / " + new_vel_vento_MID.ToString() + " KT";

                    /* WIND END */
                    Random rEND = new Random();
                    int dir_vento_END = Int32.Parse(ventoTrovato.Substring(0, 3));
                    int vel_vento_END = Int32.Parse(ventoTrovato.Substring(3, 2));

                    int new_dir_vento_END = rTDZ.Next((dir_vento_END - 15), (dir_vento_END + 15));
                    if (new_dir_vento_END > 360) new_dir_vento_END -= 360;
                    if (new_dir_vento_END < 0) new_dir_vento_END += 360;

                    int new_vel_vento_END = rTDZ.Next((vel_vento_END - 5), (vel_vento_END + 6));
                    if (vel_vento_END < 0) vel_vento_END = 0;

                    lblEND.Text = new_dir_vento_END.ToString() + " DEG / " + new_vel_vento_END.ToString() + " KT";
                }

                else
                {
                    /* WIND TDZ */
                    Random rTDZ = new Random();
                    int dir_vento_TDZ = Int32.Parse(ventoTrovato.Substring(0, 3));
                    int vel_vento_TDZ = vel_vento_med_gust;

                    // CALCOLO NUOVA DIREZIONE VENTO: precedente + o - 25 gradi
                    int new_dir_vento_TDZ = rTDZ.Next((dir_vento_TDZ - 25), (dir_vento_TDZ + 25));

                    if (new_dir_vento_TDZ > 360) new_dir_vento_TDZ -= 360;
                    if (new_dir_vento_TDZ < 0) new_dir_vento_TDZ += 360;

                    // CALCOLO NUOVA VELOCITA' VENTO: precedente + o - 10% del valore
                    int new_vel_vento_TDZ = rTDZ.Next(((int)((vel_vento_TDZ * 10) / 100)), (vel_vento_TDZ + (int)((vel_vento_TDZ * 10) / 100)));

                    if (vel_vento_TDZ < 0) vel_vento_TDZ = 0;


                    lblTDZ.Text = new_dir_vento_TDZ.ToString() + " DEG / " + new_vel_vento_TDZ.ToString() + " KT";

                    /* WIND MID */
                    Random rMID = new Random();
                    int dir_vento_MID = Int32.Parse(ventoTrovato.Substring(0, 3));
                    int vel_vento_MID = vel_vento_med_gust;

                    int new_dir_vento_MID = rTDZ.Next((dir_vento_MID - 15), (dir_vento_MID + 15));
                    if (new_dir_vento_MID > 360) new_dir_vento_MID -= 360;
                    if (new_dir_vento_MID < 0) new_dir_vento_MID += 360;

                    int new_vel_vento_MID = rTDZ.Next((vel_vento_MID - 5), (vel_vento_MID + 6));
                    if (vel_vento_MID < 0) vel_vento_MID = 0;

                    lblMID.Text = new_dir_vento_MID.ToString() + " DEG / " + new_vel_vento_MID.ToString() + " KT";

                    /* WIND END */
                    Random rEND = new Random();
                    int dir_vento_END = Int32.Parse(ventoTrovato.Substring(0, 3));
                    int vel_vento_END = vel_vento_med_gust;

                    int new_dir_vento_END = rTDZ.Next((dir_vento_END - 15), (dir_vento_END + 15));
                    if (new_dir_vento_END > 360) new_dir_vento_END -= 360;
                    if (new_dir_vento_END < 0) new_dir_vento_END += 360;

                    int new_vel_vento_END = rTDZ.Next((vel_vento_END - 5), (vel_vento_END + 6));
                    if (vel_vento_END < 0) vel_vento_END = 0;

                    lblEND.Text = new_dir_vento_END.ToString() + " DEG / " + new_vel_vento_END.ToString() + " KT";
                }
            }
            rtngSTATUS.FillColor = Color.LightSeaGreen;
        }

        private void txtICAO_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (txtICAO.Text.Length == 4 && cmbRwy.SelectedIndex > -1)
            {
                btnGetICAO.Enabled = true;
            }
            else 
            {
                btnGetICAO.Enabled = false;
            }
        }

        private void orologio_Tick(object sender, EventArgs e)
        {
            lblOrario.Text = DateTime.Now.ToUniversalTime().ToString("HH:mm:ss");
        }

        private void cmbRwy_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            rtngSTATUS.FillColor = Color.Red;
            if (txtICAO.Text.Length == 4 && cmbRwy.SelectedIndex > -1)
            {
                btnGetICAO.Enabled = true;
            }
            else
            {
                btnGetICAO.Enabled = false;
            }
        }
        }
    }
