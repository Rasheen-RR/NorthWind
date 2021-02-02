using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CFM.Migrations
{
    internal sealed class Configuration: DbMigrationsConfiguration<NorthWind.Contexts.NorthWindContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NorthWind.Contexts.NorthWindContext context)
        {
            //base.Seed(context);
        }
    }
}
