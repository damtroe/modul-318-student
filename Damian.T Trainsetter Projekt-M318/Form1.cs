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
            string Connections = comboBox1.Text;
            {

                listBox1.Items.Clear();
                ITransport Transit = new Transport();
                var connections = Transit.GetConnections(comboBox1.Text, comboBox2.Text);
                foreach (Connection c in connections.ConnectionList)
                {

                    listBox1.Items.Add("Von " + c.From.Station.Name + " Nach " + c.To.Station.Name + c.From.Departure + c.To.Arrival + c.Duration);
                }
                if (comboBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("Abfahrtsort muss ausgewählt werden!");
                }
            }
        }

         private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        } 
  
        //Uhrzeit
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(DateTime.Now.Hour) + " : " + Convert.ToString(DateTime.Now.Minute) + " : " + Convert.ToString(DateTime.Now.Second);
        }



        //DropBox Events

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string suche = comboBox1.Text;

            ITransport Transit = new Transport();
            var stations = Transit.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
            comboBox1.Items.Add("" + s.Name  );


            }
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string suche = comboBox2.Text;

            ITransport Transit = new Transport();
            var stations = Transit.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
                comboBox2.Items.Add("" + s.Name);


            }






        }     
    }
}


