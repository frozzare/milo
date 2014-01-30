using System;
using System.Collections;
using System.Collections.Generic;

namespace Milo.Core
{
	/// <summary>
	/// Property data collection.
	/// </summary>
	public class PropertyDataCollection : IList<PropertyData>, IList
	{
		/// <summary>
		/// The page list.
		/// </summary>
		private readonly List<PropertyData> _propertyList;

		/// <summary>
		/// Initializes a new instance of the <see cref="Milo.Core.PropertyDataCollection"/> class.
		/// </summary>
		public PropertyDataCollection ()
		{
			_propertyList = new List<PropertyData> ();
		}

		/// <summary>
		/// Gets or sets the element at the specified index.
		/// </summary>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		/// <exception cref="System.ArgumentNullException">value;Cannot add null object to PropertyDataCollection</exception>
		public PropertyData this[int index]
		{
			get
			{
				return _propertyList[index];
			}
			set
			{
			    if (value == null)
			    {
			        throw new ArgumentNullException("value", "Cannot add null object to PropertyDataCollection");
			    }

			    _propertyList[index] = value;
			}
		}

		/// <summary>
		/// Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.
		/// </summary>
		/// <returns>The number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1" />.</returns>
		public int Count
		{
			get
			{
				return _propertyList.Count;
			}
		}

		/// <summary>
		/// Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.
		/// </summary>
		/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />.</returns>
		public object SyncRoot
		{
			get
			{
				return _propertyList.ToArray();
			}
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
		/// Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only.
		/// </summary>
		/// <returns>true if the <see cref="T:System.Collections.Generic.ICollection`1" /> is read-only; otherwise, false.</returns>
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		/// Gets a value indicating whether the <see cref="T:System.Collections.IList" /> has a fixed size.
		/// </summary>
		/// <returns>true if the <see cref="T:System.Collections.IList" /> has a fixed size; otherwise, false.</returns>
		public bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Milo.Core.PropertyDataCollection"/> class.
		/// </summary>
		/// <param name="collection">Collection.</param>
		public PropertyDataCollection (IEnumerable<PropertyData> collection) 
		{
			_propertyList = new List<PropertyData> (collection);
		}

		/// <summary>
		/// Clear this instance.
		/// </summary>
		public void Clear () 
		{
			_propertyList.Clear ();
		}

		/// <summary>
		/// Inserts the specified index.
		/// </summary>
		/// <param name="index">The index.</param>
		/// <param name="page">The page.</param>
		/// <exception cref="System.ArgumentNullException">value;Cannot add null object to PropertyDataCollection</exception>
		public void Insert(int index, PropertyData page)
		{
		    if (page == null)
		    {
		        throw new ArgumentNullException("value", "Cannot add null object to PropertyDataCollection");
		    }

		    _propertyList.Insert(index, page);
		}

		/// <summary>
		/// Removes the <see cref="T:System.Collections.Generic.IList`1" /> item at the specified index.
		/// </summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		public void RemoveAt(int index)
		{
			_propertyList.RemoveAt(index);
		}

		/// <summary>
		/// Gets or sets the element at the specified index.
		/// </summary>
		/// <param name="index">The index.</param>
		/// <returns></returns>
		/// <exception cref="System.ArgumentException">Must be of type PropertyData</exception>
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				PropertyData propertyData = value as PropertyData;
			    
                if (propertyData == null)
			    {
			        throw new ArgumentException("Must be of type PropertyData");
			    }

			    this[index] = propertyData;
			}
		}

		/// <summary>
		/// Removes the range.
		/// </summary>
		/// <param name="index">The index.</param>
		/// <param name="count">The count.</param>
		public void RemoveRange(int index, int count)
		{
			_propertyList.RemoveRange(index, count);
		}

		/// <summary>
		/// Sorts the specified comparer.
		/// </summary>
		/// <param name="comparer">The comparer.</param>
		public void Sort(IComparer<PropertyData> comparer)
		{
			_propertyList.Sort(comparer);
		}

		/// <summary>
		/// Copy the PropertyDataCollection into a new variable.
		/// </summary>
		public PropertyDataCollection Copy () 
		{
			return new PropertyDataCollection (_propertyList);
		}

		/// <summary>
		/// Adds the specified property.
		/// </summary>
		/// <param name="page">The property.</param>
		/// <exception cref="System.ArgumentNullException">value;Cannot add null object to PropertyDataCollection</exception>
		public void Add(PropertyData page)
		{
		    if (page == null)
		    {
		        throw new ArgumentNullException("value", "Cannot add null object to PropertyDataCollection");
		    }

		    _propertyList.Add(page);
		}

