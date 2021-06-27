using System;
using System.Collections.Generic;
using System.Text;

namespace Panosen.CodeDom.Sqlite
{
    /// <summary>
    /// Field
    /// </summary>
    public class Field
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// NotNull
        /// </summary>
        public bool NotNull { get; set; }

        /// <summary>
        /// DefaultValue
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// PK
        /// </summary>
        public bool PK { get; set; }
    }
}
