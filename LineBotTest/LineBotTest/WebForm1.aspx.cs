using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LineBotTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("oIJ/aZXJ6PnhhlRy3g9KX8ilNUqe3vmKjUjblgIhVxCG+AVN1eOzOlwbUMGoRAthLMybu3n7WnOO4fWVbi89B+luA+d8qtPK3+1w+Tc6Uf9jLfUyw7q7OfRL0RFjmgEiMI7Psx9xYG1NLSnlM8qeSwdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("Ua23ec9703cac90e2313063512e30c35a","testtest"); 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("oIJ/aZXJ6PnhhlRy3g9KX8ilNUqe3vmKjUjblgIhVxCG+AVN1eOzOlwbUMGoRAthLMybu3n7WnOO4fWVbi89B+luA+d8qtPK3+1w+Tc6Uf9jLfUyw7q7OfRL0RFjmgEiMI7Psx9xYG1NLSnlM8qeSwdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("Ua23ec9703cac90e2313063512e30c35a", 1, 6);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("oIJ/aZXJ6PnhhlRy3g9KX8ilNUqe3vmKjUjblgIhVxCG+AVN1eOzOlwbUMGoRAthLMybu3n7WnOO4fWVbi89B+luA+d8qtPK3+1w+Tc6Uf9jLfUyw7q7OfRL0RFjmgEiMI7Psx9xYG1NLSnlM8qeSwdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("Ua23ec9703cac90e2313063512e30c35a", new Uri("https://raw.githubusercontent.com/paperhuang/BuildSchool-Front-End/master/Pictures/Calendar.png"));
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot("oIJ/aZXJ6PnhhlRy3g9KX8ilNUqe3vmKjUjblgIhVxCG+AVN1eOzOlwbUMGoRAthLMybu3n7WnOO4fWVbi89B+luA+d8qtPK3+1w+Tc6Uf9jLfUyw7q7OfRL0RFjmgEiMI7Psx9xYG1NLSnlM8qeSwdB04t89/1O/w1cDnyilFU=");
            bot.PushMessage("Ua23ec9703cac90e2313063512e30c35a", DateTime.Now.ToString());
        }
    }
}