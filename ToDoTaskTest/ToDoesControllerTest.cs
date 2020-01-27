using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoTask.Controllers;
using ToDoTask.Models;

namespace ToDoTaskTest
{
    [TestClass]
    public class ToDoesControllerTest
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private string sortOrder;
        private string searchString;

        [TestMethod]
        public async void IndexViewResultNotNullAsync()
        {
            ToDoesController controller = new ToDoesController();

            ViewResult result = await controller.Index(sortOrder, searchString) as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}
