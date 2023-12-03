using OppConcepts;
using OppConcepts.Logic;

try
{
	//Employee employee1 = new SalaryEmployee() { Id = 1, Firstname = "Ahmed", Lastname = "Almershady", Borndate = new(2000, 10, 12),
	//	Hiredate = new(2001, 10, 12), IsActive = true , salary=8000000
 //   };
 //   Employee employee2 = new HourlyEmployee()
 //   {
 //       Id = 2,
 //       Firstname = "Ali",
 //       Lastname = "mohammad",
 //       Borndate = new(1990, 10, 12),
 //       Hiredate = new(2001, 10, 12),
 //       IsActive = true,
 //       HourValue = 2000,
 //       WorkingHour = 7.5f,
 //   };
 //   Employee employee3 = new CommisionEmployee()
 //   {
 //       Id = 3,
 //       Firstname = "saad",
 //       Lastname = "emplyee3",
 //       Borndate = new(1995, 10, 12),
 //       Hiredate = new(2010, 10, 12),
 //       IsActive = true,
 //      CommisionPercentage = 5,
 //      Sales = 5000,
 //   };
 //   Employee employee4 = new BaseCommissionemployee()
 //   {
 //       Id = 4,
 //       Firstname = "saad",
 //       Lastname = "emplyee3",
 //       Borndate = new(1995, 10, 12),
 //       Hiredate = new(2010, 10, 12),
 //       IsActive = true,
 //       CommisionPercentage = 8,
 //       Sales = 9000,
 //       Salary=600000,
 //   };
 //   decimal payrole = 0;
 //   Employee[] employees=new Employee[] { employee1, employee2,employee3, employee4 };
 //   foreach (Employee employee in employees)
 //   {
 //       Console.WriteLine(employee);        
 //       payrole += employee.GetValuatorPay();
 //   }
 //   Console.WriteLine("====================");
 //   Console.WriteLine($"===================={payrole}");
 //   Invoice invoice1 = new Invoice()
 //   {
 //       Id = 1230,
 //       Description = "one invoice",
 //       Price = 7000,
 //       Quantity = 9,
 //   };
 //   Invoice invoice2 = new Invoice()
 //   {
 //       Id = 1231,
 //       Description = "second invoice",
 //       Price = 4000,
 //       Quantity = 11,
 //   };
 //   Invoice invoice3 = new Invoice()
 //   {
 //       Id = 1232,
 //       Description = "third invoice",
 //       Price = 6000,
 //       Quantity = 13,
 //   };
 //   Invoice[] invoices = new Invoice[] { invoice1 , invoice2 , invoice3};
 //   decimal totalInvoice = 0;
 //   foreach (Invoice invoice in invoices)
 //   {
 //       Console.WriteLine(invoice);
 //       totalInvoice += invoice.GetValuatorPay();
 //   }
 //   Console.WriteLine($"===================={totalInvoice,20:C2}");

    MyArray array = new(4);
	array.fill(1,3);

    Console.WriteLine(array);
	Console.WriteLine("------------");

    var Mostepeater = array.GetMosterepeated();
   Mostepeater.sort();
    Console.WriteLine(Mostepeater);
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}

