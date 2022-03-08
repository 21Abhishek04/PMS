using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject_PMS;
using DAL_PMS;

namespace BusinessLayer_PMS
{
    public class PMS_BL
    {


        public DataSet GetAlldetailsByID(int id)
        {
            Doctor_DAL dal = new Doctor_DAL();
            return dal.GetAllDetailsByID(id);
        }




        public int SaveAddedDetails(Patients ob)
        {
                Doctor_DAL dal = new Doctor_DAL();
                return dal.AddPatient(ob);
        }

      

            public int SavedeletedDetails(int id)
            {
                Doctor_DAL dal = new Doctor_DAL();
                return dal.DeletePatient(id);
            }


        public int UpdatedDetails(int id,float weight,long PhoneNumber,int DepartmentId,DateTime AppointmentDate)
        {
            Doctor_DAL dal = new Doctor_DAL();
            return dal.UpdatePatient(id, weight, PhoneNumber,DepartmentId, AppointmentDate);
       }

        

        public DataSet GetAllPatientsinfobyDepartmentName(string _DepartmentName)
        {
            Doctor_DAL dal = new Doctor_DAL();
            return dal.GetAllPatientsByDepartmentName(_DepartmentName);
        }

        public DataSet GetAllPatientsinfo()
        {
            Doctor_DAL dal = new Doctor_DAL();
            return dal.GetAllPatientsInfo();
        }
    }
}
