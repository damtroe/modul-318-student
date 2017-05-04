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
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(DateTime.Now.Hour);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Connections = cbBox1.Text;
            {
                listView1.Items.Clear();
                
                ITransport Transit = new Transport();
                var connections = Transit.GetConnections(cbBox1.Text, cbBox2.Text);
                foreach (Connection c in connections.ConnectionList)
                {
                    DateTime Dt = Convert.ToDateTime(c.From.Departure);
                    DateTime Ar = Convert.ToDateTime(c.To.Arrival);
                    string Departure = Dt.ToShortTimeString();
                    string Arrival = Ar.ToShortTimeString();
                    string[] Duration = c.Duration.Split(':');
                    //lstbox.Items.Add(" " + "Startstation" + "\t" + "Endstation" + "\t" + "Abfahrt" + "\t" + "Ankunft" + "\t" + "Dauer");
                   // lstbox.Items.Add(" " + c.From.Station.Name + "\t" + c.To.Station.Name + "\t\t" + Departure + "\t" + Arrival + "\t" + Duration[1] + " Min");
                


                listView1.Columns.Add("Startstation");
                listView1.Columns.Add("Endstation");
                listView1.Columns.Add("Abfahrt");
                listView1.Columns.Add("Ankunft");
                listView1.Columns.Add("Dauer");

                ListViewItem item1 = new ListViewItem(c.From.Station.Name);
                


                item1.SubItems.Add(c.From.Station.Name);
                item1.SubItems.Add(c.To.Station.Name);
                item1.SubItems.Add(Departure);
                item1.SubItems.Add(Arrival);
                item1.SubItems.Add(Duration[1]+"Min");

                listView1.Items.Add(item1);
                

                listView1.View = View.Details;
                listView1.FullRowSelect = true;


                }




                if (cbBox1.Text == "" || cbBox2.Text == "")
                {
                    MessageBox.Show("Abfahrtsort muss ausgewählt werden!");
                }

                btn2.Visible = true;

            }
        }


        //Uhrzeit
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(DateTime.Now.Hour) + " : " + Convert.ToString(DateTime.Now.Minute) + " : " + Convert.ToString(DateTime.Now.Second);
        }


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
            btn2.Visible = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            StringBuilder weiterleiten = new StringBuilder();
            foreach (object selectedItem in listView1.Items)
            {
                weiterleiten.AppendLine(selectedItem.ToString());
            }
            MessageBox.Show(Convert.ToString(weiterleiten));
        }


    }
}