using CMMedia_Master_Tool;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Keys = OpenQA.Selenium.Keys;

namespace CMMediaToolSeeding
{
    public partial class Form1 : Form
    {
        public string accessToken = "EAANU7qeZAzJMBANZCl4Wvh9hfvjZA0RTRo7tqRYiT8M5wMvAAhKXzBGZAP1eZCAzeGiZAJVTiw4bWGAIzxhyHXX0UWyOMy2ZCdFspYNMpemGfHMtf9ke6Vt3ZB7Coy3EH4zNs1OzKwxZCZAgIQiEDYbvosvZAo0ANdODYeegIaZAK4qnlpqqES35FOFFZBYdwCcc43ny16jCH69JfwQZDZD";
        public ChromeDriver chromeDriver;
        List<ProfileList> profileList = new List<ProfileList>();

        public Form1()
        {
            InitializeComponent();
            GoFullscreen(true);
        }
        private void btn_run_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLinkFanpage.Text) || (string.IsNullOrEmpty(txtComment1.Text) && string.IsNullOrEmpty(pictureBox1.ImageLocation)))
            {
                MessageBox.Show("Chưa nhập đủ đòi chạy Tool? Bớt Phá đi Ba", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var chromeManager = new ChromeManager();
                var data = chromeManager.GetCookies("Default");
                string cookie = profileList[comboBoxUserAgent.SelectedIndex].Cookie;
                Start(cookie, 1, 1);
            }
   
            //data.All()
        }
        void Start(string cookie,int intTotalThread, int Threads)
        {
            string userAgent = "";
            //string cookie = "sb=a51SYgEYFIBnr0ne_T1pPzaZ; datr=a51SYjLteMcqG0vPMsLTx3dB; wd=1920x929; c_user=100026782578534; xs=1%3AA3OAoQo29Jg3fA%3A2%3A1649581422%3A-1%3A6288; fr=0wNrC9SLk3EW4uyUW.AWVdFR-IpdUuEH-KgfnDQaIOyZE.BiUp1r.n3.AAA.0.0.BiUp1v.AWUUioFC3Ao; presence=C%7B%22t3%22%3A%5B%5D%2C%22utc3%22%3A1649581431978%2C%22v%22%3A1%7D";

            string[] arrary = "100012381766250|Vietshop@!@|BMKMWH66UIG73K7XKG2BTVJ7BGNCVC2K".Split('|');

            string proxy = string.Empty;

            string User = arrary[0];
            string Pass = arrary[1];
            string CodeQR = arrary[2];
            //IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(); //Khai báo biến!
            chromeDriverService.HideCommandPromptWindow = true; //Ẩn bảng điều khiển chrome!
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
        

            string pathProfile = $"{AppDomain.CurrentDomain.BaseDirectory}ProFile";

            if (!Directory.Exists(pathProfile))//Kiểm tra xem thư mục có tồn tại không!
            {
                Directory.CreateDirectory(pathProfile); //Tạo file!
            }

            //chromeOptions.AddArgument($"user-data-dir={pathProfile}\\{User}");

            //if (!string.IsNullOrEmpty(proxy))
            //{
            //    chromeOptions.AddArgument("--proxy-server=" + proxy);
            //}
            //chromeOptions.AddArgument("--app=https://facebook.com/");
            ChromeOptions chromeOptions = new ChromeOptions(); //Khai báo biến!
            chromeOptions.AddArgument("--window-size=1024,720");
            chromeOptions.AddArgument("--ignore-certificate-errors");
            chromeOptions.AddArgument("--disable-notifications");
            chromeOptions.AddArgument("--disable-web-security");
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("--disable-images");
            chromeOptions.AddArgument("--mute-audio");
            chromeOptions.AddArgument("--lang=vi-VN");
            chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
            chromeOptions.AddUserProfilePreference("media.peerconnection.enabled", false);
            chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
            chromeOptions.AddArgument("--allow-running-insecure-content");
            chromeOptions.AddExcludedArgument("--enable-automation");
            chromeDriver = new ChromeDriver(chromeDriverService, chromeOptions); //Khởi tạo chrome!
            //chromeDriver.Manage().Window.Position = new Point(Screen.PrimaryScreen.Bounds.Width / (intTotalThread / 2) * (Threads % (intTotalThread / 2)), Screen.PrimaryScreen.Bounds.Height / 2 * (Threads / (intTotalThread / 2)));

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

                //chromeDriver.Navigate().GoToUrl("https://m.facebook.com/"); //Đi đến url;

                //resutlSource = chromeDriver.PageSource;

                //if (resutlSource.Contains("m_login_email") && resutlSource.Contains("m_login_password") && resutlSource.Contains("m_login_button"))
                //{
                //    AllChrome.TapName(chromeDriver, "email", User);

                //    AllChrome.TapName(chromeDriver, "pass", Pass);

                //    AllChrome.TapName(chromeDriver, "login");

                //    if (!string.IsNullOrEmpty(CodeQR))
                //    {
                //        string Code = GetFa(CodeQR);

                //        AllChrome.TapName(chromeDriver, "approvals_code", Code);

                //        AllChrome.TapName(chromeDriver, "submit[Submit Code]");

                //        AllChrome.TapName(chromeDriver, "submit[Continue]");

                //        AllChrome.TapName(chromeDriver, "submit[Continue]");
                //    }
                //}
            }
            string resutlUrl = chromeDriver.Url;
            if (resutlUrl.Contains("checkpoint"))
            {

            }


            chromeDriver.Navigate().GoToUrl("https://facebook.com"); //Đi đến url;
            chromeDriver.Navigate().GoToUrl(txtLinkFanpage.Text); //Đi đến url;
            Thread.Sleep(2000); //Chờ sau khi click xong!
            string nameTextControl = "txtComment";
            string namePictureControl = "img";
            for (int i =1;i<= 20;i++)
            {
                Control textControl = this.Controls.Find(nameTextControl + i, true)[0];
                PictureBox pictureControl = (PictureBox)this.Controls.Find(namePictureControl + i, true)[0];
                if(!string.IsNullOrEmpty(textControl.Text) || pictureControl.ImageLocation != null)
                {
                    commentAction(chromeDriver, textControl.Text, pictureControl.ImageLocation);

                }
            }
            ///////////////////////Code tiếp check tài nguyên!



        }
        public void commentAction(ChromeDriver chromeDriver,string comment, string imageLocation)
        {
            var elementWriteComment = chromeDriver.FindElement(By.XPath("//div[@aria-label='Viết bình luận']//p"));
            elementWriteComment.Click();
            var contentSplit = comment.Split("\r\n");
            //comment = comment.Replace("\n", elementWriteComment.SendKeys(Keys.Shift + Keys.Enter);
      
                for (int i = 0; i < contentSplit.Length; i++)
                {
                    Thread.Sleep(1000); //Chờ sau khi click xong!
                    elementWriteComment.SendKeys(contentSplit[i]);
                    elementWriteComment.SendKeys(Keys.Shift + Keys.Enter);

                }

            
     
            Thread.Sleep(1000); //Chờ sau khi click xong!
            if (string.IsNullOrEmpty(imageLocation))
            {
                elementWriteComment.SendKeys(Keys.Space + Keys.Enter);
            }
            else
            {
                var elementUploadImageTrigger = chromeDriver.FindElement(By.XPath("//div[@aria-label='Đính kèm một ảnh hoặc video']//i"));
                var elementUploadImage = chromeDriver.FindElements(By.XPath("//input[@type='file']"));
                int indexBinding = elementUploadImage.Count > 1 ? 1 : 0;
                //elementUploadImageTrigger.Click();
                elementUploadImage[indexBinding].SendKeys(imageLocation);
                WaitUntilElementNotVisible(chromeDriver, By.XPath("//div[@class='mfclru0v fwlpnqze b0eko5f3 cgu29s5g']//div[@class='mfn553m3 th51lws0 h07fizzr cgu29s5g']"), 20);
                //var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                //wait.until(ExpectedConditions.invisibilityOfElementLocated(By.id("processing")));
                elementWriteComment.SendKeys(Keys.Space + Keys.Enter);

            }

        }
        protected void WaitUntilElementNotVisible(ChromeDriver chromeDriver,By searchElementBy, int timeoutInSeconds)
        {
            try
            {
                new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(timeoutInSeconds))
                                .Until(drv => !IsElementVisible(chromeDriver, searchElementBy));
            }
               catch (Exception)
            {
                MessageBox.Show("Facebook lag vl không upload hình được. Vui lòng thử lại!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsElementVisible(ChromeDriver chromeDriver,By searchElementBy)
        {
            try
            {
                if(chromeDriver.FindElement(searchElementBy) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            const int maximumLength = 5000000;
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var size = new FileInfo(dialog.FileName).Length;
                    if(size <= maximumLength)
                    {
                        imageLocation = dialog.FileName;
                        ((PictureBox)sender).ImageLocation = imageLocation;
                    }
                    else
                    {
                        MessageBox.Show("Up hình nặng vậy sao chạy tool nhanh được ba?\n Vui lòng upload hình dưới 5 MB cái", "Up lại hình đi ba", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
            catch(Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GetCookieData();
        }
         public void GetCookieData()
        {
            var chromeManager = new ChromeManager();
         
            comboBoxUserAgent.Items.Clear();
            string ChromeCookiePath = @"C:\Users\" + Environment.UserName + @"\AppData\Local\Google\Chrome\User Data";
            string[] replayslol = System.IO.Directory.GetDirectories(ChromeCookiePath);
            foreach (string file in replayslol)
            {
                var strTemp = Path.GetFileName(file).Split(" ");
                if (strTemp[0].Contains("Profile") || strTemp[0].Contains("Default"))
                {
                    var data = chromeManager.GetCookies(Path.GetFileName(file));
                    string cookie = "";
                    string c_user = "";
                    for (int i = 0; i < data.Count; i++)
                    {
                        if (data[i].Name == "c_user")
                        {
                            c_user = data[i].Value;
                        }
                        string tempStr = $"{data[i].Name}={data[i].Value};";
                        cookie += tempStr;
                    }
                    var profile = new ProfileList();
                    string nameUserAgent = getNameById(file);
                    profile.FileName = nameUserAgent;
                    profile.UID = c_user;
                    profile.FacebookName = "Đang tìm....";
                    profile.Cookie = cookie;
                    profileList.Add(profile);
                    comboBoxUserAgent.Items.Add(profile);
                }

            }
            comboBoxUserAgent.DisplayMember = "FileName";
            comboBoxUserAgent.ValueMember = "cookie";
            comboBoxUserAgent.SelectedIndex = 0;

        }
        public string getNameById(string file)
        {
            string text = System.IO.File.ReadAllText($@"{file}\Preferences");
            string name = Regex.Match(text, "managed_user_id\":\"\",\"name\":\"(.*?)\"").Groups[1].Value;
            return name;
            //var response = Get($"https://graph.facebook.com/v15.0/{uid}/?access_token={accessToken}");
            //WebBrowser webBrowser = new WebBrowser();
            //webBrowser.Navigate($"https://www.fb.com/{uid}");
            //var text = webBrowser.DocumentText;
        }
        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
        public string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            GetCookieData();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            CloseBrowser();
        }
        public void CloseBrowser()
        {
            if(chromeDriver!= null)
            {
                chromeDriver.Close();
                chromeDriver.Dispose();
                chromeDriver.Quit();
            }

        }

        private void comboBoxUserAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUID.Text = profileList[comboBoxUserAgent.SelectedIndex].UID;
        }
    }
}