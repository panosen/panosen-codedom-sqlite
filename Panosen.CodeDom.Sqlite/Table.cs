using System;
using System.Collections.Generic;
using System.Text;

namespace Panosen.CodeDom.Sqlite
{
    /// <summary>
    /// SqliteTable
    /// </summary>
    public class Table
    {
        /// <summary>
        /// 表名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// FieldList
        /// </summary>
        public List<Field> FieldList { get; set; }
    }
}
