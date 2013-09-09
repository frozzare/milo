using System.Collections.Generic;
using System.Linq;
using Milo.Core;
using Milo.Core.Interfaces;
using Milo.Interfaces;

namespace Milo
{
    public class Milo : IPageSource, IMilo
    {
        private static Milo _instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static Milo Instance
        {
            get
            {
                return _instance ?? (_instance = new Milo());
            }
        }

        /// <summary>
        /// Initializes the <see cref="Milo"/> class.
        /// </summary>
        static Milo()
        {
            _instance = new Milo();
        }

        /// <summary>
        /// Gets the page.
        /// </summary>
        /// <param name="pageLink">The page link.</param>
        /// <returns></returns>
        public PageData GetPage(int pageLink)
        {
            return new PageData();
        }

        /// <summary>
        /// Gets the page.
        /// </summary>
        /// <typeparam name="TPageType">The type of the page type.</typeparam>
        /// <param name="pageLink">The page link.</param>
        /// <returns></returns>
        public TPageType GetPage<TPageType>(int pageLink) where TPageType : PageData, new()
        {
            return (TPageType) new PageData();
        }

        /// <summary>
        /// Gets the children.
        /// </summary>
        /// <param name="pageLink">The page link.</param>
        /// <returns></returns>
        public PageDataCollection GetChildren(int pageLink)
        {
            return new PageDataCollection();
        }

        /// <summary>
        /// Gets the children.
        /// </summary>
        /// <typeparam name="TPageType">The type of the page type.</typeparam>
        /// <param name="pageLink">The page link.</param>
        /// <returns></returns>
        public IEnumerator<TPageType> GetChildren<TPageType>(int pageLink) where TPageType : PageData, new()
        {
            return (IEnumerator<TPageType>) new PageDataCollection().Cast<TPageType>();
        }

        /// <summary>
        /// Gets the start page.
        /// </summary>
        /// <value>
        /// The start page.
        /// </value>
        public PageData StartPage
        {
            get
            {
                return new PageData();
            }
        }

        /// <summary>
        /// Gets the root page.
        /// </summary>
        /// <value>
        /// The root page.
        /// </value>
        public PageData RootPage
        {
            get
            {
                return new PageData();
            }
        }
    }
}
