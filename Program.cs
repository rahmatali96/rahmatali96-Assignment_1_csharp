﻿namespace demos
{
    public class Program{

        static void methodCalled(object sender, string functionName){
            Console.WriteLine("{0} method called",functionName);
        }
        static void Main(string[] args){
            int Id = 0;
            string Name = "";
            string DepartmentName = "";
            Employee emp;
            
            try{
                Console.WriteLine("Enter Your ID: ");
                Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Your Name: ");
                Name = Console.ReadLine();
                if(String.IsNullOrEmpty(Name)){
                    throw new ArgumentException("Name can't be empty");
                }

                Console.WriteLine("Enter Your Department Name: ");
                DepartmentName = Console.ReadLine();
                if(String.IsNullOrEmpty(DepartmentName))
                {
                    throw new ArgumentException("DepartmentName Name can't be empty");
                }
                
                Console.WriteLine("ID: {0}",emp.getId());
                Console.WriteLine("Name:{0}",emp.getName());
                Console.WriteLine("DepartmentName:{0}",emp.getDepartmentName());
                emp.update(201);
                System.Console.WriteLine(emp.getId());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }   
        }
    }
}