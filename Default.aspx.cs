using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) //holds the data in the form before hitting submit. Selecting 15% and then submitting doesnt clear the radio button selection
        {
            string[] tipPercent = { "10%", "15%", "20%", "Other" };
            TipPercentRadios.DataSource = tipPercent;
            TipPercentRadios.DataBind();
        }
    }

    protected void SubmitButton_Click(object sender, EventArgs e)
    {
        GetInfo();
    }

    protected void GetInfo()
    {
        Tip tip = new Tip();
        tip.MealAmount = double.Parse(MealTextBox.Text);  //parse looks at text from textbox and thinks "can i convert this to double?")
        if (OtherTextbox.Text == "")
        {
            tip.TipPercent = 0;
            foreach (ListItem item in TipPercentRadios.Items)//looping through all radio list buttons, rmemeber that ALL TEXT MUST MATCH
            {

                if (item.Selected)
                {

                    if (item.Text.Equals("10%"))
                    {
                        tip.TipPercent = .1;
                    }
                    else if (item.Text.Equals("15%"))
                    {
                        tip.TipPercent = .15;
                    }
                    else if (item.Text.Equals("20%"))
                    {
                        tip.TipPercent = .20;
                    }


                }//end if selector
            }//end for each tip
        }//end outer if
        else
        {
            tip.TipPercent = double.Parse(OtherTextbox.Text);
        }
        Results.Text = "Amount:" + tip.MealAmount.ToString("$#,# #0.00") + "<br/>" +
             "Tax" + tip.CalculateTax().ToString(" $#,# #0.00") + "<br/>" +
             "Tip" + tip.CalculateTip().ToString(" $#,# #0.00") + "<br/>" +
             "Total" + tip.CalculateTotal().ToString(" $#,# #0.00");
    }//end of getinfo Tip
}

