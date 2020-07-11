using GymLibraryData.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace GymLibraryData.DataConnection
{
    interface DataConnection
    {
        Exercise CreateExercise(Exercise model);
       
    }
}
