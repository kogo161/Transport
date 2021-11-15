using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Transport.Domain.Models.DbEntities
{
    public class UserEntity
    {
        [Key] public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [StringLength(11)] public string PersonalNumber { get; set; }
        public IEnumerable<TransportEntity> Transports { get; set; }
    }
}