using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Eventures.Controllers;
using Eventures.Models;
using Eventures.Services.Eventures.Web.Services.EventuresOrders;
using Eventures.Services.Eventures.Web.Services.EventuresOrders.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.DependencyInjection;
using Xunit;
using Moq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Shouldly;

namespace Eventures.Services.Tests.Eventures.Tests.Controllers
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_ShouldReturnViewResult()
        {
            var orders = 
                new List<Order> {new Order{CreatedOn = DateTime.Now}}
                .AsQueryable();

            var mockedOrdersService = new Mock<IEventuresOrdersService>();
            mockedOrdersService
                .Setup(service => service.AllWithEvents())
                .Returns(orders);

            var services = new ServiceCollection();

            Mapper.Initialize(config => config.AddProfile(typeof(MappingConfiguration)));
            services.AddScoped<IEventuresOrdersService>(service => mockedOrdersService.Object);
            services.AddScoped<IMapper>(service => Mapper.Instance);
            services.AddScoped<HomeController>();

            var provider = services.BuildServiceProvider();
            var controller = provider.GetService<HomeController>();

            var result = controller.Index();
            result.ShouldBeOfType<ViewResult>();
        }

        [Fact]
        public void IndexView_ShouldRenderContainer()
        {
            var driver = new ChromeDriver(".");
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Minimize();
            var container = driver.FindElement(By.Id("mainContainer"));
            container.ShouldNotBeNull();
           
        }
    }
}
