using System.ComponentModel;
using FluentNHibernate.Cfg.Db;
using MrCMS.Settings;

//using NHibernate.SqlAzure;

namespace MrCMS.DbConfiguration
{
    // TODO: Add SQL Azure support
    //[Description("Use SQL with Azure.")]
    //public class SqlServerAzureProvider : IDatabaseProvider
    //{
    //    private readonly DatabaseSettings _databaseSettings;

    //    public SqlServerAzureProvider(DatabaseSettings databaseSettings)
    //    {
    //        _databaseSettings = databaseSettings;
    //    }

    //    public IPersistenceConfigurer GetPersistenceConfigurer()
    //    {

    //        return
    //            MsSqlConfiguration.MsSql2012.ConnectionString(x => x.Is(_databaseSettings.ConnectionString));
    //    }

    //    public void AddProviderSpecificConfiguration(NHibernate.Cfg.Configuration config)
    //    {
    //        SqlServerGuidHelper.SetGuidToUniqueWithDefaultValue(config);
    //    }

    //    public string Type
    //    {
    //        get { return GetType().FullName; }
    //    }
    //}
}