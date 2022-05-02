using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DemoQASite;

namespace FormsTesting
{
    internal class Program : Selenium_Base
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = null;
            Forms forms = new Forms();
            forms.Form(Driver);

        }
    }
}
