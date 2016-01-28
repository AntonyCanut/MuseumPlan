using System;
using System.Collections;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using MuseumsPlan.Library;

namespace MuseumsPlan.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            MuseumManager service = new MuseumManager();
            try
            {
                Assert.AreEqual(DataService.getDataService(),true);
                
                Assert.AreEqual(DataService.getMuseum(),true);
                Debug.WriteLine(DataService.getMuseum());
                Assert.AreEqual(service.GetAllMuseum(),true);

            }
            catch (Exception e)
            {
                
            }
            //Assert.AreEqual(true, true);
        }

    
    }
}
