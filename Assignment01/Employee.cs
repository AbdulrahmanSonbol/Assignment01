//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment01
//{
//    internal class Employee : IEquatable<Employee> , IComparable<Employee>, ICloneable
//    {

//        #region note

//        //IEquatable = هل الكائن ده يساوي كائن تاني؟

//        //ICloneable = اعملي نسخة جديدة من الكائن ده.


//        #endregion

//        #region Equals

//        public bool Equals(Employee? employee)
//        {
//            if (employee is not null)
//                return employee.Id == Id && employee.Name == Name && employee.Salary == Salary;
//            else
//                return false;

//        } 
//        #endregion

//        #region Attribute

//        public int Id { get; set; }

//        public string Name { get; set; }

//        public decimal Salary { get; set; }

//        #endregion

//        #region Equals
//        public override bool Equals(Employee? employee)
//        {

           

//            if (employee is not null)
//                return employee.Id == Id & employee.Name == Name & employee.Salary == Salary;
//            else
//                return false;


//            #region Dis
//            //Employee? employee = (Employee?)obj;

//            //if (employee is not null)
//            //    return employee.Id == Id & employee.Name == Name & employee.Salary == Salary;

//            //else 
//            //    return false;

//            //if (obj is Employee employee)
//            //{
//            //    return employee.Id == Id && employee.Name == Name && employee.Salary == Salary;
//            //}
//            //else 
//            //    { return false; } 
//            #endregion

//        }

//        #endregion

//        #region Para const


//        public Employee()
//        {
//            Id = 7;
//            Name = "Abdo";
//            Salary = 210000;
//        }

//        public Employee(int id, string name, decimal salary)
//        {
//            Id = id;
//            Name = name;
//            Salary = salary;
//        }
//        #endregion

//        #region override

//        public override int GetHashCode()
//        {
//            return HashCode.Combine(Id, Name, Salary);
//        }

//        public override string ToString()
//        {
//            return $"Id = {Id}\tNmae = {Name}\tSalary = {Salary}";
//        }



//    #endregion

//        #region CompareTo // sort 

//        public int CompareTo(Employee? emp)
//        {
//            if (this.Salary > emp.Salary)
//                return 1;
//            else if (this.Salary < emp.Salary)
//                return -1;
//            else
//                return 0;


//        }

//        #endregion

//        #region Colne // =

//    public object Clone()
//        {
//            return new Employee()
//            {
//                Id = this.Id,
//                Name = this.Name,
//                Salary = this.Salary,

//            };
//        }

//        #endregion




//    }
//}
