namespace Catalog.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; init; }
        public int Port { get; init; }
        public string User { get; init; }
        public string Password { get; init; }

        public string ConnectionString
        {
            get
            {
                return $"mongodb://{User}:{Password}@{Host}:{Port}";
            }
        }
    }
}