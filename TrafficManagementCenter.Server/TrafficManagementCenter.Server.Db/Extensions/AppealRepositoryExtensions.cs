using System;
using System.Collections.Generic;
using System.Linq;
using Model;
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
    }
}