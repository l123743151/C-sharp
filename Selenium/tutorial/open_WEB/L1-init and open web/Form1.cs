using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L1_init_and_open_web
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private IWebDriver driver;
        private IWebDriver private_driver;

        private void button1_Click(object sender, EventArgs e)
        {
            open_web("https://www.facebook.com/DoctorKoWJ/","public");
        }

        public void open_web(string url, string mode)
        {
            if (mode == "private")
            {
                try
                {
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("–incognito");//启动无痕/隐私模式
                    private_driver = new ChromeDriver(options);
                    private_driver.Navigate().GoToUrl(url);
                    Thread.Sleep(100);
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    driver = new ChromeDriver();
                    driver.Navigate().GoToUrl(url);
                    Thread.Sleep(100);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            open_web("https://www.facebook.com/DoctorKoWJ/", "private");
        }
    }
}
