using System;
namespace employeesysteam{
  class Manager : Employee {
  public string Department;
  public double SpecialBonus;

  public Manager(int employeeId, string name, double experience, string company, int age, string mobileNumber, SalaryDetails salaryDetailsObject, string department, double specialBonus) : base(employeeId, name, experience, company, age, mobileNumber, salaryDetailsObject) {
    Department = department;
    SpecialBonus = specialBonus;
  }

  public void CalculateSalary() {
    base.CalculateSalary();
    SalaryDetailsObject.Salary += SpecialBonus;
  }

  public void Display() {
    base.Display();
    Console.WriteLine("Department: " + Department);
    Console.WriteLine("Special Bonus: " + SpecialBonus);
  }
}
}
