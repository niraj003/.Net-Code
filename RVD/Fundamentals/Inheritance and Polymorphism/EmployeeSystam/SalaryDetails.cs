internal class SalaryDetails
{
}using System;

class SalaryDetails {
  public double Salary;
  public double BasicPay;
  public double HRA;
  public double TA;

  public SalaryDetails(double basicPay) {
    BasicPay = basicPay;
  }

  public void Compute() {
    HRA = BasicPay * 0.3;
    TA = 1600;
    Salary = BasicPay + HRA + TA;
  }
}