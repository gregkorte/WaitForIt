using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WaitForIt.Model;

namespace TestWaitForIt
{
    [TestClass]
    public class ViewingCountdownsTest : TestHelper
    {
        // As a user
        // In order to have hope in my life
        // I want to see the countdowns to the events that I'm looking forward to

        [TestMethod]
        public void ScenarioViewingCountdownsWhenThereAreEvents()
        {
            GivenTheseEvents(
                new Event("Valentine's Day", "02/14/15"),
                new Event("Christmas", "12/25/14")
                );
            AndIShouldSeeXEvents(2);
            AndIShouldSeeACountdownFor("Valentine's Day", "02/14/15");
            AndIShouldSeeACountdownFor("Christmas", "12/25/14");
            AndIShouldNotSeeTheHelperText();
            AndTheButtonShouldBeEnabled("+");
        }
    }
}
