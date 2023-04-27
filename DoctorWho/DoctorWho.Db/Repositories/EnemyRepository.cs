using DoctorWhoDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository
    {
        DoctorWhoDbContext _context = new DoctorWhoDbContext();
        public async Task Update(int EnemyId, string EnemyName, string? Description)
        {
            var enemy = await _context.Enemies.FindAsync(EnemyId);
            if (enemy != null)
            {
                enemy.EnemyName = EnemyName;
                enemy.Description = Description;
                await _context.SaveChangesAsync();
            }
            throw new KeyNotFoundException();
        }

        public async Task Delete(int EnemyId)
        {
            var enemy = await _context.Enemies.FindAsync(EnemyId);
            if (enemy != null)
            {
                _context.Enemies.Remove(enemy);
                await _context.SaveChangesAsync();
            }
        }

        public async Task Add(string EnemyName, string? Description)
        {
            _context.Enemies.Add(new Enemy{ EnemyName = EnemyName, Description = Description });
            await _context.SaveChangesAsync();
        }

        public async Task<Enemy> GetEnemyById(int EnemyId)
        {
            var enemy = await _context.Enemies.FindAsync(EnemyId);

            if (enemy != null)
                return enemy;

            throw new Exception("Enemy Does Not Exist");

        }
    }
}
