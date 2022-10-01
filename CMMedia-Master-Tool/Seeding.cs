using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMMedia_Master_Tool
{
    public partial class Seeding : UserControl
    {
        public Seeding()
        {
            InitializeComponent();
            //AllChrome.closeAllChrome();
            

        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            // string hostName = ".facebook.com";
            // ChromeCookieReader chrome = new ChromeCookieReader();
            //var data = chrome.ReadCookies(hostName);
            string hostName = ".facebook.com";
            var chromeManager = new ChromeManager();
            var data = chromeManager.GetCookies(hostName);

            //string userAgent = "";
            //string cookie = "sb=a51SYgEYFIBnr0ne_T1pPzaZ;
            //datr=a51SYjLteMcqG0vPMsLTx3dB; wd=1920x929;
            //c_user=100026782578534;
            //xs=1%3AA3OAoQo29Jg3fA%3A2%3A1649581422%3A-1%3A6288;
            //fr=0wNrC9SLk3EW4uyUW.AWVdFR-IpdUuEH-KgfnDQaIOyZE.BiUp1r.n3.AAA.0.0.BiUp1v.AWUUioFC3Ao;
            //presence=C%7B%22t3%22%3A%5B%5D%2C%22utc3%22%3A1649581431978%2C%22v%22%3A1%7D";

            //string[] arrary = "100012381766250|Vietshop@!@|BMKMWH66UIG73K7XKG2BTVJ7BGNCVC2K".Split('|');

            //string proxy = string.Empty;

            //string User = arrary[0];
            //string Pass = arrary[1];
            //string CodeQR = arrary[2];

            //ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(); //Khai báo biến!
            //chromeDriverService.HideCommandPromptWindow = true; //Ẩn bảng điều khiển chrome!
            //ChromeOptions chromeOptions = new ChromeOptions(); //Khai báo biến!
            //chromeOptions.AddArgument("--window-size=300," + Screen.PrimaryScreen.Bounds.Height / 2);
            //chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
            //chromeOptions.AddUserProfilePreference("media.peerconnection.enabled", false);
            //chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
            //chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
            //if (!string.IsNullOrEmpty(userAgent))
            //{
            //    chromeOptions.AddArgument($"--user-agent={userAgent}");
            //}
            //chromeOptions.AddArgument("--allow-running-insecure-content");
            //chromeOptions.AddExcludedArgument("--enable-automation");
            //chromeOptions.AddArgument("--ignore-certificate-errors");
            //chromeOptions.AddArgument("--disable-notifications");
            //chromeOptions.AddArgument("--disable-web-security");
            //chromeOptions.AddArgument("--disable-extensions");
            //chromeOptions.AddArgument("--disable-images");
            //chromeOptions.AddArgument("--mute-audio");
            //chromeOptions.AddArgument("--lang=vi-VN");

            //string pathProfile = $"{AppDomain.CurrentDomain.BaseDirectory}ProFile";

            //if (!Directory.Exists(pathProfile))//Kiểm tra xem thư mục có tồn tại không!
            //{
            //    Directory.CreateDirectory(pathProfile); //Tạo file!
            //}

            //chromeOptions.AddArgument($"user-data-dir={pathProfile}\\{User}");

            //if (!string.IsNullOrEmpty(proxy))
            //{
            //    chromeOptions.AddArgument("--proxy-server=" + proxy);
            //}
            //chromeOptions.AddArgument("--app=https://m.facebook.com/");
            //ChromeDriver chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromSeconds(10)); //Khởi tạo chrome!
            //chromeDriver.Navigate().GoToUrl("https://m.facebook.com/"); //Đi đến url;
        }
    }
}
