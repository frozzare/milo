using System;
using System.Collections;
using System.Collections.Generic;

namespace Milo.Core
{
	public class LanguageCollection : IList<string>, ICollection<string>, IEnumerable<string>, IList, ICollection, IEnumerable
	{
		/// <summary>
		/// The languages list.
		/// </summary>
		private List<string> _languages;

		/// <summary>
		/// Initializes a new instance of the <see cref="Milo.Core.LanguageCollection"/> class.
		/// </summary>
		public LanguageCollection ()
		{
			_languages = new List<string> ();
		}

		/// <summary>
		/// Add the specified language.
		/// </summary>
		/// <param name="language">Language.</param>
		public void Add (string language) 
		{
			if (string.IsNullOrEmpty (language))
				return;

			_languages.Add (language);
		}

		/// <Docs>The object to locate in the current collection.</Docs>
		/// <para>Determines whether the current collection contains a specific value.</para>
		/// <summary>
		/// Contains the specified language.
		/// </summary>
		/// <param name="language">Language.</param>
		public bool Contains (string language) 
		{
			return this._languages.Contains (language);
		}

		/// <summary>
		/// Remove the specified language.
		/// </summary>
		/// <param name="language">Language.</param>
		public bool Remove (string language) 
		{
			return this._languages.Remove (language);
		}

        /// <summary>
        /// Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe).
        /// </summary>
        /// <returns>true if access to the <see cref="T:System.Collections.ICollection" /> is synchronized (thread safe); otherwise, false.</returns>
        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

		/// <summary>
		/// Gets the enumerator.
		/// </summary>
		/// <returns>The enumerator.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator) this._languages.GetEnumerator();
		}
	}
}

