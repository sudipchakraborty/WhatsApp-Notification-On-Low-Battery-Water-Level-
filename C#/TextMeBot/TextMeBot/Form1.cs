using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextMeBot
{
    public partial class Form1 : Form
    {
        TextMeBot msg;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msg=new TextMeBot();
        }

        private   async void btn_send_Click(object sender, EventArgs e)
        {
           await msg.send(txt_API_Key.Text,txt_ph_number.Text,txt_msg.Text);
        }

        private async void txt_msg_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                await msg.send(txt_API_Key.Text, txt_ph_number.Text, txt_msg.Text);
            }
        }
    }
}
