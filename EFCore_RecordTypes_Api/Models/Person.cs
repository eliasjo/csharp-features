using System.ComponentModel.DataAnnotations;

namespace EFCore_RecordType_Api.Models
{
    public class Person : EfEntityBase
    {
        [Key]
        public int ID { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

    public class EfEntityBase
    {
    }
}

