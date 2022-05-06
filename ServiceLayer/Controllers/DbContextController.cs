using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;

namespace ServiceLayer.Controllers
    {
    public class DbContextController
        {
        private static GloNetDbContext _context;

        public static GloNetDbContext CreateContext()
            {
            _context = new GloNetDbContext();
            return _context;
            }

        public static GloNetDbContext GetContext()
            {
            return _context;
            }

        public static void SetChangeTracking(bool value)
            {
            _context.ChangeTracker.AutoDetectChangesEnabled = value;
            }
        }
    }
