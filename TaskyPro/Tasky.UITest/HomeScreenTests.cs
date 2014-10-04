﻿using System.IO;
using System.Linq;

using NUnit.Framework;

namespace Tasky.UITest
{
    [TestFixture]
    public class HomeScreenTests : TaskyProTest
    {
        [Test]
        public void HomeScreen_ShouldDisplay_AddTaskButton()
        {
            HomeScreen page = new HomeScreen();
            Assert.IsTrue(page.IsDisplayed(App), "Not on the home page");
            Assert.IsTrue(App.Query(page.AddTaskButton).Any(), "The Add Task button isn't displayed");
            FileInfo fi = App.Screenshot("Confirm HomeScreen");
        }

        [Test]
        public void HomeScreen_TapAddTaskButton_ShouldDisplayTaskDetailsScreen()
        {
            HomeScreen home = new HomeScreen();
            TaskDetailsScreen details = home.NavigateTo<TaskDetailsScreen>(home.ToTaskDetails(App));
            Assert.That(details.IsDisplayed(App), Is.True, "The Task Details Page didn't appear");
        }
    }
}
