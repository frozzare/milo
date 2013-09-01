using Milo.Core;

namespace Milo.Web.PageExtensions
{
    public interface ICurrentPage
    {
        /// <summary>
        /// Gets or sets the current page.
        /// </summary>
        /// <value>
        /// The current page.
        /// </value>
        PageData CurrentPage { get; set; }
    }
}

