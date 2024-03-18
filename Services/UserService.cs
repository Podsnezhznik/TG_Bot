using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Data.Common;
using System.Data.SQLite;
using Dapper;

public class UserService
{
    private readonly IOptionsMonitor<DbSettings> _dbSettingsMonitor;
    private readonly ILogger<UserService> _logger;

    private DbSettings _dbSettings => _dbSettingsMonitor.CurrentValue;

    private DbConnection GetConn() => new SQLiteConnection(_dbSettings.ConnectionString);

    public UserService
    (
        IOptionsMonitor<DbSettings> dbSettingsMonitor,
        ILogger<UserService> logger
    )
    {
        _dbSettingsMonitor = dbSettingsMonitor;
        _logger = logger;
    }

    #region [ DAL ]

    public int Create (UserCreateModel model)
    {
        _logger.LogInformation("подключаемся к БД...");
        using var db = GetConn();
        _logger.LogInformation("подключение успешно!");
        var sql = "INSERT INTO User (Login, Pass) VALUES(@Login, @Pass); SELECT last_insert_rowid()";
        _logger.LogInformation("добавляем пользователя...");
        var id = db.Query<int>(sql, model).FirstOrDefault();
        _logger.LogInformation($"успешно создан пользователь с id={id}");
        return id;
    }

    #endregion

    #region [ BL ]

    public UserFullModel GetByLogin (string login)
    {
        //...
        return null;
    }

    public IEnumerable<UserShortModel> GetListByActivity (string login)
    {
        //...
        return null;
    }

    public bool CheckAuth(string login, string pass)
    {
        //...
        return false;
    }

    public void UpdateActivity(int userid)
    {
        //...
    }

    #endregion
}