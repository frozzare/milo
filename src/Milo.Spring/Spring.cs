using Milo.Spring.Interfaces;

namespace Milo.Spring
{
    /// <summary>
    /// Spring is Milo's database mapper
    /// </summary>
    public class Spring : ISpring
    {
        private static readonly Spring _instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static Spring Instance
        {
            get
            {
                return _instance;
            }
        }

        /// <summary>
        /// Initializes the <see cref="Spring"/> class.
        /// </summary>
        static Spring ()
        {
            _instance = new Spring();
        }
    }
}

