using DoctorWhoDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain.Models
{
    public class CompanionDto
    {
        public int CompanionId { get; set; }
        public string? CompanionName { get; set; }
        public string? WhoPlayed { get; set; }

        public override string ToString()
        {
            return $"CompanionId: {CompanionId} \n CompanionName: {CompanionName}\n WhoPlayed: {WhoPlayed}";
        }
    }
}
