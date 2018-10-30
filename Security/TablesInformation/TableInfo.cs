using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.TablesInformation
{
    class TableInfo
    {
        private String name;
        private String[] colomnsNames;

        public TableInfo(string name, string[] colomnsNames)
        {
            this.name = name;
            this.colomnsNames = colomnsNames;
        }

        public string Name { get => name; }
        public string[] ColomnsNames { get => colomnsNames; }
    }
}
