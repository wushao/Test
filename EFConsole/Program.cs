using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var efDbContext = new EfDbContext())
            {
                efDbContext.Blogs.Add(new Blog()
                {
                    Name = "Test",
                    Url = "Test"

                });
              
                efDbContext.SaveChanges();
            }
        }
    }
}
