using CMS.Shared.Enums.Users;
using System.ComponentModel.DataAnnotations;

namespace CMS.EntityFramework.Domain
{
    public class User : BaseEntity
    {
        [MaxLength(256)]
        public string UserName { get; set; }
        [MaxLength(256)]
        public string FirstName { get; set; }
        [MaxLength(256)]
        public string LastName { get; set; }
        [MaxLength(256)]
        public string Email { get; set; }
        public string Password { get; set; }
        public UserStatusEnum Status { get; set; }
    }
}
