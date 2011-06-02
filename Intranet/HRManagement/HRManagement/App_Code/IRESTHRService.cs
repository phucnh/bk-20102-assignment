using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

[ServiceContract]
public interface IRESTHRService
{
    [OperationContract]
    [WebGet(UriTemplate = "persons", ResponseFormat = WebMessageFormat.Json)]
    List<PersonData> GetAll();

    [OperationContract]
    [WebGet(UriTemplate = "person/{personId}", ResponseFormat = WebMessageFormat.Json)]
    PersonData GetPerson(string personId);

    [OperationContract]
    [WebInvoke(Method = "PUT",
            UriTemplate = "person/{personId}",
            RequestFormat = WebMessageFormat.Json)]
    void UpdatePerson(string personId, PersonData personData);

    [OperationContract]
    [WebInvoke(Method = "DELETE", UriTemplate = "person/{personId}")]
    void DeletePerson(string personId);
}
