using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject_PMS
{
    public class Patients: Departments
    {
       

        public int _Id { get; set; }
        public string _PatientName { get; set; }
        public DateTime _Birthdate { get; set; }
        public char _Gender { get; set; }
        public float _Weight { get; set; }
        public int _BloodGroupId { get; set; }
        public long _PhoneNumber { get; set; }
        public override int _DepartmentId { get; set; }
        public DateTime _AppointmentDate { get; set; }
        public override string _DepartmentName { get; set; }
        public char _BloodGroup { get; set; }

    }
}
