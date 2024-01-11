using System;

namespace HelloWorld
{

  class MyArr{
    int[,]arr = new int[3,3] ;
    public MyArr(){
    //   arr=  { {1, 4, 2}, {3, 6, 8} ,{9,2,5}};
    for (int i = 0; i < arr.GetLength(0); i++) 
    { 
      for (int j = 0; j < arr.GetLength(1); j++) 
      { 
        arr[i, j]=Convert.ToInt32(Console.ReadLine());
      } 
    
    }}
    
public override string ToString()
{
  string str="Array Metrix\n\n";
  for (int i = 0; i < arr.GetLength(0); i++) 
  { 
    for (int j = 0; j < arr.GetLength(1); j++) 
    { 
      str+= arr[i, j]+" "; 
    } 
    str+= "\n";
  }  
  return str;
}
    
  }
  class Program
  {
    static void Main(string[] args)
    {
      MyArr a1 = new MyArr();
      Console.WriteLine(a1);
    }
  }
}
