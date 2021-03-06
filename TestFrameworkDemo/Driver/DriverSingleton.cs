﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TestFrameworkDemo.Helper;

namespace TestFrameworkDemo.Driver
{
    public sealed class DriverSingleton
    {
        private static DriverSingleton instance = null;
        private static readonly object padlock = new object();
        private ChromeDriver driver;

        DriverSingleton()
        {
            //TODO: fix this - method in constructor is bad practise, but need to remove popup on first run
            driver = new ChromeDriver("C:\\Users\\james\\source\\repos\\TestFrameworkDemo\\TestFrameworkDemo\\bin\\Debug\\netcoreapp3.1");
            WebDriverHelper.ClickPopupOnFirstRun(driver);
        }

        public static DriverSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DriverSingleton();
                    }
                    return instance;
                }
            }
        }

        public ChromeDriver GetDriver()
        {
            return driver;

        }
    }
}
