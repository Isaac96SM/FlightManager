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
            
            InsertSale.InsertSale customers = new InsertSale.InsertSale();

            Customer[] CustomerList = customers.GetCustomer();

            DDCustomer.DataSource = CustomerList;
            DDCustomer.DataTextField = "Name";
            DDCustomer.DataValueField = "Code";
            DDCustomer.DataBind();
        }
        //FALTA DEJAR LISTOS LOS ASIENTOS
        public GridViewRow GetValues()
        {
            if (DDFT.SelectedValue != "Choose")
            {
                GridViewRow row = GridView1.Rows[0];
                foreach (GridViewRow Row in GridView1.Rows)
                {
                    if (Int32.Parse(DDFT.SelectedValue) == Int32.Parse(Row.Cells[0].Text.ToString()))
                    {
                        row = Row;
                        TextBoxDeparture.Text = row.Cells[3].Text;
                        TextBoxArrived.Text = row.Cells[4].Text;
                        TextBoxCompany.Text = row.Cells[9].Text;
                        break;
                    }
                }
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
           Char[] delimiter = { '-' };
           string[] values = DDRow.SelectedValue.Split(delimiter);
           int rowSelected = Int32.Parse(values[0]);
           string seatSelected = values[1].ToString();

           InsertSale.InsertSale sale = new InsertSale.InsertSale();
            
           Response result = sale.SaleRequest(rowSelected, seatSelected.ToString(), Int32.Parse(DDFT.SelectedValue), Int32.Parse(DDCustomer.SelectedValue));
            
            if (result.Result)
            {
                LabelResult.Text = result.ResultDescription.ToString();
                SetSeats();
                DDRow.DataBind();
            }
        }
        protected void DDFT_Change(object sender, EventArgs e)
        {
            SetSeats();
            DDRow.DataBind();
        }
    }
}