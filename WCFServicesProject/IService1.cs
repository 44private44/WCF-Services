using System;
using System.Collections.Generic;
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // Getting All Mission Data
        [OperationContract]
        [WebGet(UriTemplate = "MissionData/GetData", ResponseFormat = WebMessageFormat.Json)]
        List<AllMisisonDataGet> GetMissionData();

        // Getting One Mission Data
        [OperationContract]
        [WebInvoke(UriTemplate = "MissionData/OneMissionData/{Missionid}", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        AllMisisonDataGet GetOneMissionData(string Missionid);

        // Insert Admin Data
        [OperationContract]
        [WebInvoke(UriTemplate = "AdminData/InsertData", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string InsertMissionData(Admin admin);

        // Getting All Admin data
        [OperationContract]
        [WebGet(UriTemplate = "GettingAdminData", ResponseFormat = WebMessageFormat.Json)]
        List<AdminData> GetAllAdminData();
            
        // Insert Admin data
        [OperationContract]
        [WebInvoke(UriTemplate="InsertAdminData", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]  
        string InsertAdminData(AdminData adminData);

        // Update Admin Data
        [OperationContract]
        [WebInvoke(UriTemplate ="UpdateAdminData", Method ="POST", RequestFormat =WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json)]
        string UpdateAdminData(AdminData adminData);

        //Delete AdminData
        [OperationContract]
        [WebInvoke(UriTemplate= "DeleteAdminData", Method = "POST", RequestFormat =WebMessageFormat.Json, ResponseFormat =WebMessageFormat.Json)]
        string DeleteAdminData(AdminData adminData);
    }
}
