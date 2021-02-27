using System;
using System.Linq;
using System.Drawing;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Console = Colorful.Console;

namespace Abuse
{
    class Program
    {
        static void Main(string[] args)
        {
            string Username;
            string Name;
            var Time = DateTime.Now;
            var User = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').Last();
            Console.Title = "Instagram Report Bot - Welcome " + User + " - Github/AuraAlways";
            Console.WriteWithGradient(@"
                      ██ ███    ██ ███████ ████████  █████   ██████  ██████   █████  ███    ███ 
                      ██ ████   ██ ██         ██    ██   ██ ██       ██   ██ ██   ██ ████  ████ 
                      ██ ██ ██  ██ ███████    ██    ███████ ██   ███ ██████  ███████ ██ ████ ██ 
                      ██ ██  ██ ██      ██    ██    ██   ██ ██    ██ ██   ██ ██   ██ ██  ██  ██ 
                      ██ ██   ████ ███████    ██    ██   ██  ██████  ██   ██ ██   ██ ██      ██ 
            ",
            Color.LightPink, Color.MediumPurple, 8);
            Thread.Sleep(1500); // For Effect - Because Why Not?
            Console.WriteWithGradient($"\n                                        [" + Time + "] - Loading...\n", Color.LightPink, Color.MediumPurple, 1);
            Thread.Sleep(1500); // For Effect - Because Why Not?
            Console.WriteWithGradient($"                                        [" + Time + "] - Initializing...\n", Color.MediumPurple, Color.MediumPurple, 1);
            Thread.Sleep(2500); // For Effect - Because Why Not?
            Console.WriteWithGradient($"                                        [" + Time + "] - Press Any Key To Start...\n", Color.MediumOrchid, Color.MediumPurple, 1);
            Console.ReadKey();
            Console.Clear();
            Console.WriteWithGradient(@"
                      ██ ███    ██ ███████ ████████  █████   ██████  ██████   █████  ███    ███ 
                      ██ ████   ██ ██         ██    ██   ██ ██       ██   ██ ██   ██ ████  ████ 
                      ██ ██ ██  ██ ███████    ██    ███████ ██   ███ ██████  ███████ ██ ████ ██ 
                      ██ ██  ██ ██      ██    ██    ██   ██ ██    ██ ██   ██ ██   ██ ██  ██  ██ 
                      ██ ██   ████ ███████    ██    ██   ██  ██████  ██   ██ ██   ██ ██      ██ 
            ",
            Color.LightPink, Color.MediumPurple, 8);
            Console.WriteWithGradient($"\n                                     [Abuse] - Enter Target's Username >> ", Color.LightPink, Color.MediumPurple, 1);
            Username = Console.ReadLine();
            Console.WriteWithGradient($"                                     [Abuse] - Enter Target's 'Name' >> ", Color.MediumPurple, Color.MediumOrchid, 1);
            Name = Console.ReadLine();
            Console.WriteWithGradient($"                                     [Abuse] - Press Any Key To Initialize...", Color.MediumOrchid, Color.MediumPurple, 1);
            Console.ReadKey();
            Console.Clear();
            Console.WriteWithGradient(@"
                      ██ ███    ██ ███████ ████████  █████   ██████  ██████   █████  ███    ███ 
                      ██ ████   ██ ██         ██    ██   ██ ██       ██   ██ ██   ██ ████  ████ 
                      ██ ██ ██  ██ ███████    ██    ███████ ██   ███ ██████  ███████ ██ ████ ██ 
                      ██ ██  ██ ██      ██    ██    ██   ██ ██    ██ ██   ██ ██   ██ ██  ██  ██ 
                      ██ ██   ████ ███████    ██    ██   ██  ██████  ██   ██ ██   ██ ██      ██ 
            ",
            Color.LightPink, Color.MediumPurple, 8);
            Console.WriteWithGradient($"\n                                     [Abuse] - Target's Username >> " + Username + "\n", Color.LightPink, Color.MediumPurple, 1);
            Console.WriteWithGradient($"                                     [Abuse] - Target's 'Name' >> " + Name + "\n", Color.MediumPurple, Color.MediumOrchid, 1);
            Console.WriteWithGradient($"                                     [Abuse] - Once You Exit The Program All Chrome Instances Will Exit\n", Color.MediumOrchid, Color.MediumOrchid, 1);
            Thread.Sleep(5000);
            Report(Username, Name);
            Console.ReadKey();
        }

        static void Report(string Username, string Name)
        {
            IWebDriver driver;
            ChromeOptions options = new ChromeOptions();
            driver = new ChromeDriver("\\");
            driver.Url = "https://help.instagram.com/contact/723586364339719";
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[3]/div/div[2]/div/form/div[1]/input")).SendKeys(Username);
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[3]/div/div[2]/div/form/div[2]/input")).SendKeys(Name);
            driver.FindElement(By.XPath("/html/body/div/div[2]/div[3]/div/div[2]/div/form/div[3]/div[2]/div/div/div/a")).Click();
            driver.FindElement(By.XPath("//*[@id='js_2']/div/div/ul/li[15]/a/span/span")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[3]/div/div[2]/div/form/div[3]/div[2]/div/div[2]/div/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[4]/div/div/div/div/div[1]/div/div/ul/li[8]/a/span/span")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[3]/div/div[2]/div/form/div[3]/div[2]/div/div[3]/div/a")).Click();
            driver.FindElement(By.XPath("//*[@id='js_c']/div/div/ul/li[30]/a/span/span")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[3]/div/div[2]/div/form/div[4]/select")).Click();
            driver.FindElement(By.XPath("//*[@id='294540267362199']/option[5]")).Click();
            driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[3]/div/div[2]/div/form/button")).Click();
            Report(Username, Name); // Loop the procedure otherwise nothing is going to happen to the account lol
        }
    }
}