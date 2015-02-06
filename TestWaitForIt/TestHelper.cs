using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WaitForIt.Model;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using System.IO;
using TestStack.White.Factory;
using TestStack.White.UIItems.ListBoxItems;

namespace TestWaitForIt
{
    public class TestHelper
    {
        private static TestContext test_context;
        private static Window window;
        private static Application application;

        public static void Setup(TestContext _context)
        {
            test_context = _context;
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\TestWaitForIt\\bin\\Debug\\WaitForIt");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
        }

        public void AndIShouldSeeAnErrorMessage(string p)
        {
            throw new NotImplementedException();
        }

        public void AndIShouldSeeTheHelperText()
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeXEvents(int expected)
        {
            Assert.IsNotNull(window);
            ListBox countdowns = window.Get<ListBox>("CountdownList");
            Assert.AreEqual(expected, countdowns.Items.Count);
        }

        public void AndIShouldSeeXEvents(int p)
        {
            throw new NotImplementedException();
        }

        public void AndTheButtonShouldBeEnabled(string p)
        {
            throw new NotImplementedException();
        }

        public void AndTheButtonShouldBeDisabled(string p)
        {
            throw new NotImplementedException();
        }

        public void AndIShouldSeeACountdownFor(string p1, string p2)
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldNotSeeTheEventForm()
        {
            throw new NotImplementedException();
        }

        public void AndIClick(string p)
        {
            throw new NotImplementedException();
        }

        public void AndIChooseTheEventDate(string p)
        {
            throw new NotImplementedException();
        }

        public void WhenIFillInEventTitleWith(string p)
        {
            throw new NotImplementedException();
        }

        public void AndTheEventDateShouldBe30DaysFromNow()
        {
            throw new NotImplementedException();
        }

        public void AndIShouldNotSeeTheHelperText()
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeTheEventForm()
        {
            throw new NotImplementedException();
        }

        public void WhenIClick(string p)
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeACountdownFor(string p1, string p2)
        {
            throw new NotImplementedException();
        }

        public void GivenThereAreNoEvents()
        {
            throw new NotImplementedException();
        }

        public void GivenTheseEvents(params Event[] events)
        {
            foreach (Event evnt in events)
            {
                // Add event to Events here.
            }
        }

        public static void CleanThisUp()
        {
            window.Close();
            application.Close();
        }
    }
}
