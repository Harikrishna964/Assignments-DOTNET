using System.Data.Entity;

namespace EFModel1
{
    class MyDAL : DbContext

    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("TblPersons");
            base.OnModelCreating(modelBuilder);
        }

        //DbSet will represent all the Persons that can be queried from the database
        public DbSet<Person> Persons { get; set; }
    }
}