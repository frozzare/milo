using System.Linq;
using Milo.Core;
using Milo.Spring.Adapters;
using Xunit;

namespace Milo.Spring.Tests.Adapters
{
    /// <summary>
    /// Fake Page Data class.
    /// </summary>
    public class FakePageData : PageData
    {
        public int Id { get; set; }
    }

    /// <summary>
    /// Raven tests
    /// </summary>
    public class RavenTests
    {
        /// <summary>
        /// Test Raven database connection and disconnection.
        /// </summary>
        [Fact]
        public void RavenDb()
        {
            var db = Raven.Connect();
            Assert.NotNull(db);
            Assert.True(db.Disconnect()); // Will always return true for Raven.
        }

        /// <summary>
        /// Test Raven database insertation.
        /// </summary>
        [Fact]
        public void RavenInsert()
        {
            var db = Raven.Connect();
            
            // Insert the first test page

            var fakePageData = new FakePageData
            {
                PageName = "Raven db test page"
            };

            var fake = db.Insert(fakePageData);
            Assert.NotNull(fake);
            Assert.NotNull(fake.Id);

            // Insert the second test page
            
            var fakePageData2 = new FakePageData
            {
                PageName = "Raven db test page 2"
            };

            var fake2 = db.Insert(fakePageData2);
            Assert.NotNull(fake2);
            Assert.NotNull(fake2.Id);
        }

        /// <summary>
        /// Test Raven where method.
        /// </summary>
        [Fact]
        public void RavenWhere()
        {
            var db = Raven.Connect();
            var result = db.Where<FakePageData>(p => p.PageName.Equals("Raven db test page"));
            Assert.True(result.Any());
        }

    }
}
