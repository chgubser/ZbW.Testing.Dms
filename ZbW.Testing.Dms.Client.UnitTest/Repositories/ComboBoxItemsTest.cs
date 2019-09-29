using NUnit.Framework;
using System.Collections.Generic;
using ZbW.Testing.Dms.Client.Repositories;


namespace ZbW.Testing.Dms.Client.UnitTest.Repositories
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
