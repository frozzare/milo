using System;
using System.Web.UI;
using System.Collections.Generic;
using Milo.Core;

namespace Milo
{
    public abstract class PageBase : Page
    {
        public PageBase ()
        {
        }

        public List<PageData> GetChildren (int pageLink) 
        {
            return new List<PageData>();
        }
    }
}

