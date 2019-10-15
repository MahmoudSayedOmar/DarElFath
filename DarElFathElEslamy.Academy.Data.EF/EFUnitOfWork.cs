using DarElFathElEslamy.Academy.Domain;
using DarElFathElEslamy.Academy.Domain.Models.LookUps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarElFathElEslamy.Academy.Data.EF
{
    public class EFUnitOfWork :
       DbContext, IUnitOfWork
    {
        public EFUnitOfWork() : base("name=DarElFathElEslamy")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFUnitOfWork>());
        }
        //public DbSet<Applicant> Applicants { get; set; }
        //public DbSet<ApplicantLanguage> Languages { get; set; }
        public DbSet<Carosel> Carosels { get; set; }
        
        public void Commit()
        {
            SaveChanges();
        }

        public Task CommitAsync()
        {
            return SaveChangesAsync();
        }
    }
}