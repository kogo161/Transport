using System.Collections.Generic;
using Transport.Domain.Models.DbEntities;

namespace Transport.Domain.Models.Requests
{
    public class UserRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber { get; set; }
    }
}