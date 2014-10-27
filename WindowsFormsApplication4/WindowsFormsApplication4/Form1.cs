using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         
            InitializeComponent();
            this.Text = "Faculty Login";
           
        }

        

        private void email_Click(object sender, EventArgs e)
        {
            
        }
        //Sets the property of all objects used after form loads

        private void Form1_Load(object sender, EventArgs e)
        {
            email.Font = new Font("Arial", 10.0f);
            password.Font = new Font("Arial", 10.0f);
            dept.Font = new Font("Arial", 13.0f);
            header.Font = new Font("Arial", 15.0f);

            this.MinimumSize = new Size(540, 480);
            this.MaximumSize = new Size(540, 480);
        
         
        }
        //Logo of DTU
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void dept_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Password input box
        private void pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void email1_TextChanged(object sender, EventArgs e)
        {
            
        }

       

        private void login_Click(object sender, EventArgs e)
        {

            string tag = "login";
            string content = "tag=" + tag + "&email=" + email1.Text +"&password=" + pass.Text;

            string URL = "http://localhost/pro/desktop2/index.php";
            string URI = "http://k3k.bugs3.com/desktop2/index.php";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URI);
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
            string responseFromServer = HttpUtility.UrlDecode(reader.ReadToEnd()).Split('<')[0];
            

            if (responseFromServer == "#false")
            {
                MessageBox.Show("Either Email or Password is wrong");
                
            }
            
            
           
            /*
             loading dashboard after successfull login
             */
            else
            {
                string name5 = responseFromServer;

                MessageBox.Show("Login Successfull " + name5);
            Form2 form = new Form2(name5);
            form.StartPosition = FormStartPosition.WindowsDefaultLocation;
            this.Hide();
            form.ShowDialog();
            this.Close();
               }
            reader.Close();
            dataStream.Close();
            response.Close();

        }
    }
}
