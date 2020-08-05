namespace IoTApps.Models
{
    using System.Data.Entity;

    public class DBModel : DbContext
    {
        public DBModel() : base("name=DBModel")
        {
        }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<Sensor> Sensors { get; set; }
        public virtual DbSet<Readings> Readings { get; set; }
        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<Data> ChannelsData { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}