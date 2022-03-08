using BusinessObject_PMS;
using DAL_PMS;
using System;
using System.Data;

namespace BusinessLayer_PMS
{
    public class PMS_BLBase
    {


        public DataSet GetAlldetailsByID(int id)
        {
            Doctor_DAL dal = new Doctor_DAL();
            return dal.GetAllDetailsByID(id);
        }

        public DataSet GetAllPatientsinfo()
        {
            Doctor_DAL dal = new Doctor_DAL();
            return dal.GetAllPatientsInfo();
        }



        public DataSet GetAllPatientsinfobyDepartmentName(string _DepartmentName)
        {
            Doctor_DAL dal = new Doctor_DAL();
            return dal.GetAllPatientsByDepartmentName(_DepartmentName);
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


        public int UpdatedDetails(int id, float weight, long PhoneNumber, int DepartmentId, DateTime AppointmentDate)
        {
            Doctor_DAL dal = new Doctor_DAL();
            return dal.UpdatePatient(id, weight, PhoneNumber, DepartmentId, AppointmentDate);
        }
    }
}