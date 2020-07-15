using GymLibraryData.DataModels;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Configuration;
using System.Data;
using Dapper;
using System.Linq;
using System.Data.SqlClient;

namespace GymLibraryData.DataConnection
{
    public class SqlConnection : DataConnection 
    {
        
        public static Exercise GetExercise()
        {
            //List<Exercise> output;

            

            Exercise p = new Exercise();
            //output.Add(p);
            return p;
        }
        public Exercise CreateExercise(Exercise model)
        {
            throw new NotImplementedException();
        }
    }
}