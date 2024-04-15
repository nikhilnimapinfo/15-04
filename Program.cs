using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            // Inheritance
            var text = new Text();
            text.Width = 100;
            text.Copy();
            Console.WriteLine(text.Width.ToString());


            // Composition
            var dbmigrator = new DBMigrator(new Logger());

            var logger = new Logger();
            var instroller = new Instroller(logger);

            dbmigrator.Migrate();
            instroller.Install();

           

        }
    }
}
