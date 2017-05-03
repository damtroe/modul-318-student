﻿using System;
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

            domainUpDown1.Items.Add("00:00");
            domainUpDown1.Items.Add("01:00");
            domainUpDown1.Items.Add("02:00");


        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(DateTime.Now.Hour);
    }

     

        private void button1_Click(object sender, EventArgs e)
        {
            string Connections = comboBox1.Text;
            {
                ITransport Transit = new Transport();
                var connections = Transit.GetConnections("Sursee", "Luzern");
                foreach (Connection c in connections.ConnectionList)

                    listBox1.Items.Add("Von " + c.From.Station.Name + " Nach " + c.To.Station.Name + c.To.Arrival + c.From.Departure + c.Duration );
            }
        }


    /*   private void textBox2_TextChanged(object sender, EventArgs e)
       {
           string suche = textBox1.Text;

           ITransport testee = new Transport();
           var stations = testee.GetStations(suche);
           foreach (Station s in stations.StationList)
           {
               listBox1.Items.Add(" " + s.Name + "X:" + s.Coordinate.XCoordinate.ToString() + "Score" + s.Score);


           }
       }*/

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = Convert.ToString(DateTime.Now.Hour) + " : " + Convert.ToString(DateTime.Now.Minute) + " : " + Convert.ToString(DateTime.Now.Second);
        }

   

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            string suche = comboBox1.Text;

            ITransport testee = new Transport();
            var stations = testee.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
                comboBox1.Items.Add("" + s.Name  );


            }
        }

    
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            string suche = comboBox2.Text;

            ITransport testee = new Transport();
            var stations = testee.GetStations(suche);
            foreach (Station s in stations.StationList)
            {
                comboBox2.Items.Add("" + s.Name);


            }





        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}


