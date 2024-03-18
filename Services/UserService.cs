using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

public class UserService
{
    private readonly IOptionsMonitor<DbSettings> _dbSettingsMonitor;
    private readonly ILogger<UserService> _logger;

    private DbSettings _dbSettings => _dbSettingsMonitor.CurrentValue;

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
        //...
        return 0;
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