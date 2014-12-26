using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingClassFullAndReverseName.DLL.DAO
{
    class Name
    {
        public string firstName;
        public string lastName;
        public string middleName;

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();

            char[] cArray = fullName.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;

        }
    }
}
