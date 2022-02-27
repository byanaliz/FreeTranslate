using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Translate
{
    class Program
    {
        private static IWebDriver driver;
        static void Main(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
          /*  Proxy proxy = new Proxy();
            proxy.Kind = ProxyKind.Manual;
            proxy.IsAutoDetect = false;
            proxy.SslProxy = "";
            options.Proxy = proxy;*/
            options.AddArgument("ignore-certificate-errors");
            driver = new ChromeDriver(options);
            translate("deneme");
           
        }
        static string translate(string tr)
        {
            System.Threading.Thread.Sleep(1000);
            driver.Navigate().GoToUrl("https://www.bing.com/translator");
            //driver.Navigate().GoToUrl("https://translate.google.com/?sl=tr&tl=en");
            Random rastgele = new Random();
            System.Threading.Thread.Sleep(1000);
            try
            {

                var d = driver.FindElement(By.XPath("//*[@id=\"tta_input_ta\"]"));

                d.SendKeys(tr);
            }
            catch (Exception)
            {
                return "";
            }

            try
            {


                string t = "";
                System.Threading.Thread.Sleep(1000);
                driver.FindElement(By.XPath("//*[@id=\"tta_copyIcon\"]")).Click();


                Console.WriteLine("Hello World!");
                var text = WindowsClipboard.GetText();

                return t;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
