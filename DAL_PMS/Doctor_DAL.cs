using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject_PMS;
using System.Configuration;

namespace DAL_PMS
{
    public class Doctor_DAL
    {


        public int AddPatient(Patients bo)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
                
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_insertPatients", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", bo._Id);
                cmd.Parameters.AddWithValue("@PatientName", bo._PatientName);
                cmd.Parameters.AddWithValue("@Birthdate", bo._Birthdate);
                cmd.Parameters.AddWithValue("@Gender", bo._Gender);
                cmd.Parameters.AddWithValue("@Weight", bo._Weight);
                cmd.Parameters.AddWithValue("@BloodGroupId", bo._BloodGroupId);
                cmd.Parameters.AddWithValue("@PhoneNumber", bo._PhoneNumber);
                cmd.Parameters.AddWithValue("@DepartmentId", bo._DepartmentId);
                cmd.Parameters.AddWithValue("@AppointmentDate", bo._AppointmentDate);

                int Result = cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();
                return Result;
            }
            catch
            {
                throw;
            }
        }

        public int DeletePatient(int _Id)
        {

            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_DeletePatients", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", _Id);
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                return Result;
            }
            catch
            {
                throw;
            }
           
        }
        public DataSet GetAllDetailsByID(int _Id)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
              

                SqlCommand cmd = new SqlCommand("sp_getAllDetailsByID", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id",_Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch
            {
                throw;
            }
        }

        public int UpdatePatient(int _Id, float _Weight, long _PhoneNumber, int _DepartmentId, DateTime _AppointmentDate)
        {

            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_UpdatePatient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", _Id);
                cmd.Parameters.AddWithValue("@Weight",_Weight);
                cmd.Parameters.AddWithValue("@PhoneNumber", _PhoneNumber);
                cmd.Parameters.AddWithValue("@DepartmentId", _DepartmentId);
                cmd.Parameters.AddWithValue("@AppointmentDate", _AppointmentDate.ToShortDateString());

                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                return Result;
            }
            catch
            {
                throw;
            }

        }

        public DataSet GetAllPatientsByDepartmentName(string _DepartmentName)
        {

            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
              
                SqlCommand cmd = new SqlCommand("sp_GetAllPatientsByDepartmentName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@DepartmentName",_DepartmentName);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch
            {
                throw;
            }

        }


        public DataSet GetAllPatientsInfo()
        {

            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());

                SqlCommand cmd = new SqlCommand("select * from Patients p join Departments d on p.DepartmentId=d.DepartmentId join BloodGroups b on p.BloodGroupId=b.BloodGroupId", con);
            
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch
            {
                throw;
            }

        }

    }   


}
