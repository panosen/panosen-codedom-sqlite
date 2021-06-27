using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Sqlite.Engine
{
    /// <summary>
    /// CreateTableEngine
    /// </summary>
    public class CreateTableEngine
    {
        /// <summary>
        /// Generate
        /// </summary>
        /// <param name="createTable"></param>
        /// <param name="codeWriter"></param>
        public void Generate(CreateTable createTable, CodeWriter codeWriter)
        {
            if (createTable.Table == null)
            {
                return;
            }

            Generate(createTable.Table, codeWriter);
        }

        /// <summary>
        /// Generate
        /// </summary>
        /// <param name="table"></param>
        /// <param name="codeWriter"></param>
        private void Generate(Table table, CodeWriter codeWriter)
        {
            codeWriter.WriteLine($"CREATE TABLE {table.Name} (");

            for (var i = 0; i < table.FieldList.Count; i++)
            {
                var field = table.FieldList[i];

                codeWriter.Write($"    {field.Name} {field.Type}");

                if (field.PK)
                {
                    codeWriter.Write(" PRIMARY KEY");
                }

                if (i < table.FieldList.Count - 1)
                {
                    codeWriter.Write(",");
                }

                codeWriter.WriteLine();
            }

            codeWriter.WriteLine(");");
        }
    }
}
