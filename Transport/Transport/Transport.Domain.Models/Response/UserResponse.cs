using System.Collections.Generic;
using Transport.Domain.Models.DbEntities;

namespace Transport.Domain.Models.Response
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber { get; set; }
        public IEnumerable<TransportEntity> Transports { get; set; }
    }
}