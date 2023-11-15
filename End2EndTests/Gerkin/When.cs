﻿using End2EndTests.Solid;

namespace Tests.Playwright.Gerkin
{

    internal class When
    {
        internal GloboticketDriver driver;

        internal When(GloboticketDriver driver)
        {
            this.driver = driver;
        }

        internal When IAddTheProductToTheShoppingCart(string productName)
        {
             var homePage = new HomePage(driver.CurrentDriver);
            homePage.PutProductWithNameInBasket(productName);
               
            return this;
        }

        internal When And() { return this; }
    }
}
