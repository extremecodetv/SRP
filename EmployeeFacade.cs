using SRP.Reporter;
using SRP.PayCalculator;

namespace SRP
{
    class EmployeeFacade
    {
        private Employee _employee;
        private IReporter _reporter;
        private IPayCalculator _payCalculator;

        public EmployeeFacade(Employee employee)
        {
            _employee = employee;

            /**
             * Используем "Стратегию" для применения SRP
             *
             * За различные обязанности, отвечают разные классы.
             * Изменение в одном из них, не повредит работе другого.
             * 
             * P.S.
             * Для тех, кто в теме - тут можно (нужно) использовать Dependency Injection
             */ 
            _reporter = new RegularReporter(employee);
            _payCalculator = new ExtraPayCalculator(employee);
        }

        public Employee GetEmployee()
        {
            return _employee;
        }

        public int GetPay()
        {
            return _payCalculator.Get();
        }

        public string GetReport()
        {
            return _reporter.Get();
        }
    }
}
