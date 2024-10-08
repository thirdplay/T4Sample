﻿using T4Sample.Templates;

namespace T4Sample;

class Program
{
    static void Main()
    {
        // DBの型⇒C#の型変換表 DBMSごとに1つ用意すればよい
        var typeDef = new Dictionary<string, string>()
            {
                { "integer", "int" },
                { "varchar", "string" },
                { "date", "DateTime" },
            };

        // テーブル情報 実際はDBなどから取得するものとする
        var table = new TableInfo()
        {
            Name = "shain_master",
            Description = "社員マスタ",
            Columns = new[]
            {
                    new ColumnInfo() { Name = "shain_id", Type = "integer", IsPrimary = true, NotNull = true },
                    new ColumnInfo() { Name = "shain_name", Type = "varchar", NotNull = true },
                    new ColumnInfo() { Name = "address", Type = "varchar", Description = "住所" },
                    new ColumnInfo() { Name = "created_date", Type = "date" },
                }
        };

        // 具象型で受けるとCS1061エラーが発生するため、インターフェースで受ける
        // インターフェースなので、override指定しなくてもTextTemplate側のTransformTextが呼ばれる
        ITemplate template = new TextTemplate(typeDef, "MyNameSpace", table);

        // 実際はファイル ストリームに書き出す
        File.WriteAllText(Path.Combine("./Output", "Test.cs"), template.TransformText());
    }
}
