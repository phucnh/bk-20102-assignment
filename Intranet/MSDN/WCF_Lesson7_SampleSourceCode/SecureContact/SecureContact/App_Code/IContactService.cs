using System.Runtime.Serialization;
using System.ServiceModel;

/// <summary>
/// Định nghĩa thông tin về một nhân viên
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
}

[ServiceContract]
public interface IContactService
{
    [OperationContract]
    bool HasPerson(int personId);

    /// <summary>
    /// Lấy về thông tin của một nhân viên.
    /// Nếu có nhân viên với ID trùng với personId thì trả về thông tin nhân viên đó.
    /// Trong trường hợp không có nhân viên phù hợp thì báo lỗi bằng bản tin lỗi
    /// </summary>
    /// <param name="personId">ID của nhân viên</param>
    /// <returns>Thông tin của nhân viên</returns>
    [OperationContract]
    Person GetPerson(int personId);

    [OperationContract]
    Person[] GetAll();

    [OperationContract]
    void AddPerson(Person person);

    /// <summary>
    /// Sửa thông tin của một nhân viên.
    /// Nếu có nhân viên với ID trùng với personId thì cập nhật thông tin nhân viên đó.
    /// Trong trường hợp không có nhân viên phù hợp thì báo lỗi bằng bản tin lỗi
    /// </summary>
    /// <param name="personId">ID của nhân viên</param>
    /// <param name="person">Thông tin mới về nhân viên</param>
    [OperationContract]
    void EditPerson(int personId, Person person);

    /// <summary>
    /// Xoá thông tin một nhân viên
    /// Nếu có nhân viên với ID trùng với personId thì xoá thông tin nhân viên đó.
    /// Trong trường hợp không có nhân viên phù hợp thì báo lỗi bằng bản tin lỗi
    /// </summary>
    /// <param name="personId">ID của nhân viên</param>
    [OperationContract]
    void DeletePerson(int personId);
}