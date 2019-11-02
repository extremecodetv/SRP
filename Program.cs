
namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee()
            {
                Age = 20,
                Name = "Denis Petroff"
            };

            var employeeFacade = new EmployeeFacade(employee);

            /**
             * Используем ExtraPayCalulator для расчета зарплаты на часах при переработке
             */ 
            employeeFacade.GetPay();

            /**
             * Используем RegularReporter для создания отчетов на обязательных часах
             */ 
            employeeFacade.GetReport();
        }
    }
}
