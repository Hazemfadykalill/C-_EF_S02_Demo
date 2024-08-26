using C__EF_S02_Demo.Contexts;
using C__EF_S02_Demo.Entities;

namespace C__EF_S02_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To Interact With Database Should Be Make Object from Database
            // 1 . Try Catch
            //    EFS02Demo DataBaseObject = new EFS02Demo();
            //try
            //{
            //    //Any Statements 
            //}
            //catch
            //{
            //    DataBaseObject.Dispose();
            //}

            // 2 . using (Source)
            //using (EFS02Demo DataBaseObject = new EFS02Demo()) ;

            // 3 . Using
            using EFS02Demo DataBaseObject = new EFS02Demo();
            #region CRUD Operator
            #region 1 Insert || Create
            var emp = new Employee() { Name = "Mohamed", Salary = 14000, Address = "Cairo", Age = 30 };
            Console.WriteLine(DataBaseObject.Entry<Employee>(emp).State);//Detached
            //DataBaseObject.Add(emp);
            //Or And This Is Best
            DataBaseObject.Employees.Add(emp);
            Console.WriteLine(DataBaseObject.Entry<Employee>(emp).State);//Added But Not Add IN Database
            var Result = DataBaseObject.SaveChanges();//11
            Console.WriteLine(DataBaseObject.Entry<Employee>(emp).State);//Unchanged
            Console.WriteLine(Result);
            



            #endregion
            #endregion
        }
    }
}
