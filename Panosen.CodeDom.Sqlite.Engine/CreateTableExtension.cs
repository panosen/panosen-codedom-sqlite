using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Sqlite.Engine
{
    /// <summary>
    /// CreateTableExtension
    /// </summary>
    public static class CreateTableExtension
    {
        /// <summary>
        /// TransformText
        /// </summary>
        /// <returns></returns>
        public static string TransformText(this CreateTable createTable)
        {
            var builder = new StringBuilder();

            new CreateTableEngine().Generate(createTable, builder);

            return builder.ToString();
        }
    }
}
