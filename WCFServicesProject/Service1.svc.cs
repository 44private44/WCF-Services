using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFServicesProject.AdminModel;
using WCFServicesProject.DataModels;
using WCFServicesProject.MissionModel;

namespace WCFServicesProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private readonly string connectionString = "Server=PCA172\\SQL2017;Database=CIPlatform;Trusted_Connection=True;MultipleActiveResultSets=true;User ID=sa;Password=Tatva@123;Integrated Security=False; TrustServerCertificate=True";

        // get the all mission data records
        public List<AllMisisonDataGet> GetMissionData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<AllMisisonDataGet> missionDataList = connection.Query<AllMisisonDataGet>("MissionDataByDapper", commandType: CommandType.StoredProcedure).ToList();

                return missionDataList;
            }
        }
        // insert admin data
        public string InsertMissionData(Admin admin)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO admin (first_name, last_Name, Email, Password) VALUES (@FirstName, @LastName, @Email, @Password)";
                connection.Execute(insertQuery, admin);
            }

            return "Successfully stored data";
        }
        // getting the one mission data
        public AllMisisonDataGet GetOneMissionData(string Missionid)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new { missionID = Missionid }; // Create parameter object
                AllMisisonDataGet onemissiondata = connection.QueryFirstOrDefault<AllMisisonDataGet>("OneMissionDataByDapper", parameters, commandType: CommandType.StoredProcedure);
                return onemissiondata;
            }
        }


        //Getting All Admin Data
        public List<AdminData> GetAllAdminData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<AdminData> AllAdminData = connection.Query<AdminData>("Admin_Alldata", commandType: CommandType.StoredProcedure).ToList();

                return AllAdminData;
            }
        }

        //Insert AdminData
        public string InsertAdminData(AdminData adminData)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new
                {
                    FirstName = adminData.FirstName,
                    LastName = adminData.LastName,
                    Email = adminData.Email,
                    Password = adminData.Password
                };
                connection.Query("Insert_Admin_data", parameters, commandType: CommandType.StoredProcedure);
                return "Successfully Store the Admin Data...";
            }
        }

        //Update AdminData

        public string UpdateAdminData(AdminData adminData)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new
                {
                    Admin_id = adminData.Admin_id,
                    FirstName = adminData.FirstName,
                    LastName = adminData.LastName
                };
                connection.Query<AdminData>("Update_adminData", parameters, commandType: CommandType.StoredProcedure);
                return "Successfully update the records...";
            }
        }

        //Delete AdminData

        public string DeleteAdminData(AdminData adminData)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var parameters = new
                {
                    Admin_id = adminData.Admin_id
                };
                connection.Query("Delete_adminData", parameters, commandType: CommandType.StoredProcedure);

                return "Successfully deleted Records...";
            }
        }
    }
}
