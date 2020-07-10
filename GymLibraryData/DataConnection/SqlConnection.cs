using GymLibraryData.DataModels;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GymLibraryData.DataConnection
{
    public class SqlConnection : DataConnection
    {

        /// <summary>
        /// next time we gonna fill a SQL database and pull from there
        /// </summary>
        public static List<Exercise> output = new List<Exercise>();
        public Exercise CreateExercise(Exercise model)
        {
            Exercise p = new Exercise();
            p.Id = 1;
            p.ExerciseName = "Bench Press";
            p.sets = 1;
            p.reps = 1;

            output.Add(p);
            return p;
        }
        public static Exercise getExercise()
        {
            Exercise p = new Exercise();
            p.Id = 1;
            p.ExerciseName = "Bench Press";
            p.sets = 1;
            p.reps = 1;

            output.Add(p);
            return p;
            
        }
    }
}
       


