using Microsoft.VisualStudio.TestTools.UnitTesting;
using EFTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFContext;

namespace EFTests.Tests
{
    [TestClass()]
    public class EFDbContextTests
    {
        [TestMethod()]
        public void EFDbContextTest()
        {
            using (EFDbContext db = new EFDbContext())
            {
                List<User> rlst = db.Users.ToList();
                Assert.IsTrue(rlst.Count > 0);
            }
        }
    }
}