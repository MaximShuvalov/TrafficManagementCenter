using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using TrafficManagementCenter.Server.Db.Context;
using TrafficManagementCenter.Server.Db.Factory;
using TrafficManagementCenter.Server.Db.Repositories;

namespace TrafficManagementCenter.Server.Db.Extensions
{
    public static class AppealRepositoryExtensions
    {
        public static long GetIdByEmailAndText(this AppealRepository repos, string email, string text)
        {
            // ReSharper disable once PossibleNullReferenceException
            return repos.GetEntities().FirstOrDefault(p
                => p.Email.Equals(email) && p.Text.Equals(text)).Key;
        }

        public static IEnumerable<Appeal> GetEntitiesByEmail(this AppealRepository repository, string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException($"Error receiving appeals email = {email}");
            return repository.GetEntities().Where(p => p.Email.Equals(email));
        }

        public static void Add(this AppealRepository repository, Appeal appeal, string nameClassAppeal,
            string nameSubtypeAppeal)
        {
            var classAppealRepository = RepositoryFactory<ClassAppeal>.Create(new AppDbContext());
            var subtypeAppealRepository = RepositoryFactory<SubtypeAppeal>.Create(new AppDbContext());

            var classAppeal = classAppealRepository.GetEntities().FirstOrDefault(p => p.Name.Equals(nameClassAppeal));
            var subtypeAppeal = subtypeAppealRepository.GetEntities()
                .FirstOrDefault(p => p.Name.Equals(nameSubtypeAppeal));

            appeal.SubtypeId = subtypeAppeal.Key;
            appeal.ClassAppealId = classAppeal.Key;

            repository.Add(appeal);
        }
        
        public static void Add(this AppealRepository repository, Appeal appeal, string nameClassAppeal)
        {
            var classAppealRepository = RepositoryFactory<ClassAppeal>.Create(new AppDbContext());

            var classAppeal = classAppealRepository.GetEntities().FirstOrDefault(p => p.Name.Equals(nameClassAppeal));
            
            appeal.ClassAppealId = classAppeal.Key;

            repository.Add(appeal);
        }
    }
}