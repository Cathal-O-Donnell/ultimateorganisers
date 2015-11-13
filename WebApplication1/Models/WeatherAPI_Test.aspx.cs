using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Models
{
    public partial class WeatherAPI_Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string input;

            //    Label1.Text =("Weather API Basic Text" );

            input = txtLocation.Text;
                    

            Conditions conditions = new Conditions();
            /*conditions = Weather.GetCurrentConditions(input.Substring(2, input.Length - 2));*/
            conditions = Weather.GetCurrentConditions(input);

            if (conditions != null)                
                            {                
                                lblConditions.Text = String.Format("Conditions: " + conditions.Condition);
                
                                lblTempF.Text = String.Format("Temperature (F): " + conditions.TempF);
                
                                lblTempC.Text = String.Format("Temperature (C): " + conditions.TempC);
                
                                lblHumidity.Text = String.Format("Humidity: " + conditions.Humidity);
                
                                lblWind.Text = String.Format("Wind: " + conditions.Wind);
                                
                            }
           
                            else
                            {                
                                lblConditions.Text = ("There was an error processing the request.");
                
                                lblHumidity.Text = ("Please, make sure you are using the correct location or try again later.");
                               
                            }           
            
         }

    }

}
