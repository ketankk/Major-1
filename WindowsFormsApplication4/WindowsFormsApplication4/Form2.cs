using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        string not_title="", not_message="", not_for="";
        //string name5="kte";
        public Form2(string user)
        {
            InitializeComponent();
            
            
            label1.Text = user;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dept.Font = new Font("Arial", 13.0f);
            header.Font = new Font("Arial", 15.0f);

            this.MinimumSize = new Size(540, 480);
            this.MaximumSize = new Size(540, 480);

            title.ForeColor = Color.Gray;
            title.Text = "Title";


            message.ForeColor = Color.Gray;
            message.Text = "Enter your mesage here";
            //message.Select(message.TextLength,0);

            comboBox1.ForeColor = Color.Black;
            comboBox1.Text = "Choose one";
        }

        private void title_OnClick(object sender, EventArgs e)
        {
            title.Text="";
            not_title = title.Text;
        }

        private void message_TextChanged(object sender, EventArgs e)
        {
           
            not_message = message.Text;
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            not_for = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string tag = "login";
            string content="title=" +not_title + "&message=" + not_message + "&year=" + not_for;

            string URL = "http://localhost/pro/note/index.php";
            string URI = "http://k3k.bugs3.com/note/index.php";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "POST";
            byte[] byteArray = Encoding.UTF8.GetBytes(content);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();

            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = HttpUtility.UrlDecode(reader.ReadToEnd());
/*

            if (responseFromServer == "false")
            {
                MessageBox.Show("Either Email or Password is wrong");
                Form1 form = new Form1();
                form.StartPosition = FormStartPosition.WindowsDefaultLocation;
                this.Hide();
                form.ShowDialog();
                this.Close();
            }



          
            else
            {
                name5 = responseFromServer;
                MessageBox.Show("Login Successfull " + name5);
                Form2 form = new Form2();
                form.StartPosition = FormStartPosition.WindowsDefaultLocation;
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            reader.Close();
            dataStream.Close();
            response.Close();
            




            */

            MessageBox.Show("Inserted");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void title_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
