namespace T4Sample;


/// <summary>
/// 列情報
/// </summary>
public class ColumnInfo
{
    /// <summary>
    /// 列名
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 列のデータベース上での型
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// 主キーか
    /// </summary>
    public bool IsPrimary { get; set; }

    /// <summary>
    /// nullを許可しないか
    /// </summary>
    public bool NotNull { get; set; }

    /// <summary>
    /// コメント
    /// </summary>
    public string Description { get; set; }
}
