using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = 97, a = 1, ans = 0;
            for (a = 1; a <= x; a++) {
                if ((x % a) == 0) {
                    ans++;
                }
            }
            if (ans == 2) {
                Console.Write(x + "是質數");
            }
            else
            {
                Console.Write(x + "不是質數");
            }
        }
    }
}