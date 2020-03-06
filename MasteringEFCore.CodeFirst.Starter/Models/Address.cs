using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.CodeFirst.Starter.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string FlatHouseInfo { get; set; }

        public string StreetName { get; set; }

        public string Locality { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string LatitudeLongitude { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public int CreatedBy { get; set; }

        public int ModifiedBy { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
