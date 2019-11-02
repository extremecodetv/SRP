using System;

namespace SRP.Tracker
{
    /// <summary>
    /// Класс, для расчета коэффициента часов переработок сотрудника
    /// </summary>
    class ExtraHourTracker : IHourTracker
    {
        private Employee _employee;

        public ExtraHourTracker(Employee employee)
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
