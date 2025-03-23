using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DDD.ViewModels;
using System.Data;
using DDD.Domain.Repositories;
using DDD.Domain.Entities;

namespace DDDTest.Tests
{
	/// <summary>
	/// UnitTest2 の概要の説明
	/// </summary>
	[TestClass]
	public class WeathreLatestViewModelTest
	{

		[TestMethod]
		public void シナリオ()
		{
			var viewModel = new WeatherLatestViewModel( new WeatherMock());

			Assert.AreEqual("", viewModel.AreaIdText);
			Assert.AreEqual("", viewModel.DataDateText);
			Assert.AreEqual("", viewModel.ConditionText);
			Assert.AreEqual("", viewModel.TemperatureText);

			viewModel.AreaIdText = "1";
			viewModel.Search();

            Assert.AreEqual("1", viewModel.AreaIdText);
            Assert.AreEqual("2018/01/01 12:34:56", viewModel.DataDateText);
            Assert.AreEqual("2", viewModel.ConditionText);
            Assert.AreEqual("12.30 ℃", viewModel.TemperatureText);

        }
	}

    internal class WeatherMock : IWeatherRepository
    {
        public WeatherEntity GetLatest(int areaId)
        {
			var dt = new WeatherEntity(
				1,
				Convert.ToDateTime("2018/01/01 12:34:56"),
				2,
				12.3f);

			return dt;

        }
    }

}
