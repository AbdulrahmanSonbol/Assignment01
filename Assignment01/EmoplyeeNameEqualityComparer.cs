//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment01
//{
//    internal class EmoplyeeNameEqualityComparer : IEqualityComparer<Employee>
//    {
//        public bool Equals(Employee? emp01, Employee? emp02)
//        {
//            if (ReferenceEquals(emp01, emp02)) return true;
//            if (emp01 == null || emp02 == null ) return false;
//            return string.Equals(emp01.Name, emp02.Name, StringComparison.OrdinalIgnoreCase);
//        }

//        public int GetHashCode([DisallowNull] Employee emp)
//        {
//           return emp.Name is null? 0 : StringComparer.OrdinalIgnoreCase.GetHashCode(emp.Name);   
//        }
//    }
//}
