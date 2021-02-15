using System;
namespace Catalog.API.Settings
{
    public interface ICatalogDatabaseSettings
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
        string CollectionName { get; set; }

    }
}
