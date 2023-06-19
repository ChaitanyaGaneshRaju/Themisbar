using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Learner> GetLearnerAsync()
        {
            return await _context.Learners.FirstAsync();
        }

        public async Task<User> GetUserByIdAsync(long id)
        {
            return await _context.Users
            .Include(u => u.Learner)
            .FirstOrDefaultAsync(x => x.IdUser == id);
        }

        public async Task<IReadOnlyList<User>> GetUsersAsync()
        {
            return await _context.Users
            .Include(u => u.Learner)
            .ToListAsync();
        }
    }
}