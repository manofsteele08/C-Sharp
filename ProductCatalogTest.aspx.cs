using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class C_Sharp_ProductCatalogTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductCatalog pc = new ProductCatalog();

        pc.AddProduct("The Scorcher", 1000, "microwave.jpg");
        pc.AddProduct("The Whirlpool", 500, "mixer.jpg");
        pc.AddProduct("Buns Burner", 700, "toaster.jpg");

        Response.Write(pc.getCatalogHtml());

        TaxableProduct highProd = (TaxableProduct)pc.GetHighPricedProduct();
 
        Response.Write("The most Expensive product is: " + highProd.Name + " at $" + highProd.TotalPrice);

    }
}