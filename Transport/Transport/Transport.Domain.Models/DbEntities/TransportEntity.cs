using System;
using System.ComponentModel.DataAnnotations;
using Transport.Domain.Models.Enums;

namespace Transport.Domain.Models.DbEntities
{
    public class TransportEntity
    {
        [Key] public int Id { get; set; }
        public string MarkLatName { get; set; }
        public string MarkGeoName { get; set; }
        public string ModelLatName { get; set; }
        public string ModelGeoName { get; set; }
        public string WinCode { get; set; }
        public string TransportNumber { get; set; }
        public DateTime DateOfProduction { get; set; }
        public string ColorIdentifier { get; set; }
        public Fuel FuelType { get; set; }
        public Byte Photo { get; set; }
        public UserEntity User { get; set; }
    }
}