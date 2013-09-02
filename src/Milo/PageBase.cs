using System;
using System.ComponentModel;
using System.Web.UI;
using System.Collections.Generic;
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
                return this._currentPageHandler ?? (this._currentPageHandler = (ICurrentPage) new EmptyPageData());
            }
            set
            {
                this._currentPageHandler = value;
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
                return this.CurrentPageHandler.CurrentPage;
            }
            set
            {
                this.CurrentPageHandler.CurrentPage = value;
            }
        }
    }
}

