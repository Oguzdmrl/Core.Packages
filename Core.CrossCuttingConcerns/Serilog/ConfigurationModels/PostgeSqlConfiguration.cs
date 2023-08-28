namespace Core.CrossCuttingConcerns.Serilog.ConfigurationModels;

public class PostgeSqlConfiguration
{
    public string ConnectionString { get; set; }
    public string TableName { get; set; }
    public bool AutoCreateSqlTable { get; set; }

    public PostgeSqlConfiguration()
    {
        ConnectionString = string.Empty;
        TableName = string.Empty;
    }

    public PostgeSqlConfiguration(string connectionString, string tableName, bool autoCreateTable)
    {
        ConnectionString = connectionString;
        TableName = tableName;
        AutoCreateSqlTable = autoCreateTable;

    }
}