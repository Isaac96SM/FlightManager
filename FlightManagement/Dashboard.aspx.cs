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
            
        }
        //FALTA DEJAR LISTOS LOS ASIENTOS
        public GridViewRow GetValues() {

            if (DDFT.SelectedValue != "Choose")
            {
                GridViewRow row = GridView1.Rows[Int32.Parse(DDFT.SelectedValue) - 1];
                TextBoxDeparture.Text = row.Cells[3].Text;
                TextBoxArrived.Text   = row.Cells[4].Text;
                TextBoxCompany.Text   = row.Cells[9].Text;
                return row;
            }
            return null;  
        }

        public void SetSeats() {

            GridViewRow row = GetValues();
            int Capacity = Int32.Parse(row.Cells[6].Text);
            int Row      = Int32.Parse(row.Cells[7].Text);
            int SeatsRow = Int32.Parse(row.Cells[8].Text);

   
        }

        protected void ButtonGetValues_Click(object sender, EventArgs e)
        {
            SetSeats();
            InsertSale.InsertSale sale = new InsertSale.InsertSale();
            
           // Response result = sale.SaleRequest(Int32.Parse(DDRow.SelectedValue), DDColumn.SelectedValue.ToString(),Int32.Parse(DDFT.SelectedValue), Int32.Parse(DDCustomer.SelectedValue));
            
            
        }
    }
}