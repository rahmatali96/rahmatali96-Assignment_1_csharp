using System;
namespace Assignment_1
{
    // class created
    public class Employee{
        private int _Id;
        private string _Name;
        private string _DepartmentName;
        public event EventHandler<string> getDetailsCalled ;
     //constructor created
        public Employee(int Id, string Name, string DepartmentName){
            this._Id = Id;
            this._Name = Name;
            this._DepartmentName = DepartmentName;
        }
        //method created
        public int getId(){
            onDetailsCalled("getId()");
            return this._Id;
        }
        public string getName(){
            onDetailsCalled("getName()");
            return this._Name;
        }
        public string getDepartmentName(){
            onDetailsCalled("getDepartmentName()");
            return this._DepartmentName;
        }
        public virtual void onDetailsCalled(string functionName){
            getDetailsCalled?.Invoke(this, functionName);
        
    }
}