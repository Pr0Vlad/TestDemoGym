using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;using System.Threading.Tasks;
using GymLibraryData.DataModels;
using System.Data;

namespace GymLibraryData
{
    public class ExerciseDataAccess
    {
        private SqlDbContext db;
        
        public ExerciseDataAccess(SqlDbContext db)
        {
            this.db = db;
        }
        public List<Exercise> SelectAll()
        {
            
            return db.Exercises.ToList();
            
        }
        
    }
}



