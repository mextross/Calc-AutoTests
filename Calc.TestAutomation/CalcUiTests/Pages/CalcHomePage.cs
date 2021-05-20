using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcUiTests.Pages
{
   public class CalcHomePage
    {
        public By leftNumberInput = By.Id("leftNumber");
        public By rightNumberInput = By.Id("rightNumber");
        public By operatorDropdown = By.Id("operator");
        public By resultText = By.ClassName("result");
        public By calcBtn = By.Id("calculate");
    }
}
