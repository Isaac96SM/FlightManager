using FlightManagement.InsertSale;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightManagement
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (DDCustomer.DataValueField == "" && DDCustomer.DataTextField == "")
            {
                InsertSale.InsertSale customers = new InsertSale.InsertSale();

                Customer[] CustomerList = customers.GetCustomer();

                DDCustomer.DataSource = CustomerList;
                DDCustomer.DataTextField = "Name";
                DDCustomer.DataValueField = "Code";
                DDCustomer.DataBind();
            }

            if (DDFT.DataValueField == "" && DDFT.DataTextField == "")
            {
                InsertSale.InsertSale travels = new InsertSale.InsertSale();

                Travel[] TravelList = travels.GetTravel();

                DDFT.DataSource = TravelList;
                DDFT.DataTextField = "Origin_Destination";
                DDFT.DataValueField = "Code";
                DDFT.DataBind();
            }
        }

        protected void ButtonGetValues_Click(object sender, EventArgs e)
        {
           Char[] delimiter = { '-' };
           string[] values = DDRow.SelectedValue.Split(delimiter);
           int rowSelected = Int32.Parse(values[0]);
           string seatSelected = values[1].ToString();

           InsertSale.InsertSale sale = new InsertSale.InsertSale();
            
           Response result = sale.SaleRequest(rowSelected, seatSelected.ToString(), Int32.Parse(DDFT.SelectedValue), Int32.Parse(DDCustomer.SelectedValue));
            
            if (result.Result)
            {
                LabelResult.Text = result.ResultDescription.ToString();

                InsertSale.InsertSale seat = new InsertSale.InsertSale();

                Seats[] SeatsList = seat.GetSeats(Int32.Parse(DDFT.SelectedValue));

                DDRow.Items.Clear();
                DDRow.DataSource = SeatsList;
                DDRow.DataTextField = "Full";
                DDRow.DataValueField = "Full";
                DDRow.DataBind();
            }
        }
        protected void DDFT_Change(object sender, EventArgs e)
        {
            InsertSale.InsertSale travel = new InsertSale.InsertSale();

            Travel result = travel.GetTravelSelected(Int32.Parse(DDFT.SelectedValue));

            TextBoxDeparture.Text = result.Time_Departure.ToString();
            TextBoxArrived.Text = result.Time_Arrived.ToString();
            TextBoxCompany.Text = result.CompanyName.ToString();

            InsertSale.InsertSale seat = new InsertSale.InsertSale();

            Seats[] SeatsList = seat.GetSeats(Int32.Parse(DDFT.SelectedValue));

            DDRow.DataSource = SeatsList;
            DDRow.DataTextField = "Full";
            DDRow.DataValueField = "Full";
            DDRow.DataBind();
        }
    }
}