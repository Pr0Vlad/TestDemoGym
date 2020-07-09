using System;
using System.Collections.Generic;
using System.Text;

namespace GymLibraryData.DataModels
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public Program Program { get; set; }

        //public virtual GymCard gymCard { get; set; }
    }
}
