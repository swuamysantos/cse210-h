using System;
using System.Runtime.CompilerServices;

namespace Employee_demo
{
    public class HourlyEmployee : Employee
    {
        private float _payRate = 0;
        private int _hoursWorked = 0;
        public float GetPayRate()
        {
            return _payRate;
        }
        public void SetPayRate(float payRate)
        {
            _payRate = payRate;
        }
        public void GetHoursWorked()
        {
            return _hoursWorked;
        }
        public int GetHoursWorked()
        {
            return _hoursWorked;
        }
        public void SetHoursWorked(int hoursWorked)
        {
            _hoursWorked = hoursWorked;
        }
    }
}    
