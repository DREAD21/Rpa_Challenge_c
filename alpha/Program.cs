using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace alpha
{
    class Program
    {
        IWebDriver browser;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Search();

        }
        public void Search()
        {
            string[] F_name = new []{ "John", "Jane", "Albert", "Michael", "Doug", "Jessie", "Stan", "Michelle", "Stacy", "Lara"};
            string[] L_name = new []{ "Smith", "Dorsey", "Kipling", "Robertson", "Derrick", "Marlowe", "Hamm", "Norton", "Shelby", "Palmer" };
            string[] C_name = new []{ "IT Solutions", "MediCare", "Waterfront", "MediCare", "Timepath Inc.", "Aperture Inc.", "Sugarwell", "Aperture Inc.", "TechDev", "Timepath Inc." };
            string[] Role = new []{ "Analyst", "Medical Engineer", "Accountant", "IT Specialist", "Analyst", "Scientist", "Advisor", "Scientist", "HR Manager", "Programmer" };
            string[] Address = new []{"98 North Road", "11 Crown Street", "22 Guild Street", "17 Farburn Terrace", "99 Shire Oak Road", "27 Cheshire Street", "10 Dam Road", "13 White Rabbit Street", "19 Pineapple Boulevard", "87 Orange Street"};
            string[] Email = new []{ "jsmith@itsolutions.co.uk",  "jdorsey@mc.com", "kipling@waterfront.com", "mrobertson@mc.com", "dderrick@timepath.co.uk", "jmarlowe@aperture.us", "shamm@sugarwell.org", "mnorton@aperture.us", "sshelby@techdev.com", "lpalmer@timepath.co.uk" };
            string[] Phone = new []{ "40716543298", "40791345621", "40735416854", "40733652145", "40799885412", "40733154268", "40712462257", "40731254562", "40741785214", "40731653845"};
            browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://rpachallenge.com/");
            browser.FindElement(By.XPath("/html/body/app-root/div[2]/app-rpa1/div/div[1]/div[6]/button")).Click();
            IWebElement web = browser.FindElement(By.XPath("/html/body/app-root/div[2]/app-rpa1/div/div[2]/form/input"));
            for(int i = 0; i < F_name.Length; i++)
            {
                browser.FindElement(By.XPath(".//input [@ng-reflect-name='labelRole']")).SendKeys(Role[i]);
                browser.FindElement(By.XPath(".//input [@ng-reflect-name='labelAddress']")).SendKeys(Address[i]);
                browser.FindElement(By.XPath(".//input [@ng-reflect-name='labelFirstName']")).SendKeys(F_name[i]);
                browser.FindElement(By.XPath(".//input [@ng-reflect-name='labelLastName']")).SendKeys(L_name[i]);
                browser.FindElement(By.XPath(".//input [@ng-reflect-name='labelCompanyName']")).SendKeys(C_name[i]);
                browser.FindElement(By.XPath(".//input [@ng-reflect-name='labelEmail']")).SendKeys(Email[i]);
                browser.FindElement(By.XPath(".//input [@ng-reflect-name='labelPhone']")).SendKeys(Phone[i]);
                web.Click();
            }
        }
    }
}
