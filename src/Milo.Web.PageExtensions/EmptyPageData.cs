 using System;
using Milo.Core;

namespace Milo.Web.PageExtensions
{
    public class EmptyPageData : ICurrentPage
    {
        /// <summary>
        /// Gets or sets the current page.
        /// </summary>
        /// <value>
        /// The current page.
        /// </value>
        public virtual PageData CurrentPage { get; set; }
    }
}
