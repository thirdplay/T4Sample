namespace T4Sample.Templates;

public partial class TextTemplate : ITemplate
{
    /// <summary>
    /// DB上の型名⇒C#上の型を引き当てるためのDictionary。
    /// </summary>
    private readonly Dictionary<string, string> _typeDictionary;

    /// <summary>
    /// 名前空間
    /// </summary>
    public string NameSpace { get; }

    /// <summary>
    /// テーブル情報
    /// </summary>
    public TableInfo Table { get; }

    public TextTemplate(Dictionary<string, string> typeDictionary, string nameSpace, TableInfo table)
        => (_typeDictionary, NameSpace, Table) = (typeDictionary, nameSpace, table);

    /// <summary>
    /// 列情報⇒C#の型名
    /// </summary>
    public string GetColumnType(ColumnInfo column)
        => _typeDictionary.TryGetValue(column.Type, out var n) ? n : column.Type
            + (column.NotNull ? "" : "?");
}
