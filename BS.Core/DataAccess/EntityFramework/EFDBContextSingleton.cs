using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Core.DataAccess.EntityFramework
{
    public class EFDBContextSingleton<TContext> where TContext : DbContext, new()
    {

        private static TContext _context;

        private EFDBContextSingleton()
        {

        }

        public static TContext Instance
        {
            get
            {
                if (_context == null)
                {
                    _context = new TContext();
                }
                return _context;
            }
        }


    }
}
