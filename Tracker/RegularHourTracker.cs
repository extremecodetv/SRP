using System;

namespace SRP.Tracker
{
    /// <summary>
    /// Класс, для расчета коэффициента обязательных часов работы сотрудника
    /// </summary>
    class RegularHourTracker : IHourTracker
    {
        private Employee _employee;

        public RegularHourTracker(Employee employee)
        {
            _employee = employee;
        }

        /// <summary>
        /// Use Employee Data for Tracking operations
        /// </summary>
        public int Track()
        {
            throw new NotImplementedException();
        }
    }
}
