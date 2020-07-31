using GymLibraryData.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymLibraryData
{
    public class ProgramDataAccess
    {
        private SqlDbContext db;
        
        public ProgramDataAccess(SqlDbContext db)
        {
            this.db = db;
        }
        public List<Program> SelectAll()
        {
            return db.programs.ToList();
        }
    }
}
