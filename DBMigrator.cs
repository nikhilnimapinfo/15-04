namespace Inheritance
{
    internal partial class Program
    {
        public class DBMigrator
        {

            private readonly Logger _logger;


            public DBMigrator(Logger loger)
            {
                _logger = loger;
            }

            public void Migrate()
            {
                _logger.Log("We are Migrate bla bla bla...");


            }
        }
    }
}
