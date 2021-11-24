class App{
  public static void Main(){
    System.Console.WriteLine(add(1, 2));
    System.Console.WriteLine(sub(1, 2));
  }

  [System.Runtime.InteropServices.DllImport("calc.dll")]
  private static extern int add(int x, int y);
  
  [System.Runtime.InteropServices.DllImport("calc.dll")]
  private static extern int sub(int x, int y);
}