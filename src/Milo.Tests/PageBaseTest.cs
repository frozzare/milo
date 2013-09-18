using System;
using System.Collections.Generic;
using System.Linq;
using Milo.Core;
using Milo.Web.PageExtensions;
using Xunit;
using Milo;

namespace Milo.Tests
{
    /// <summary>
    /// About page
    /// </summary>
    public class AboutPage : ICurrentPage
    {
        public virtual PageData CurrentPage
        {
            get
            {
                var pageData = new PageData
                {
                    PageName = "About us",
                    PageTypeName = "AboutPage", 
                    IsEditMode = false
                };
                pageData.PageLanguages.Add("en");
                return pageData;
            }

            set
            {
                if (value != null)
                {
                    this.CurrentPage = value;
                }
            }
        }
    }

    /// <summary>
    /// Page base tests
    /// </summary>
    public class PageBaseTest : PageBase
    {
        /// <summary>
        /// Empties the page test.
        /// </summary>
        [Fact]
        public void EmptyPageTest()
        {
            Assert.Null(CurrentPage);
        }

        /// <summary>
        /// Abouts the page tes.
        /// </summary>
        [Fact]
        public void AboutPageTest()
        {
            CurrentPageHandler = new AboutPage();
            Assert.NotNull(CurrentPage);
            Assert.Equal(CurrentPage.PageName, "About us");
            Assert.Equal(CurrentPage.PageTypeName, "AboutPage");
            Assert.Equal(CurrentPage.PageLanguages.Count, 1);
            Assert.Equal(CurrentPage.PageLanguages.First(), "en");
        }
    }
}
