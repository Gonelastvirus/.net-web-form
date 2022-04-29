using System;
using System.Web;
using System.Web.UI;

namespace xyz
{

    public partial class Default : System.Web.UI.Page
    {
        public void button1Clicked(object sender, EventArgs args)
        {
            try
            {
                int x, y, z;
                x = Convert.ToInt32(txtv1.Text);
                y = Convert.ToInt32(txtv2.Text);
                z = x + y;
                txtv3.Text = z.ToString();
            }
            catch(Exception exp)
            {
                exp.ToString();
                err.Text = "Something Went wrong";
            }

        }
    }
}
