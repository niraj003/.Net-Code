using System;
class Program {
  static void Main() {
    SalaryDetails managerSalary = new SalaryDetails();
    Manager manager = new Manager(101, "John", 5, "ABC Corp", 40, "123-456-7890", managerSalary, "Sales", 5000);
    manager.CalculateSalary();
    manager.Display();

    SalaryDetails associateSalary = new SalaryDetails();
    Associate associate = new Associate(102, "Alice", 3, "XYZ Corp", 25, "987-654-3210", associateSalary, 101, 2, new DateTime(2023, 12, 31), 'A');
    associate.RenewContract();
    associate.CalculateSalary();
    associate.Display();
  }
}