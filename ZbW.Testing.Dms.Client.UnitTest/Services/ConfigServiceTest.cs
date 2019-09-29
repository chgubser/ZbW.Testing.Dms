using NUnit.Framework;
using System;
using System.Collections.Generic;
using ZbW.Testing.Dms.Client.Repositories;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbW.Testing.Dms.Client.UnitTest.Services
{
    [TestFixture]
    public class ComboBoxItemsTest
    {

        [Test]
        public void TestComboBoxItems()
        {
            List<string> typList = ComboBoxItems.Typ;
            Assert.IsNotNull(typList);
            Assert.AreEqual("Verträge", typList[0]);
            Assert.AreEqual("Quittungen", typList[1]);
        }

    }
}
