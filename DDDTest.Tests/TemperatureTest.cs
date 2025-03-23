using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DDD.Domain.ValueObjects;

namespace DDDTest.Tests
{
	/// <summary>
	/// TemperatureTest の概要の説明
	/// </summary>
	[TestClass]
	public class TemperatureTest
	{
		#region 追加のテスト属性
			//
			// テストを作成する際には、次の追加属性を使用できます:
			//
			// クラス内で最初のテストを実行する前に、ClassInitialize を使用してコードを実行してください
			// [ClassInitialize()]
			// public static void MyClassInitialize(TestContext testContext) { }
			//
			// クラス内のテストをすべて実行したら、ClassCleanup を使用してコードを実行してください
			// [ClassCleanup()]
			// public static void MyClassCleanup() { }
			//
			// 各テストを実行する前に、TestInitialize を使用してコードを実行してください
			// [TestInitialize()]
			// public void MyTestInitialize() { }
			//
			// 各テストを実行した後に、TestCleanup を使用してコードを実行してください
			// [TestCleanup()]
			// public void MyTestCleanup() { }
			//
			#endregion

		[TestMethod]
		public void 小数点以下２桁でまるめて表示できる()
		{
			var t = new Temperature(12.3f);
			Assert.AreEqual(12.3f, t.Value);
			Assert.AreEqual("12.30", t.DisplayValue);
			Assert.AreEqual("12.30℃", t.DisplayValueWithUnit);
			Assert.AreEqual("12.30 ℃", t.DisplayValueWithUnitSpace);
        }

        [TestMethod]
        public void 温度Equals()
        {
            var t1 = new Temperature(12.3f);
            var t2 = new Temperature(12.3f);

            Assert.AreEqual(t1, t2);
        }


        [TestMethod]
        public void 温度EqualsEquals()
        {
            var t1 = new Temperature(12.3f);
            var t2 = new Temperature(12.3f);

            Assert.AreEqual(true, t1 == t2);
        }

        [TestMethod]
        public void 値型Equals()
        {
            float t1 = 12.3f;
            float t2 = 12.3f;

            Assert.AreEqual(t1, t2);
        }
    }
}
