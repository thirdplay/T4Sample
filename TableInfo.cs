using System.Collections.Generic;

namespace T4Sample;

/// <summary>
/// テーブル情報
/// </summary>
public class TableInfo
{
    /// <summary>
    /// テーブル名
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 列
    /// </summary>
    public IEnumerable<ColumnInfo> Columns { get; set; }

    /// <summary>
    /// コメント
    /// </summary>
    public string Description { get; set; }
}
