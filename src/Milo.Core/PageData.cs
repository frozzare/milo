using System;
using System.Collections.Generic;

namespace Milo.Core
{
    /// <summary>
    /// Represents a Page
    /// </summary>
    [Serializable]
    public class PageData
    {
        /// <summary>
        /// The languages for this page.
        /// </summary>
        private List<string> _languages;

        /// <summary>
        /// Gets or sets the name of the page.
        /// </summary>
        /// <value>The name of the page.</value>
        public string PageName { get; set; }

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
    }
}

