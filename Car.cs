using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Constructors__Methods__and_Overloading
{
    public class Car
    {
        //creat field;
        string _Make;
        string _Model;
        int _Year;
        int _Mileage;

        public Car()//creat a defult constructor
        {
            _Make = "unassigned";//assign values to make and model, didn't assign the value for year and mileage, because the default values is 0;
            _Model = "unassigned";
        }

        public Car(string make, string model)//creat a constructor with two arguments
        {
            _Make = make;
            _Model = model;
        }

        public Car(string make, string model, int year, int mileage)//creat a constructor with three arguments
        {
            _Make = make;
            _Model = model;
            _Year = year;
            _Mileage = mileage;
        }

        public override string ToString() //use override to display all the information
        {
            return $"Year: {_Year}  Make: {_Make}  Model: {_Model}  Mileage: {_Mileage}";
        }
    }
}
