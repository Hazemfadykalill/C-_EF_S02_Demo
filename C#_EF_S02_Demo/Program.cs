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
            //var emp = new Employee() { Name = "Mohamed", Salary = 14000, Address = "Cairo", Age = 30 };
            //Console.WriteLine(DataBaseObject.Entry<Employee>(emp).State);//Detached
            ////DataBaseObject.Add(emp);
            ////Or And This Is Best
            //DataBaseObject.Employees.Add(emp);
            //Console.WriteLine(DataBaseObject.Entry<Employee>(emp).State);//Added But Not Add IN Database
            //var Result = DataBaseObject.SaveChanges();//11
            //Console.WriteLine(Result);
            //Console.WriteLine(DataBaseObject.Entry<Employee>(emp).State);//Unchanged
            //emp.Name = "Omar";
            //Console.WriteLine(DataBaseObject.Entry<Employee>(emp).State);//Modified




            #endregion

            #region Read || Select || Retrieve
            // DataBaseObject.Employees ===> Sequence
            //Where(Id => Id.Id == 40) ===>LinQ
            // Read || Select || Retrieve is Sequence.LinQ
            //var EmpId_40 = DataBaseObject.Employees.Where(Id => Id.Id == 40);//Id : 40 :: Name : Mohamed :: Age : 30 :: Salary : 14000 : Address : Cairo
            //var EmpId_40 = DataBaseObject.Employees; //Id : 10 :: Name : Hazem::Age : 15 :: Salary : 20000 : Address: Cairo
            //                                         //Id : 20 :: Name : Fady::Age : 20 :: Salary : 3000 : Address: Alex
            //                                         //Id : 30 :: Name : Mohamed::Age : 30 :: Salary : 14000 : Address: Cairo
            //                                         //Id : 40 :: Name : Mohamed::Age : 30 :: Salary : 14000 : Address: Cairo
            //                                         //Id : 50 :: Name : Mohamed::Age : 30 :: Salary : 14000 : Address: Cairo
            //                                         //Id : 60 :: Name : Mohamed::Age : 30 :: Salary : 14000 : Address: Cairo
            //foreach (var item in EmpId_40)          
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Update

            //var EmpId_40 = DataBaseObject.Employees.FirstOrDefault(x=>x.Id==40);//Id : 40 :: Name : Mohamed :: Age : 30 :: Salary : 14000 : Address : Cairo

            //Console.WriteLine(DataBaseObject.Entry(EmpId_40).State); //Unchanged

            ////Update
            //EmpId_40.Name = "Omar Ali"; 

            //Console.WriteLine(DataBaseObject.Entry(EmpId_40).State);//Modified

            //Console.WriteLine(EmpId_40);                                        //Id : 40 :: Name : Omar Ali :: Age : 30 :: Salary : 14000 : Address : Cairo
            //DataBaseObject.SaveChanges();
            //Console.WriteLine(DataBaseObject.Entry(EmpId_40).State);//Unchanged
            #endregion

            #region Delete || Remove
            //var Result=DataBaseObject.Employees.FirstOrDefault(E=>E.Id==40);
            //Console.WriteLine(DataBaseObject.Entry(Result).State);  //Unchanged
            //DataBaseObject.Employees.Remove(Result);
            //Console.WriteLine(DataBaseObject.Entry(Result).State);  //Deleted
            //DataBaseObject.SaveChanges();   
            //Console.WriteLine(DataBaseObject.Entry(Result).State);  //Detached

        
            #endregion





            #endregion
        }
    }
}
