using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EntityFramework021
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ResPlannerConn")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
