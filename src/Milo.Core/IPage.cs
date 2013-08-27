using System;
using System.Collections.Generic;

namespace Milo.Core
{
	public interface IPage
	{
		List<PageData> GetChildren (int pageLink);
	}
}

