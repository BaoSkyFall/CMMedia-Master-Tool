using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace WinFormsApp
{
    public class AllChrome
    {
        public static bool TapName(ChromeDriver chromeDriver, string name, string sendKeys = null)
        {
            try
            {
                WebDriverWait webDriverWait = new WebDriverWait(chromeDriver, TimeSpan.FromSeconds(10)); //Khai báo biến và gán giá trị chờ tối đa là 10 giây!

                chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); //Gán lại giá trị chờ tải web là 10 giây!

                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Name(name))); //Gán giá trị nam cho biến! và khi thấy nam sẽ chạy tiếp!

                if(!string.IsNullOrEmpty(sendKeys)) //So sánh nếu khác null sẽ vào trong!
                {
                    chromeDriver.FindElement(By.Name(name)).SendKeys(sendKeys);
                }    
                else
                {
                    chromeDriver.FindElement(By.Name(name)).Click();
                }    

                Thread.Sleep(TimeSpan.FromSeconds(1)); //Chờ sau khi click xong!

                return true; //Kich thành công trả kế quả về true!
            }
            catch { }
            return false; //Lỗi trả kết quả về false!
        }
    }
}
