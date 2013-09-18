namespace Milo.Web.Mvc
{
    public abstract class PageController<TPageType> : BaseController where TPageType : class
    {

    }

    // Demo code below.

    public class TestController : PageController<TestPageType>
    {
    }

    public class TestPageType
    {
        public virtual string LinkTitle { get; set; }
    }
}
