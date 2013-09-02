using System;
using System.Collections.Generic;
using Milo.Core.Interfaces;

namespace Milo.Core
{
    /// <summary>
    /// Represents a Page
    /// </summary>
    [Serializable]
    public class PageData : IPageData
    {
        /// <summary>
        /// The languages for this page.
        /// </summary>
        private List<string> _languages;

        /// <summary>
        /// Gets the parent page.
        /// </summary>
        /// <value>
        /// The parent page.
        /// </value>
        public PageData ParentPage
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// Gets or sets the name of the page.
        /// </summary>
        /// <value>The name of the page.</value>
        public string PageName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets the name of the page type.
        /// </summary>
        /// <value>
        /// The name of the page type.
        /// </value>
        public string PageTypeName
        {
            get; set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the page is in edit mode.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [is edit mode]; otherwise, <c>false</c>.
        /// </value>
        public bool IsEditMode { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Milo.Core.PageData"/> class.
        /// </summary>
        public PageData()
        {
            this._languages = new List<string>();
        }

        /// <summary>
        /// Gets the page languages.
        /// </summary>
        /// <value>The page languages.</value>
        public virtual List<string> PageLanguages
        {
            get
            {
                return this._languages;
            }
        }

        /// <summary>
        /// Gets children pages.
        /// </summary>
        /// <returns>The children pages.</returns>
        public PageDataCollection GetChildren()
        {
            return new PageDataCollection();
        }

        /// <summary>
        /// Gets the property.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public IProperty GetProperty(string key)
        {
            return null;
        }
    }
}

