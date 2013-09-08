using System;

namespace Milo.Core
{
	public abstract class AttributeBase : Attribute
	{
		public string Name { get; set; }
		public string Description { get; set; }
	}
}