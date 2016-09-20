using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YouTennis.Utilities;

namespace YouTennisModelTest
{
    [TestClass]
    public class GeoLocaliztionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
           var s= GeoLocalizationService.CreateAddress("Via pertini, 3 Gorgonzola");
        }
    }
}
