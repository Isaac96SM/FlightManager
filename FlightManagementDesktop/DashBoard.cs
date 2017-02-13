using System;
using FlightManagementDesktop.InsertSale;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlightManagementDesktop
{
    public partial class DashBoard : Form
    {
        public static bool Check { get; set; }

        public DashBoard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Check = false;

            if (DDCustomer.Text == "")
            {
                InsertSaleSoapClient customers = new InsertSaleSoapClient();

                Customer[] CustomerList = customers.GetCustomer();

                DDCustomer.DataSource = CustomerList;
                DDCustomer.DisplayMember = "Name";
                DDCustomer.ValueMember = "Code";
            }

            if (DDFT.Text == "")
            {
                InsertSaleSoapClient travels = new InsertSaleSoapClient();

                Travel[] TravelList = travels.GetTravel();

                DDFT.DataSource = TravelList;
                DDFT.DisplayMember = "Origin_Destination";
                DDFT.ValueMember = "Code";
            }
            Check = true;
        }

        private void ButtonGetValues_Click(object sender, EventArgs e)
        {
            Char[] delimiter = { '-' };
            string[] values = DDRow.SelectedValue.ToString().Split(delimiter);
            int rowSelected = Int32.Parse(values[0]);
            string seatSelected = values[1].ToString();

            InsertSaleSoapClient sale = new InsertSaleSoapClient();

            Response result = sale.SaleRequest(rowSelected, seatSelected.ToString(), Int32.Parse(DDFT.SelectedValue.ToString()), Int32.Parse(DDCustomer.SelectedValue.ToString()));

            if (result.Result)
            {
                LabelResult.Text = result.ResultDescription.ToString();

                InsertSaleSoapClient seat = new InsertSaleSoapClient();

                Seats[] SeatsList = seat.GetSeats(Int32.Parse(DDFT.SelectedValue.ToString()));

                DDRow.DataSource = SeatsList;
                DDRow.DisplayMember = "Full";
                DDRow.ValueMember = "Full";
            }
        }

        private void DDFT_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Checkear si el form esta totalmente cargado, sino lo esta no debe entrar ya que no esta establecido el ValueMember y no funciona.
            if (Check)
            {
                InsertSaleSoapClient travel = new InsertSaleSoapClient();

                Travel result = travel.GetTravelSelected(Int32.Parse(DDFT.SelectedValue.ToString()));

                TextBoxDeparture.Text = result.Time_Departure.ToString();
                TextBoxArrived.Text = result.Time_Arrived.ToString();
                TextBoxCompany.Text = result.CompanyName.ToString();

                InsertSaleSoapClient seat = new InsertSaleSoapClient();

                Seats[] SeatsList = seat.GetSeats(Int32.Parse(DDFT.SelectedValue.ToString()));

                DDRow.DataSource = SeatsList;
                DDRow.DisplayMember = "Full";
                DDRow.ValueMember = "Full";
            }
        }
    }
}
