using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OtpNet;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace CMMedia_Master_Tool
{
    public partial class CheckVia : UserControl
    {
        public CheckVia()
        {
            InitializeComponent();
            AllChrome.closeAllChrome();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            AllChrome.closeAllChrome();
            this.checkVia(this.txtTextVia.text);

        }

        void Start(int intTotalThread, int Threads)
        {
            string userAgent = "";
            string cookie = "sb=a51SYgEYFIBnr0ne_T1pPzaZ; datr=a51SYjLteMcqG0vPMsLTx3dB; wd=1920x929; c_user=100026782578534; xs=1%3AA3OAoQo29Jg3fA%3A2%3A1649581422%3A-1%3A6288; fr=0wNrC9SLk3EW4uyUW.AWVdFR-IpdUuEH-KgfnDQaIOyZE.BiUp1r.n3.AAA.0.0.BiUp1v.AWUUioFC3Ao; presence=C%7B%22t3%22%3A%5B%5D%2C%22utc3%22%3A1649581431978%2C%22v%22%3A1%7D";

            string[] arrary = "100012381766250|Vietshop@!@|BMKMWH66UIG73K7XKG2BTVJ7BGNCVC2K".Split('|');

            string proxy = string.Empty;

            string User = arrary[0];
            string Pass = arrary[1];
            string CodeQR = arrary[2];

            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(); //Khai báo biến!
            chromeDriverService.HideCommandPromptWindow = true; //Ẩn bảng điều khiển chrome!
            ChromeOptions chromeOptions = new ChromeOptions(); //Khai báo biến!
            chromeOptions.AddArgument("--window-size=300," + Screen.PrimaryScreen.Bounds.Height / 2);
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
            chromeOptions.AddUserProfilePreference("media.peerconnection.enabled", false);
            chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
            chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
            if (!string.IsNullOrEmpty(userAgent))
            {
                chromeOptions.AddArgument($"--user-agent={userAgent}");
            }
            chromeOptions.AddArgument("--allow-running-insecure-content");
            chromeOptions.AddExcludedArgument("--enable-automation");
            chromeOptions.AddArgument("--ignore-certificate-errors");
            chromeOptions.AddArgument("--disable-notifications");
            chromeOptions.AddArgument("--disable-web-security");
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("--disable-images");
            chromeOptions.AddArgument("--mute-audio");
            chromeOptions.AddArgument("--lang=vi-VN");

            string pathProfile = $"{AppDomain.CurrentDomain.BaseDirectory}ProFile";

            if (!Directory.Exists(pathProfile))//Kiểm tra xem thư mục có tồn tại không!
            {
                Directory.CreateDirectory(pathProfile); //Tạo file!
            }

            chromeOptions.AddArgument($"user-data-dir={pathProfile}\\{User}");

            if (!string.IsNullOrEmpty(proxy))
            {
                chromeOptions.AddArgument("--proxy-server=" + proxy);
            }
            chromeOptions.AddArgument("--app=https://m.facebook.com/");
            ChromeDriver chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromSeconds(10)); //Khởi tạo chrome!
            chromeDriver.Manage().Window.Position = new Point(Screen.PrimaryScreen.Bounds.Width / (intTotalThread / 2) * (Threads % (intTotalThread / 2)), Screen.PrimaryScreen.Bounds.Height / 2 * (Threads / (intTotalThread / 2)));

            chromeDriver.Navigate().GoToUrl("https://m.facebook.com/"); //Đi đến url;

            string resutlSource = chromeDriver.PageSource;

            if (resutlSource.Contains("m_login_email") && resutlSource.Contains("m_login_password") && resutlSource.Contains("m_login_button"))
            {
                if (!string.IsNullOrEmpty(cookie))
                {
                    string[] ListCookie = cookie.Split(';');
                    foreach (var CookieSplit in ListCookie)
                    {
                        string[] CookieSplit2 = CookieSplit.Split('=');
                        if (CookieSplit2.Count() > 1)
                        {
                            chromeDriver.Manage().Cookies.AddCookie(new OpenQA.Selenium.Cookie(CookieSplit2[0].Trim(), CookieSplit2[1].Trim(), ".facebook.com", "/", new DateTime?(DateTime.Now.AddDays(10.0))));
                        }
                    }
                }

                chromeDriver.Navigate().GoToUrl("https://m.facebook.com/"); //Đi đến url;

                resutlSource = chromeDriver.PageSource;

                if (resutlSource.Contains("m_login_email") && resutlSource.Contains("m_login_password") && resutlSource.Contains("m_login_button"))
                {
                    AllChrome.TapName(chromeDriver, "email", User);

                    AllChrome.TapName(chromeDriver, "pass", Pass);

                    AllChrome.TapName(chromeDriver, "login");

                    if (!string.IsNullOrEmpty(CodeQR))
                    {
                        string Code = GetFa(CodeQR);

                        AllChrome.TapName(chromeDriver, "approvals_code", Code);

                        AllChrome.TapName(chromeDriver, "submit[Submit Code]");

                        AllChrome.TapName(chromeDriver, "submit[Continue]");

                        AllChrome.TapName(chromeDriver, "submit[Continue]");
                    }
                }
            }
            string resutlUrl = chromeDriver.Url;
            if (resutlUrl.Contains("checkpoint"))
            {

            }


            chromeDriver.Navigate().GoToUrl("https://m.facebook.com/profile/edit/infotab/section/forms/?section=basic-info"); //Đi đến url;

            string resutl = chromeDriver.PageSource; //Lấy dữ liệu web


            string ngaysinh = Regex.Match(resutl, "current_birthday:\"(.*?)\"").Groups[1].Value;

            string tenclone = Regex.Match(resutl, "\"NAME\":\"(.*?)\"").Groups[1].Value;

            tenclone = Regex.Unescape(tenclone);


            string gioitinh = string.Empty;
            string gender = Regex.Match(resutl, "type=\"radio\" checked=\"1\" value=\"(.*?)\" name=\"gender\"").Groups[1].Value;
            if (gender == "1")
            {
                gioitinh = "Nữ";
            }
            else if (gender == "2")
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Bê đê";
            }

        ///////////////////////Code tiếp check tài nguyên!
        chromeDriver.Navigate().GoToUrl("https://secure.facebook.com/settings?tab=ads_payments&amp;ref=settings_nav"); //Đi đến url;

        

        }
        void checkVia(string data)
        {
            string userAgent = "";
            //string cookie = "sb=a51SYgEYFIBnr0ne_T1pPzaZ; datr=a51SYjLteMcqG0vPMsLTx3dB; wd=1920x929; c_user=100026782578534; xs=1%3AA3OAoQo29Jg3fA%3A2%3A1649581422%3A-1%3A6288; fr=0wNrC9SLk3EW4uyUW.AWVdFR-IpdUuEH-KgfnDQaIOyZE.BiUp1r.n3.AAA.0.0.BiUp1v.AWUUioFC3Ao; presence=C%7B%22t3%22%3A%5B%5D%2C%22utc3%22%3A1649581431978%2C%22v%22%3A1%7D";
            string cookie = String.Empty;
            string[] arrary = data.Split('|');

            string proxy = string.Empty;

            string User = arrary[0];
            string Pass = arrary[1];
            string CodeQR = arrary[2];
            if(!string.IsNullOrEmpty(User) && !string.IsNullOrEmpty(User) && !string.IsNullOrEmpty(CodeQR))
            {

            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(); //Khai báo biến!
            chromeDriverService.HideCommandPromptWindow = true; //Ẩn bảng điều khiển chrome!
            ChromeOptions chromeOptions = new ChromeOptions(); //Khai báo biến!
                chromeOptions.AddArgument("--window-size=300," + Screen.PrimaryScreen.Bounds.Height / 2);
                chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
                chromeOptions.AddUserProfilePreference("media.peerconnection.enabled", false);
                chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
                chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
                if (!string.IsNullOrEmpty(userAgent))
                {
                    chromeOptions.AddArgument($"--user-agent={userAgent}");
                }
                chromeOptions.AddArgument("--allow-running-insecure-content");
                chromeOptions.AddExcludedArgument("--enable-automation");
                chromeOptions.AddArgument("--ignore-certificate-errors");
                chromeOptions.AddArgument("--disable-notifications");
                chromeOptions.AddArgument("--disable-web-security");
                chromeOptions.AddArgument("--disable-extensions");
                chromeOptions.AddArgument("--disable-images");
                chromeOptions.AddArgument("--mute-audio");
                chromeOptions.AddArgument("--lang=vi-VN");

                string pathProfile = $"{AppDomain.CurrentDomain.BaseDirectory}ProFile";

                if (!Directory.Exists(pathProfile))//Kiểm tra xem thư mục có tồn tại không!
                {
                    Directory.CreateDirectory(pathProfile); //Tạo file!
                }

                chromeOptions.AddArgument($"user-data-dir={pathProfile}\\{User}");

                if (!string.IsNullOrEmpty(proxy))
            {
                chromeOptions.AddArgument("--proxy-server=" + proxy);
            }
            //chromeOptions.AddArgument("--app=https://m.facebook.com/");
            ChromeDriver chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromSeconds(10)); //Khởi tạo chrome!
            //chromeDriver.Manage().Window.Position = new Point(Screen.PrimaryScreen.Bounds.Width / (intTotalThread / 2) * (Threads % (intTotalThread / 2)), Screen.PrimaryScreen.Bounds.Height / 2 * (Threads / (intTotalThread / 2)));
            int intTotalThread = 1;
            int Threads = 0;    
            //chromeDriver.Manage().Window.Position = new Point(Screen.PrimaryScreen.Bounds.Width / (1 / 2) * (0 % (intTotalThread / 2)), Screen.PrimaryScreen.Bounds.Height / 2 * (Threads / (intTotalThread / 2)));

            chromeDriver.Navigate().GoToUrl("https://m.facebook.com/"); //Đi đến url;

            string resutlSource = chromeDriver.PageSource;

            if (resutlSource.Contains("m_login_email") && resutlSource.Contains("m_login_password") && resutlSource.Contains("m_login_button"))
            {
                if (!string.IsNullOrEmpty(cookie))
                {
                    string[] ListCookie = cookie.Split(';');
                    foreach (var CookieSplit in ListCookie)
                    {
                        string[] CookieSplit2 = CookieSplit.Split('=');
                        if (CookieSplit2.Count() > 1)
                        {
                            chromeDriver.Manage().Cookies.AddCookie(new OpenQA.Selenium.Cookie(CookieSplit2[0].Trim(), CookieSplit2[1].Trim(), ".facebook.com", "/", new DateTime?(DateTime.Now.AddDays(10.0))));
                        }
                    }
                }

                chromeDriver.Navigate().GoToUrl("https://m.facebook.com/"); //Đi đến url;

                resutlSource = chromeDriver.PageSource;

                if (resutlSource.Contains("m_login_email") && resutlSource.Contains("m_login_password") && resutlSource.Contains("m_login_button"))
                {
                    AllChrome.TapName(chromeDriver, "email", User);

                    AllChrome.TapName(chromeDriver, "pass", Pass);

                    AllChrome.TapName(chromeDriver, "login");

                    if (!string.IsNullOrEmpty(CodeQR))
                    {
                        string Code = GetFa(CodeQR);

                        AllChrome.TapName(chromeDriver, "approvals_code", Code);

                        AllChrome.TapName(chromeDriver, "submit[Submit Code]");

                        AllChrome.TapName(chromeDriver, "submit[Continue]");

                        AllChrome.TapName(chromeDriver, "submit[Continue]");
                    }
                }
            }
            string resutlUrl = chromeDriver.Url;
            if (resutlUrl.Contains("checkpoint"))
            {

            }


            chromeDriver.Navigate().GoToUrl("https://m.facebook.com/profile/edit/infotab/section/forms/?section=basic-info"); //Đi đến url;

            string resutl = chromeDriver.PageSource; //Lấy dữ liệu web


            string ngaysinh = Regex.Match(resutl, "current_birthday:\"(.*?)\"").Groups[1].Value;
            this.lblBirthDayBind.Text = ngaysinh;

            string tenclone = Regex.Match(resutl, "\"NAME\":\"(.*?)\"").Groups[1].Value;

            tenclone = Regex.Unescape(tenclone);
            this.lblNameBind.Text = tenclone;

            string gioitinh = string.Empty;
            string gender = Regex.Match(resutl, "type=\"radio\" checked=\"1\" value=\"(.*?)\" name=\"gender\"").Groups[1].Value;
            if (gender == "1")
            {
                gioitinh = "Nữ";
            }
            else if (gender == "2")
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Bê đê";
            }
            this.lblGenderBind.Text = gioitinh;

                ///////////////////////Code tiếp check tài nguyên!
             chromeDriver.Navigate().GoToUrl("https://secure.facebook.com/settings?tab=ads_payments&amp;ref=settings_nav"); //Đi đến url;

            }
            else
            {
                MessageBox.Show("Không tìm thấy đầy đủ thông tin để kiểm tra");
            }

        }

        private string GetFa(string CodeQR)
        {
            return new Totp(Base32Encoding.ToBytes(CodeQR)).ComputeTotp();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
