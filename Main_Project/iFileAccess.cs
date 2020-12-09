using System;
using System.Collections.Generic;
using System.IO;

namespace Main_Project
{
    internal interface iFileAccess
    {
        SortedDictionary<string, Employee> EmployeeDB
        {
            get;
            set;
        }

        Stream fileStream
        {
            get;
            set;
        }

        void OpenFileDB();  //Utilizes OpenFileDialog and sets the "fileStream" property
        void SaveFileDB();  //Utilizes SaveFileDialog and sets the "fileStream" property
        void ReadDB();      //Deserializes the "fileStream" and sets the EmployeeDB
        void WriteDB();     //Serializes the EmployeeDB and writes to the "fileStream"
    }
}