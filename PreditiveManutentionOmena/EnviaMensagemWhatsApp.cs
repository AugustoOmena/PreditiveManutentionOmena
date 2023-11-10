using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EasyAutomationFramework;

namespace PreditiveManutentionOmena
{
    internal class EnviaMensagemWhatsApp : Web
    {
        public void SendMessage(string message, List<string> to)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\guguo\\AppData\\Local\\Google\\Chrome\\User Data");
            Navigate("https://web.whatsapp.com/");
            WaitForLoad();
            Thread.Sleep(TimeSpan.FromSeconds(7));
            foreach (var nome in to)
            {
                var elemenSearch = AssignValue(TypeElement.Xpath, "//*[@id='side']/div[1]/div/div/div[2]/div/div[1]/p", nome);
                elemenSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);
                var elementMessage = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", message);
                elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);
                Thread.Sleep(TimeSpan.FromSeconds(3));
            }
            CloseBrowser();
        }
        public void SendMessage(string message, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\guguo\\AppData\\Local\\Google\\Chrome\\User Data");
            Navigate("https://web.whatsapp.com/");
            WaitForLoad();
            Thread.Sleep(TimeSpan.FromSeconds(12));
                var elemenSearch = AssignValue(TypeElement.Xpath, "//*[@id='side']/div[1]/div/div/div[2]/div/div[1]/p", to);
                elemenSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);
                var elementMessage = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", message);
                elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            CloseBrowser();
        }
    }
}
