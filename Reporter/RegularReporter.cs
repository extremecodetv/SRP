using System;
using SRP.Tracker;

namespace SRP.Reporter
{
    /// <summary>
    /// Класс, для генерации отчета о работе сотрудника при обязательном кол-ве часов работы
    /// </summary>
    class RegularReporter : IReporter
    {
        private Employee _employee;
        public IHourTracker _tracker;

        public RegularReporter(Employee employee)
        {
            _employee = employee;
            _tracker = new RegularHourTracker(employee);
        }

        public string Get()
        {
            throw new NotImplementedException();
        }
    }
}
