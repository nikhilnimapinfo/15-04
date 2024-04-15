namespace Inheritance
{
    internal partial class Program
    {
        public class Instroller
        {

            private readonly Logger _logger;
            public Instroller(Logger logger)
            {
                _logger = logger;
            }

            public void Install()
            {
                _logger.Log("Installing the Application ");
            }
        }
    }
}
