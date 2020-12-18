namespace EFCore_RecordType_Api.Models.Records
{
    public record RecordBase;

    public record PersonBase(int ID, string FirstName, string LastName) : RecordBase;
}