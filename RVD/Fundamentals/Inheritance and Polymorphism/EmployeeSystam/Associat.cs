using System;
namespace employeesysteam{
class Associate : Employee {
  public int Supervisor;
  public int Grade;
  public DateTime ContractEndDate;
  public char PerformanceGrade;

  public Associate(int employeeId, string name, double experience, string company, int age, string mobileNumber, SalaryDetails salaryDetailsObject, int supervisor, int grade, DateTime contractEndDate, char performanceGrade) : base(employeeId, name, experience, company, age, mobileNumber, salaryDetailsObject) {
    Supervisor = supervisor;
    Grade = grade;
    ContractEndDate = contractEndDate;
    PerformanceGrade = performanceGrade;
  }

  public void RenewContract() {
    TimeSpan remainingDays = ContractEndDate - DateTime.Today;
    int renewDays = 0;
    switch(PerformanceGrade) {
      case 'A':
        renewDays = 300;
        break;
      case 'B':
        renewDays = 150;
        break;
      case 'C':
        renewDays = 75;
        break;
    }
    if (remainingDays.Days <= 10) {
      ContractEndDate = ContractEndDate.AddDays(renewDays);
    }
  }

  public void CalculateSalary() {
    SalaryDetailsObject.BasicPay = 10000;
    switch (Grade) {
      case 1:
        SalaryDetailsObject.Salary = SalaryDetailsObject.BasicPay + (0.20 * SalaryDetailsObject.BasicPay) + 1600;
        break;
      case 2:
        SalaryDetailsObject.Salary = SalaryDetailsObject.BasicPay + (0.15 * SalaryDetailsObject.BasicPay) + 1000;
        break;
      case 3:
        SalaryDetailsObject.Salary = SalaryDetailsObject.BasicPay + (0.10 * SalaryDetailsObject.BasicPay) + 500;
        break;
    }
  }

  public void Display() {
    base.Display();
    Console.WriteLine("Supervisor: " + Supervisor);
    Console.WriteLine("Grade: " + Grade);
    Console.WriteLine("Contract End Date: " + ContractEndDate);
    Console.WriteLine("Performance Grade: " + PerformanceGrade);
  }
}
}
