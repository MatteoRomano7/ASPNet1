using System;
using System.Configuration;

namespace NomeProgetto
{
    public partial class VisualizzaDati : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVisualizza_Click(object sender, EventArgs e)
        {
            string nome = ConfigurationManager.AppSettings["Nome"];
            string cognome = ConfigurationManager.AppSettings["Cognome"];

            lblDati.Text = $"Nome: {nome}, Cognome: {cognome}";
        }
    }
}
