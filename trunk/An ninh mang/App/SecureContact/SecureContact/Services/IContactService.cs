using System.Runtime.Serialization;
using System.ServiceModel;
using System.Net.Security;

namespace SecureContact
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IContactService" in both code and config file together.
    [ServiceContract(ProtectionLevel=ProtectionLevel.EncryptAndSign)]
    public interface IContactService
    {
        [OperationContract]
        bool HasPerson(int personId);
        [OperationContract]
        [FaultContract(typeof(CustomFaultMsg))]
        Person GetPerson(int personId);
        [OperationContract(ProtectionLevel=ProtectionLevel.EncryptAndSign)]
        Person[] GetAll();
        [OperationContract]
        void AddPerson(Person person);
        [OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
        [FaultContract(typeof(CustomFaultMsg))]
        void EditPerson(int personId, Person person);
        [OperationContract]
        [FaultContract(typeof(CustomFaultMsg))]
        void DeletePerson(int personId); 
    }

    /// <summary>
    /// Person informations
    /// </summary>
    [DataContract]
    public class Person
    {
        [DataMember]
        public int PersonId;
        [DataMember]
        public string FullName;
        [DataMember]
        public int Age;
        [DataMember]
        public string Address;
        [DataMember]
        public string EmailAddress;
    } 
}
