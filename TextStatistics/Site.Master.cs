using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace TextStatistics
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtTopWords.Text = string.Empty;
        }

        protected void BtnRunStatistics_Click(object sender, EventArgs e)
        {
            TxtTopWords.Text = string.Empty;
            bool status = IsURLExist(txtFileLocation.Text);

            if (status)
            { 
            try
            {
                if (!(txtFileLocation.Text == null) || !(txtFileLocation.Text == string.Empty))
                {

                        string input = new WebClient().DownloadString(txtFileLocation.Text);
                        

                       

                    }
                else
                {
                    
                }
            }
            catch (WebException webex)
            {
                webex.Message.ToString();
            }
            }
            else
            {
                txtFileLocation.Text = "Your Url is not valid";
            }
        }


        public static bool IsURLExist(string url)
        {
            try
            {                
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
               
                request.Method = "HEAD";
                
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                
                response.Close();
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch 
            {
                return false;
            }
        }
    }
}