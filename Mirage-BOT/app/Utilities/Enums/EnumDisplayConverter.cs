using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirage_BOT.app.Utilities.Enums
{
    class EnumDisplayConverter
    {
        public static string GetEnumValueAsStrings(Enum value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            return value.ToString().Replace('_', ' ');
        }
        public static string[] GetEnumValuesAsStrings<T>(string separator = " ") where T : Enum
        {
            return Enum.GetNames(typeof(T))
                       .Select(name => name.Replace("_", separator))
                       .ToArray();
        }
    }
}
