using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class WebForm_CurrencyConverter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Write("In Page Load");
        if (this.IsPostBack == false)
        {
            currency.Items.Add(new ListItem("Euros", "0.85"));
            currency.Items.Add(new ListItem("Japanese Yen", "110.33"));
            currency.Items.Add(new ListItem("Canadian Dollars", "1.2"));
        }
    }

    protected void Convert_ServerClick(object sender, EventArgs e)
    {
        //decimal USAmount = Decimal.Parse(US.Value);
        decimal USAmount;
        bool success = Decimal.TryParse(US.Value, out USAmount);

        if (success)
        {
            ListItem item = currency.Items[currency.SelectedIndex];
            decimal newAmount = USAmount * Decimal.Parse(item.Value);
            result.InnerText = USAmount.ToString() + " U.S. dollars = ";
            result.InnerText += newAmount.ToString() + " " + item.Text;

            graph.Visible = false;
        } else
        {
            result.InnerText = "Invalid input!";
        }        
    }

    protected void ShowGraph_ServerClick(Object sender, EventArgs e)
    {
        graph.Src = "Pic" + currency.SelectedIndex.ToString() + ".png";
        graph.Visible = true;
    }

    protected void Response_ServerClick(object sender, EventArgs e)
    {
        Response.Redirect("SecondPage.aspx");
    }

    protected void Transfer_ServerClick(object sender, EventArgs e)
    {
        Server.Transfer("SecondPage.aspx");
    }
}