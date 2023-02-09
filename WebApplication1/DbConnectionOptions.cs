using Furion.ConfigurableOptions;
using SqlSugar;

/// <summary>
/// 数据库链接配置
/// </summary>
public sealed class DbConnectionOptions : IConfigurableOptions
{
    /// <summary>
    /// 数据库初始化配置
    /// </summary>
    public InitConfig IntiConfig { get; set; }

    /// <summary>
    /// 数据库配置集合
    /// </summary>
    public List<ConnectionConfig> ConnectionConfigs { get; set; }

    /// <summary>
    /// 启用库表差异日志
    /// </summary>
    public bool EnableDiffLog { get; set; }
}

/// <summary>
/// 数据库初始化配置
/// </summary>
public class InitConfig
{
    /// <summary>
    /// 启用初始化库表
    /// </summary>
    public bool EnableInitTable { get; set; } = false;

    /// <summary>
    /// 启用初始化表数据
    /// </summary>
    public bool EnableSeedData { get; set; } = false;
}