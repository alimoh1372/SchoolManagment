using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagment.Utility
{
   public static class UsingStringUtility
    {
        public static string RemoveSpecialCharFromString(this string StringText, char charToRemove)
        {
            
                StringText = StringText.Replace(charToRemove.ToString(), String.Empty);
            

            return StringText;
        }
    }
}
