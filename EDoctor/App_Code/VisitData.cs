using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EDoctor.App_Code
{
    public class VisitData
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string PESEL;
        public int DoctorId;
        public string CardNumber = "";
        public DateTime DateVisit;
    }
}