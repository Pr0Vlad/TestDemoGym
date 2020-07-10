using GymLibraryData.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymLibraryData.DataConnection
{
    interface DataConnection
    {
        Exercise CreateExercise(Exercise model);
    }
}
