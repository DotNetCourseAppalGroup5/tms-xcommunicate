using System;
using System.Data.Entity;
using Models.Entities;
using DataProvider;

namespace WebApp.Models
{
    public class EntityInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {
            db.Entity.Add(new Entity { EntityTypeId = 1, UploadedAt = DateTime.Now, UserId = 140, Content = "Раз два три", EntityParentId = 1, ParentGroupId = 1 });
            db.Entity.Add(new Entity { EntityTypeId = 1, UploadedAt = DateTime.Now, UserId = 140, Content = "првоаровр овоарповарповла воапрволарповарлп ваопр ловар п", EntityParentId = 1, ParentGroupId = 1 });

            base.Seed(db);
        }
    }
}