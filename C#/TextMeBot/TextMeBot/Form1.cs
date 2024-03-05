using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace TextMeBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        static async Task send()
        {
            // Create HttpClient instance
            using (HttpClient httpClient = new HttpClient())
            {
                // Define the URL you want to send the request to
                string requestUrl = "http://api.textmebot.com/send.php?phone=+917003034313&apikey=jXYcsR1XTdW2&text=Test Message_05.03.2024";

                // Send GET request
                HttpResponseMessage response = await httpClient.GetAsync(requestUrl);

                // Check if the response is successful
                if (response.IsSuccessStatusCode)
                {
                    // Read and display the response content
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            send();
        }
    }
}
