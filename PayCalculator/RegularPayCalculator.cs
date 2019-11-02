using System;
using SRP.Tracker;

namespace SRP.PayCalculator
{
    /// <summary>
    /// Класс, для расчета зарплаты сотрудника при обязательном кол-ве часов
    /// </summary>
    class RegularPayCalculator : IPayCalculator
    {
        public Employee _employee;
        public IHourTracker _tracker;

        public RegularPayCalculator(Employee employee)
        {
            _employee = employee;
            _tracker = new RegularHourTracker(employee);
        }

        public int Get()
        {
            throw new NotImplementedException();
        }
    }
}
