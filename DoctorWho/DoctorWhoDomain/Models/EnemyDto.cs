using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWhoDomain.Models
{
    public class EnemyDto
    {
        public int EnemyId { get; set; }
        public string? EnemyName { get; set; }
        public string? Description { get; set; }

        public override string ToString()
        {
            return $"EnemyId: {EnemyId} \n EnemyName: {EnemyName}\n Description: {Description}";
        }
    }
}
