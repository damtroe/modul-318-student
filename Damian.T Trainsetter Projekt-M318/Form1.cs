using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace Damian.T_Trainsetter_Projekt_M318
{
    public partial class Form1 : Form
    {
        public ITransport Transit = new Transport();
        public Form1()
        {
            InitializeComponent();
            dateTimePicker2.Value = DateTime.Now;
        }


        //Verbindung Suchen Funktion
        private void button1_Click(object sender, EventArgs e)
        {
            string Connections = cbBox1.Text;
            {
                string date = "&date=" + dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;
                string time = "&time=" + dateTimePicker2.Value.Hour + ":" + dateTimePicker2.Value.Minute;


                ITransport Transit = new Transport();
                Connections Connection = new Connections();
                Connection = Transit.GetConnections(cbBox1.Text, cbBox2.Text, date, time);
                if (lstview1.Columns.Count == 0)
                {
                    lstview1.Columns.Add("", 0);
                    lstview1.Columns.Add("Startstation", 120);
                    lstview1.Columns.Add("Endstation", 120);
                    lstview1.Columns.Add("Abfahrt", 120);
                    lstview1.Columns.Add("Ankunft", 120);
                    lstview1.Columns.Add("Dauer", 120);

                }
                lstview1.Items.Clear();

                foreach (Connection c in Connection.ConnectionList)
                {

                    ListViewItem item1 = new ListViewItem("");
                    DateTime Dt = Convert.ToDateTime(c.From.Departure);
                    DateTime Ar = Convert.ToDateTime(c.To.Arrival);
                    string Departure = Dt.ToShortTimeString();
                    string Arrival = Ar.ToShortTimeString();
                    string[] Duration = c.Duration.Split(':');

                    item1.SubItems.Add(c.From.Station.Name);
                    item1.SubItems.Add(c.To.Station.Name);
                    item1.SubItems.Add(Departure);
                    item1.SubItems.Add(Arrival);
                    item1.SubItems.Add(Duration[1] + "Min");
                    lstview1.Items.Add(item1);
                    lstview1.View = View.Details;
                    lstview1.FullRowSelect = true;

                }

                if (cbBox1.Text == "" || cbBox2.Text == "")
                {
                    MessageBox.Show("Abfahrtsort muss ausgewählt werden!");
                }

                btnweiterleiten.Visible = true;

            }
        }


        //Uhrzeit



        //DropBox Events

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string suche = cbBox1.Text;

            ITransport Transit = new Transport();
            var stations = Transit.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
                cbBox1.Items.Add("" + s.Name);
            }
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string suche = cbBox2.Text;

            ITransport Transit = new Transport();
            var stations = Transit.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
                cbBox2.Items.Add("" + s.Name);
            }
        }

        //Auto vervollständigungs Methode

        private void Autovervollständigung(ComboBox cb)
        {
            string cbtext = cb.Text;

            if (cbtext.Length >= 3)
            {

                Stations stations = new Stations();
                stations = Transit.GetStations(cbtext + ",");
                cb.Items.Clear();
                cb.DroppedDown = true;
                cb.SelectionStart = cb.Text.Length;
                foreach (Station s in stations.StationList)
                {
                    cb.Items.Add(s.Name);

                }

            }
        }
        //Auto vervollständigungs Event
        private void cbBox1_TextUpdate(object sender, EventArgs e)
        {
            Autovervollständigung(cbBox1);
        }

        private void cbBox2_TextUpdate(object sender, EventArgs e)
        {
            Autovervollständigung(cbBox2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnweiterleiten.Visible = false;
        }
        //Weiterleiten Funktion
        private void btn2_Click(object sender, EventArgs e)
        {
            if (lstview1.Items.Count != 0)
            {
                MessageBox.Show("Verbindung erfolgreich in Zwischen Ablage kopiert!" + "\n" +
                 "Startstation: " + lstview1.Items[0].SubItems[1].Text + "\n" +
                 "Endstation: " + lstview1.Items[0].SubItems[2].Text + "\n" +
                 "Abfahrt: " + lstview1.Items[0].SubItems[3].Text + "\n" +
                 "Ankunft: " + lstview1.Items[0].SubItems[4].Text + "\n" +
                 "Dauer: " + lstview1.Items[0].SubItems[5].Text
                );
            }
            Clipboard.SetText("Startstation: " + lstview1.Items[0].SubItems[1].Text + "\n" +
             "Endstation: " + lstview1.Items[0].SubItems[2].Text + "\n" +
             "Abfahrt: " + lstview1.Items[0].SubItems[3].Text + "\n" +
             "Ankunft: " + lstview1.Items[0].SubItems[4].Text + "\n" +
             "Dauer: " + lstview1.Items[0].SubItems[5].Text);
        }

        private void lstview1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("FeedBack An: datroe95@web.de\n\n Bei Problemen: 0799298401 ");
        }
    }
}