		/// <summary>
		/// Determines whether the <see cref="T:System.Collections.Generic.ICollection`1" /> contains a specific value.
		/// </summary>
		/// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1" />.</param>
		/// <returns>
		/// true if <paramref name="item" /> is found in the <see cref="T:System.Collections.Generic.ICollection`1" />; otherwise, false.
		/// </returns>
		public bool Contains(PropertyData item)
		{
			return _propertyList.Contains(item);
		}

		/// <summary>
		/// Removes the specified property.
		/// </summary>
		/// <param name="page">The property.</param>
		/// <returns></returns>
		public bool Remove(PropertyData page)
		{
			return _propertyList.Remove(page);
		}

		/// <summary>
		/// Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.
		/// </summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ICollection" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
		/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		void ICollection.CopyTo(Array array, int index)
		{
			_propertyList.ToArray().CopyTo(array, index);
		}

		/// <summary>
		/// Copies the automatic.
		/// </summary>
		/// <param name="array">The array.</param>
		/// <param name="index">The index.</param>
		public void CopyTo(PropertyData[] array, int index)
		{
			_propertyList.CopyTo(array, index);
		}

		/// <summary>
		/// Determines the index of a specific item in the <see cref="T:System.Collections.Generic.IList`1" />.
		/// </summary>
		/// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.IList`1" />.</param>
		/// <returns>
		/// The index of <paramref name="item" /> if found in the list; otherwise, -1.
		/// </returns>
		public int IndexOf(PropertyData item)
		{
			return _propertyList.IndexOf(item);
		}

		/// <summary>
		/// Adds an item to the <see cref="T:System.Collections.IList" />.
		/// </summary>
		/// <param name="value">The object to add to the <see cref="T:System.Collections.IList" />.</param>
		/// <returns>
		/// The position into which the new element was inserted, or -1 to indicate that the item was not inserted into the collection,
		/// </returns>
		/// <exception cref="System.ArgumentException">Must be of type PropertyData;value</exception>
		public int Add(object value)
		{
			PropertyData property = value as PropertyData;
		    
            if (property == null)
		    {
		        throw new ArgumentException("Must be of type PropertyData", "value");
		    }

		    Add(property);
			return _propertyList.Count - 1;
		}

		/// <summary>
		/// Determines whether the <see cref="T:System.Collections.IList" /> contains a specific value.
		/// </summary>
		/// <param name="value">The object to locate in the <see cref="T:System.Collections.IList" />.</param>
		/// <returns>
		/// true if the <see cref="T:System.Object" /> is found in the <see cref="T:System.Collections.IList" />; otherwise, false.
		/// </returns>
		public bool Contains(object value)
		{
		    PropertyData propertyData = value as PropertyData;
		    return propertyData != null && Contains(propertyData);
		}

	    /// <summary>
		/// Determines the index of a specific item in the <see cref="T:System.Collections.IList" />.
		/// </summary>
		/// <param name="value">The object to locate in the <see cref="T:System.Collections.IList" />.</param>
		/// <returns>
		/// The index of <paramref name="value" /> if found in the list; otherwise, -1.
		/// </returns>
		public int IndexOf(object value)
		{
			PropertyData propertyData = value as PropertyData;
	        return propertyData == null ? -1 : IndexOf(propertyData);
		}

		/// <summary>
		/// Inserts an item to the <see cref="T:System.Collections.IList" /> at the specified index.
		/// </summary>
		/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
		/// <param name="value">The object to insert into the <see cref="T:System.Collections.IList" />.</param>
		/// <exception cref="System.ArgumentException">Must be of type PropertyData;value</exception>
		public void Insert(int index, object value)
		{
			PropertyData propertyData = value as PropertyData;

		    if (propertyData == null)
		    {
		        throw new ArgumentException("Must be of type PropertyData", "value");
		    }

		    Insert(index, propertyData);
		}

		/// <summary>
		/// Removes the first occurrence of a specific object from the <see cref="T:System.Collections.IList" />.
		/// </summary>
		/// <param name="value">The object to remove from the <see cref="T:System.Collections.IList" />.</param>
		public void Remove(object value)
		{
			PropertyData propertyData = value as PropertyData;
		    
            if (propertyData == null)
		    {
		        return;
		    }

		    Remove(propertyData);
		}

		/// <summary>
		/// Returns an enumerator that iterates through a collection.
		/// </summary>
		/// <returns>
		/// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
		/// </returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return _propertyList.GetEnumerator();
		}

		/// <summary>
		/// Returns an enumerator that iterates through the collection.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
		/// </returns>
		public IEnumerator<PropertyData> GetEnumerator()
		{
			return _propertyList.GetEnumerator();
		}
	}
}

