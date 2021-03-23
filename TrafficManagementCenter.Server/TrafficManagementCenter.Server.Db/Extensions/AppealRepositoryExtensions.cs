using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
using TrafficManagementCenter.Server.Db.Context;
using TrafficManagementCenter.Server.Db.Factory;
using TrafficManagementCenter.Server.Db.Repositories;

namespace TrafficManagementCenter.Server.Db.Extensions
{
    public static class AppealRepositoryExtensions
    {
        public static async Task<long> GetIdByEmailAndTextAsync(this AppealRepository repos, string email, string text)
        {
            var entities = await repos.GetEntities();
            return entities.FirstOrDefault(p
                => p.Email.Equals(email) && p.Text.Equals(text)).Key;
        }

        public async static Task<IEnumerable<Appeal>> GetEntitiesByEmail(this AppealRepository repository, string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException($"Error receiving appeals email = {email}");
            var appeals = await repository.GetEntities();
            return appeals.Where(p => p.Email.Equals(email));
        }

        public async static void Add(this AppealRepository repository, Appeal appeal, string nameClassAppeal,
            string nameSubtypeAppeal)
        {
            var classAppealRepository = RepositoryFactory<ClassAppeal>.Create(new AppDbContext());
            var subtypeAppealRepository = RepositoryFactory<SubtypeAppeal>.Create(new AppDbContext());

            var classAppeal = (await classAppealRepository.GetEntities()).FirstOrDefault(p => p.Name.Equals(nameClassAppeal));
            var subtypeAppeal = (await subtypeAppealRepository.GetEntities())
                .FirstOrDefault(p => p.Name.Equals(nameSubtypeAppeal));
            if (classAppeal is null || subtypeAppeal is null)
                throw new Exception("The database does not contain the given object");
            appeal.SubtypeId = subtypeAppeal.Key;
            appeal.ClassAppealId = classAppeal.Key;

            repository.Add(appeal);
        }
    }
}