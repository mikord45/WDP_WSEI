using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloASPWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonOK_Click(object sender, EventArgs e)
        {
            LabelKomunikat1.Text = $"Witaj {TextBoxImie.Text} {TextBoxNazwisko.Text}!";
            int wiek = Convert.ToInt32(TextBoxWiek.Text);
            if(wiek < 67)
            {
                LabelKomunika2.Text = $"Do emerytury zostało {67-wiek} lat.";
            }
            else
            {
                LabelKomunika2.Text = "Jesteś emerytem";
            }
        }
    }
}