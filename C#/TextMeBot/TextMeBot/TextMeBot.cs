using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TextMeBot
{
    public class TextMeBot
    {
        public string Url { get; set; }
        public string API_Key { get; set; }
        public string Ph_no { get; set; }
        public String Message {  get; set; }  
        public String Response { get; set; }
        public String ResponseBody {  get; set; }
        public String ResponseStatusCode { get; set; }  

        public TextMeBot()
        {
            Url="http://api.textmebot.com/send.php?phone=";
            API_Key="jXYcsR1XTdW2";
            Ph_no="+917003034313";
            Message="Test Message";
            Response="";
        }

       public async Task send()
        {       
            using (HttpClient httpClient = new HttpClient())    // Create HttpClient instance
            {
                // Define the URL you want to send the request to
                //string requestUrl = "http://api.textmebot.com/send.php?phone=+917003034313&apikey=jXYcsR1XTdW2&text=Test Message_05.03.2024";

                string requestUrl = Url+Ph_no+"&apikey="+API_Key+"&text="+Message;  // Send GET request          
                HttpResponseMessage response = await httpClient.GetAsync(requestUrl);
                Response=response.ToString();

                if (response.IsSuccessStatusCode)  // Check if the response is successful
                {                 
                    string responseBody = await response.Content.ReadAsStringAsync();// Read and display the response content
                    ResponseBody= responseBody;
                }
                else
                {
                    ResponseStatusCode= "Error: {response.StatusCode}";
                }
            }
        }

        public async Task send(string key, string ph, string msg)
        {
            using (HttpClient httpClient = new HttpClient())    // Create HttpClient instance
            {                
                string requestUrl = Url+ph+"&apikey="+key+"&text="+msg;  // Send GET request          
                HttpResponseMessage response = await httpClient.GetAsync(requestUrl);
                Response=response.ToString();

                if (response.IsSuccessStatusCode)  // Check if the response is successful
                {
                    string responseBody = await response.Content.ReadAsStringAsync();// Read and display the response content
                    ResponseBody= responseBody;
                }
                else
                {
                    ResponseStatusCode= "Error: {response.StatusCode}";
                }
            }
        }


    }
}
