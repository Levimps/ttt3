using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T4ClassLibrary1;   

namespace tut3
{
    public partial class Form1 : Form

    {

        private VTNZ _vtnz;
        private List<IService> _services;

        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayVTNZdetails();
            DisplayService();
        }

        private void DisplayVTNZdetails()
        {
            _vtnz = new VTNZ("VTNZ North Harbour", "3-5 Saturn Place, Albany", "Mon - Fri 7.30am - 5pm");
            lblHeader.Text = _vtnz.ShowStationDetails();
        }


        private void DisplayService()
        {
            _services = new List<IService>
            {
                new CarServiceWrap ("WoF inspection",50M),
                new CarServiceWrap ("Modified vechile Check-up",200M),
                new CarServiceWrap ("Pre-purchase inspection",150M),
                new CarServiceWrap ("certifivate of fitness",210M)

            };
            int Listlength = _services.Count;
            for (int i=0; i < Listlength; i++)
            {
                lstInspections.Items.Insert(i, _services[i].Type + " " + _services[i].Price);
            }
        }

        private void btRequestInspection_Click(object sender, EventArgs e)
        {
            if(lstInspections.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service type", "Error");
            }
            else
            {
                IService j = new CarServiceWrap();
                if (lstInspections.SelectedIndex == 0) { j = _services[0]; };
                if (lstInspections.SelectedIndex == 1) { j = _services[1]; };
                if (lstInspections.SelectedIndex == 2) { j = _services[2]; };
                if (lstInspections.SelectedIndex == 3) { j = _services[3]; };



                /*switch (lstInspections.SelectedIndex)
                {
                    case 0:
                        j = _services[0];
                        break;
                    case 1:
                        j = _services[1];
                        break;
                    case 2:
                        j = _services[2];
                        break;
                    case 3:
                        j = _services[3];
                        break;

                }*/

                _vtnz.RequestService(j);
                lblDetails.Text += _vtnz.ShowServiceDetail();
                lblTotalNumberOfRequest.Text = _vtnz.RequestNumber.ToString();
                lblTotalPrice.Text = _vtnz.TotalPrice.ToString();

            }
        }

        private void lblDetails_Click(object sender, EventArgs e)
        {

        }

        private void lbInspections_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {
            
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }
    }


}
