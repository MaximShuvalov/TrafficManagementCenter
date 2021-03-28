﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;
using TrafficManagementCenter.Server.Db.Context;

namespace TrafficManagementCenter.Server.Db.Repositories
{
    public class AppealRepository : IRepository<Appeal>
    {
        private readonly AppDbContext _context;

        public AppealRepository(AppDbContext context)
        {
            _context = context;
        }

        public Appeal Get(long id) => _context.Appeal.Include(p => p.AppealClass)
            .Include(o => o.Subtype)
            .FirstOrDefault(p => p.Key.Equals(id));

        public async Task<IEnumerable<Appeal>> GetEntities() => await Task.Run(() =>
        {
            return _context.Appeal.Include(p => p.AppealClass)
            .Include(o => o.Subtype);
        });

        public async Task Add(Appeal entity) => await Task.Run(() =>
        {
            if (entity is null)
                throw new ArgumentException("Appeal is null");
            _context.Appeal.Add(entity);
        });

        public void Delete(Appeal entity)
        {
            if (entity is null)
                throw new ArgumentException("Appeal is null");
            _context.Appeal.Remove(entity);
        }
    }
}