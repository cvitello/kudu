﻿using System;
using System.Threading.Tasks;
using Kudu.Client.Builder;
using Xunit;

namespace Kudu.Client.FunctionalTests
{
    public class InsertTests
    {
        [Fact]
        public async Task Insert()
        {
            using (var client = KuduClient.Build("127.0.0.1:7051"))
            {
                var tableName = Guid.NewGuid().ToString();

                var table = new TableBuilder()
                    .SetTableName(tableName)
                    .SetNumReplicas(1)
                    .AddColumn(column =>
                    {
                        column.Name = "column_x";
                        column.Type = DataType.Int32;
                        column.IsKey = true;
                        column.IsNullable = false;
                        column.Compression = CompressionType.DefaultCompression;
                        column.Encoding = EncodingType.AutoEncoding;
                    })
                    .AddColumn(column =>
                    {
                        column.Name = "column_y";
                        column.IsNullable = true;
                        column.Type = DataType.String;
                        column.Encoding = EncodingType.DictEncoding;
                    });

                var tableId = await client.CreateTableAsync(table);
                Assert.NotEmpty(tableId);

                var openTable = await client.OpenTableAsync(tableName);
                Assert.Equal(tableName, openTable.TableName);
                Assert.Equal(1, openTable.NumReplicas);

                var insert = openTable.NewInsert();
                var row = insert.Row;
                row.SetInt(0, 7);
                row.SetString(1, "test value");

                var result = await client.WriteRowAsync(insert);
                Assert.Empty(result.PerRowErrors);
                Assert.NotEqual(0UL, result.Timestamp);
            }
        }
    }
}
