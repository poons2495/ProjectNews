using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MITService.DataModel;

namespace MITService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MITService : IMITService
    {
        public List<Subject> GetMarks(int regNo)
        {
            List<Subject> subjects = new List<Subject>();

            Subject subject1 = new Subject();
            subject1.Name = "WS";
            subject1.Marks = 14;
            subjects.Add(subject1);

            Subject subject2 = new Subject();
            subject2.Name = "ADS";
            subject2.Marks = 13;
            subjects.Add(subject2);

            return subjects;
        }

        public string GetName(int regNo)
        {
            return regNo +"ABC";
        }

    }
}
