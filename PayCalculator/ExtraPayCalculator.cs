using System;
using SRP.Tracker;

namespace SRP.PayCalculator
{
    /// <summary>
    /// Класс, для расчета зарплаты сотрудника при переработках
    /// </summary>
    class ExtraPayCalculator : IPayCalculator
    {
        public Employee _employee;
        public IHourTracker _tracker;

        public ExtraPayCalculator(Employee employee)
        {
            _employee = employee;
            _tracker = new ExtraHourTracker(employee);
        }

        public int Get()
        {
            throw new NotImplementedException();
        }
    }
}
