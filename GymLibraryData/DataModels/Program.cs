using System;
using System.Collections.Generic;
using System.Text;

namespace GymLibraryData.DataModels
{
    public class Program
    {
        public int Id { get; set; }

        public string ProgramGoal { get; set; }
        public string ProgramName { get; set; }
        public List<Exercise> exercises { get; set; }   
        public int sets { get; set; }
        public int reps { get; set; }
    }
}
