using System;
namespace Assignment_1
{
    // class created
    public class Employee{
        private int _Id;
        private string _Name;
        private string _DepartmentName;
     
     //constructor created
        public Employee(int Id, string Name, string DepartmentName){
            this._Id = Id;
            this._Name = Name;
            this._DepartmentName = DepartmentName;
        }
        //method created
        public int getId(){
            return this._Id;
        }
        public string getName(){
            return this._Name;
        }
        public string getDepartmentName(){
            return this._DepartmentName;
        }
        
    }
}