using System;

class Employee {
  public int EmployeeId;
  public string Name;
  public double Experience;
  public string Company;
  public int Age;
  public string MobileNumber;
  public SalaryDetails SalaryDetailsObject;

  public Employee(int employeeId, string name, double experience, string company, int age, string mobileNumber, SalaryDetails salaryDetailsObject) {
    EmployeeId = employeeId;
    Name = name;
    Experience = experience;
    Company = company;
    Age = age;
    MobileNumber = mobileNumber;
    SalaryDetailsObject = salaryDetailsObject;
  }

  public void CalculateSalary() {
    SalaryDetailsObject.Compute();
  }

  public void Display() {
    Console.WriteLine("Employee ID: " + EmployeeId);
    Console.WriteLine("Name: " + Name);
    Console.WriteLine("Experience: " + Experience + " years");
    Console.WriteLine("Company: " + Company);
    Console.WriteLine("Age: " + Age);
    Console.WriteLine("Mobile Number: " + MobileNumber);
    Console.WriteLine("Salary: " + SalaryDetailsObject.Salary);
  }
}