using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using JobSearch;
using System.IO;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace JobSearch.Models
{
    public class JobSearchClass
    {
        // Initialize the Chrome Driver
        public static void RunSearch()
        {

            ChromeDriver driver = new ChromeDriver("/Users/Guest/Desktop/JobSearch.Solution/JobSearch/wwwroot/drivers");
            
            // Go to the home page
            driver.Navigate().GoToUrl("http://www.indeed.com");

            // Get the page elements
            var searchForm = driver.FindElementByName("q");
            var locationForm = driver.FindElementByName("l");
            

            // Type user name and password
            searchForm.SendKeys("Web Developer");
            locationForm.SendKeys("");
            for(int i =0; i <20; i++)
            {
               locationForm.SendKeys(Keys.Backspace);
            }
            locationForm.SendKeys("Portland, OR");

            // and click the login button
            searchForm.Submit();

            // // Extract the text and save it into result.txt
            // var result = driver.FindElementByXPath("//div[@id='case_login']/h3").Text;
            // File.WriteAllText("result.txt", result);
        }
    }
}
