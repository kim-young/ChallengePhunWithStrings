using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            // 1.  Reverse your name
            string name = "Young Kim";
            // In my case, the result would be:
            // robaT boB

            for (int i = name.Length - 1; i >= 0; i--) 
            {
                resultLabel.Text += name[i].ToString();
            }
            */

            /*
            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke

            string[] values = names.Split(',');
            string result = "";

            for (int i = values.Length - 1; i >= 0; i--) 
            {
                result += values[i].ToString() + ", ";
            }

            resultLabel.Text = result.Remove(result.Length - 2, 1);
            */

            /*
            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            string names = "Luke,Leia,Han,Chewbacca";

            string[] values = names.Split(',');

            for (int i = 0; i < values.Length; i++)
            {
                int name = (14 - values[i].Length) / 2;
                resultLabel.Text += values[i].PadLeft(name + values[i].Length, '*').PadRight(14, '*').ToString() + "<br>";
            }
            */

            /*
            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            int index = puzzle.IndexOf("remove-me");

            resultLabel.Text = puzzle.Remove(index, 9).ToLower().Replace('z', 't').Remove(0, 3).Insert(0, "Now");
            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.
            */
        }
    }
}