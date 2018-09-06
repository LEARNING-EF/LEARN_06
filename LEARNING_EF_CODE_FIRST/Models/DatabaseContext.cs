namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			// اين گزينه به درد برنامه نويسان می خورد
			//System.Data.Entity.Database.SetInitializer
			//	(new System.Data.Entity.DropCreateDatabaseAlways<DatabaseContext>());

			// اين گزينه به درد برنامه نويسان می خورد
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());

			// اين گزينه به درد مشتری می خورد
			//System.Data.Entity.Database.SetInitializer
			//	(new System.Data.Entity.CreateDatabaseIfNotExists<DatabaseContext>());
		}

		public DatabaseContext() : base()
		{
		}

		public System.Data.Entity.DbSet<Person> People { get; set; }
	}
}
