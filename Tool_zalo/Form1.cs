using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_zalo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void KetBan_And_Nhantin(IWebDriver browser)
        {
            for(int i = 0; i < dtg_NoiDung.RowCount-1; i++)
            {
                dtg_NoiDung.Rows.Add(i+1);
                try
                {
                    browser.FindElement(By.Id("contact-search-input")).SendKeys(dtg_NoiDung.Rows[i].Cells[1].Value.ToString());
                    Thread.Sleep(4000);
                    if ((bool)dtg_NoiDung.Rows[i].Cells[3].Value == true)
                    {
                        try
                        {
                            browser.FindElement(By.XPath("/html/body/div/div/div[2]/nav/div[2]/div[3]/div/div[2]/div/div/div/div[1]/div/div[1]/div/div[2]")).Click();
                            Thread.Sleep(3000);
                            browser.FindElement(By.XPath("/html/body/div/div/div[2]/main/div/article/div[2]/div[1]/div[1]/div/div")).Click();
                            Thread.Sleep(2000);
                            browser.FindElement(By.XPath("/html/body/div/div/div[3]/div/div/div[2]/div/div/div[5]/div[2]")).Click();
                        }
                        catch
                        {

                        }
                    }
                    if ((bool)dtg_NoiDung.Rows[i].Cells[4].Value == true)
                    {

                        browser.FindElement(By.Id("input_line_0")).SendKeys(dtg_NoiDung.Rows[i].Cells[2].Value.ToString());
                        Thread.Sleep(2000);
                        browser.FindElement(By.XPath("/html/body/div/div/div[2]/main/div/article/div[4]/div[3]/div/div/div/div/div[2]/div[5]/div")).Click();
                    }
                }
                catch
                {

                }
                Thread.Sleep(2000);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo("Profile");
            List<DirectoryInfo> NameOfProfile = dir.GetDirectories().ToList();
            IWebDriver browser;
            ChromeDriverService cService = ChromeDriverService.CreateDefaultService();
            cService.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--user-data-dir=" + NameOfProfile[0].FullName);
            options.AddArguments("--disable-notifications");
            options.AddArguments("--disable-infobars");
            options.AddArguments("--disable-popup-blocking");
            options.AddAdditionalCapability("useAutomationExtension", false);
            options.AddExcludedArgument("enable-automation");
            options.AddArguments("--no-sandbox");
            options.AddArguments("--disable-dev-shm-usage");
            browser = new ChromeDriver(cService, options);
            browser.Navigate().GoToUrl("https://chat.zalo.me/");
            Thread.Sleep(2000);
            KetBan_And_Nhantin(browser);
            

        }

        private void dtg_NoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
