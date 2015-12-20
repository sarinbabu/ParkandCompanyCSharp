﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Park_and_Company.ComponentHelper
{
    public class GridHelper
    {
        public static void VerifyIncentiveGridEntry(string gridXpath, string program, string startDate, string endDate,
            string status)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (GenericHelper.IsElementPresentQuick(By.XPath(gridXpath + "//table//tbody//tr[" + i + "]//td[1]/a")))
                {
                    Assert.AreEqual(
                        GenericHelper.GetText(By.XPath(gridXpath + "//table//tbody//tr[" + i + "]//td[1]/a")), program);
                    Assert.AreEqual(
                        GenericHelper.GetText(By.XPath(gridXpath + "//table//tbody//tr[" + i + "]//td[2]")), startDate);
                    Assert.AreEqual(
                        GenericHelper.GetText(By.XPath(gridXpath + "//table//tbody//tr[" + i + "]//td[3]")), endDate);
                    Assert.AreEqual(
                        GenericHelper.GetText(By.XPath(gridXpath + "//table//tbody//tr[" + i + "]//td[4]/span")), status);
                }
            }
        }

        public static IWebElement GetGridElement(string gridXpath, int row, int column)
        {
            if (
                GenericHelper.IsElementPresentQuick(
                    By.XPath(gridXpath + "//table//tbody//tr[" + row + "]//td[" + column + "]/a")))
            {
                return GenericHelper.GetElement(By.XPath(gridXpath + "//table//tbody//tr[" + row + "]//td[" + column + "]/a"));
            }
            else if (
                GenericHelper.IsElementPresentQuick(
                    By.XPath(gridXpath + "//table//tbody//tr[" + row + "]//td[" + column + "]/span")))
            {
                return GenericHelper.GetElement(By.XPath(gridXpath + "//table//tbody//tr[" + row + "]//td[" + column + "]/span"));
            }
           else if (
               GenericHelper.IsElementPresentQuick(
                   By.XPath(gridXpath + "//table//tbody//tr[" + row + "]//td[" + column + "]/input")))
            {
                return GenericHelper.GetElement(By.XPath(gridXpath + "//table//tbody//tr[" + row + "]//td[" + column + "]/input"));
            }
            else if (
               GenericHelper.IsElementPresentQuick(
                   By.XPath(gridXpath + "//table//tbody//tr[" + row + "]//td[" + column + "]")))
            {
                return GenericHelper.GetElement(By.XPath(gridXpath + "//table//tbody//tr[" + row + "]//td[" + column + "]"));
            }
            else
            {
                return null;
            }
        }

        public static void VerifyInGridEntry(string gridXpath, string value, int row,int column)
        {
            var element = GetGridElement(gridXpath, row, column);
            if (element != null)
            {
                Assert.AreEqual(element.Text,value);
            }
            else
            {
                Assert.Fail("Expected Value Not Found : ",value);
            }
        }

        

        public static void ClickVerifyBtnInGrid(string gridXpath, int row, int column)
        {
            if (
                GenericHelper.IsElementPresentQuick(
                    By.XPath(gridXpath + "//table//tbody//tr[" + row + "]//td[" + column + "]//i[2]")))
            {
                var element =
                    GenericHelper.GetElement(
                        By.XPath(gridXpath + "//table//tbody//tr[" + row + "]//td[" + column + "]//i[2]"));
                element.Click();
                GenericHelper.WaitForLoadingMask();
            }
        }

        public static void ClickDeleteBtnInGrid(string gridXpath, int row, int column)
        {
            var element = GetGridElement(gridXpath, row, column);
            element?.Click();
            GenericHelper.WaitForLoadingMask();               
        }

    }
}
