using System;
using System.Collections;
using System.Collections.Generic;

namespace Milo.Core
{
    /// <summary>
    /// Page data collection.
    /// </summary>
    public class PageDataCollection : IList<PageData>, ICollection<PageData>, IEnumerable<PageData>, IList, ICollection, IEnumerable
    {
        /// <summary>
        /// The page list.
        /// </summary>
        private List<PageData> _pageList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Milo.Core.PageDataCollection"/> class.
        /// </summary>
        public PageDataCollection ()
        {
            _pageList = new List<PageData> ();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Milo.Core.PageDataCollection"/> class.
        /// </summary>
        /// <param name="collection">Collection.</param>
        public PageDataCollection (ICollection<PageData> collection) 
        {
            this._pageList = new List<PageData> ((IEnumerable<PageData>)collection);
        }

        /// <summary>
        /// Clear this instance.
        /// </summary>
        public void Clear () 
        {
            this._pageList.Clear ();
        }

        /// <Docs>The item to add to the current collection.</Docs>
        /// <para>Adds an item to the current collection.</para>
        /// <remarks>To be added.</remarks>
        /// <exception cref="System.NotSupportedException">The current collection is read-only.</exception>
        /// <summary>
        /// Add the specified pageData.
        /// </summary>
        /// <param name="pageData">Page data.</param>
        public void Add (PageData pageData) 
        {
            if (pageData == null)
                return;
        
            this._pageList.Add (pageData);
        }

        /// <Docs>The item to remove from the current collection.</Docs>
        /// <para>Removes the first occurrence of an item from the current collection.</para>
        /// <summary>
        /// Remove the specified pageData.
        /// </summary>
        /// <param name="pageData">Page data.</param>
        public bool Remove (PageData pageData) 
        {
            return this._pageList.Remove (pageData);	
        }

        /// <summary>
        /// Copy the PageDataCollection into a new variable.
        /// </summary>
        public PageDataCollection Copy () 
        {
            return new PageDataCollection ((ICollection<PageData>)this._pageList);
        }

        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns>The enumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) this._pageList.GetEnumerator();
        }
    }
}

