using System.ComponentModel;
using System.Web.UI;
using Milo.Core;
using Milo.Core.Interfaces;
using Milo.Web.PageExtensions;

namespace Milo
{
    public abstract class PageBase : Page, IPage, ICurrentPage
    {
        /// <summary>
        /// The CurrentPage handler
        /// </summary>
        private ICurrentPage _currentPageHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="PageBase"/> class.
        /// </summary>
        protected PageBase()
        {
        }

        /// <summary>
        /// Gets or sets the current page handler.
        /// </summary>
        /// <value>
        /// The current page handler.
        /// </value>
        public ICurrentPage CurrentPageHandler
        {
            get
            {
                return _currentPageHandler ?? (_currentPageHandler = new EmptyPageData());
            }
            set
            {
                _currentPageHandler = value;
            }
        }

        /// <summary>
        /// Gets the children.
        /// </summary>
        /// <returns>Children list</returns>
        public PageDataCollection GetChildren()
        {
            return new PageDataCollection();
        }

        /// <summary>
        /// Gets or sets the current page.
        /// </summary>
        /// <value>
        /// The current page.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public virtual PageData CurrentPage
        {
            get
            {
                return CurrentPageHandler.CurrentPage;
            }
            set
            {
                CurrentPageHandler.CurrentPage = value;
            }
        }
    }
}

