using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestFrameworkDemo.Driver
{
    public sealed class DriverSingleton
    {
        private static DriverSingleton instance = null;
        private static readonly object padlock = new object();
        private ChromeDriver driver;

        DriverSingleton()
        {
            //TODO: fix this
            driver = new ChromeDriver("C:\\Users\\james\\source\\repos\\TestFrameworkDemo\\TestFrameworkDemo\\bin\\Debug\\netcoreapp3.1");
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
