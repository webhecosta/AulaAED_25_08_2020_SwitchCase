using System;

class MainClass {
  public static int Main () {

    double h ; 
    char sexo ;

    Console.Write("Digite a altura >>> ");
    h = double.Parse(Console.ReadLine());
    Console.Write("Digite o sexo >>> ");
    sexo = char.Parse(Console.ReadLine());
  
   //FUNÇÃO CalcPesoSwitchCase
    Console.WriteLine(CalcPesoSwitchCase(h,sexo));
    return 0;
  }

   public static double CalcPesoSwitchCase(double h,char sexo){
   
    switch(sexo){

      case 'H':
        return (72.7 * h) - 58;
       
      case 'M':
        return (62.1 * h) - 44.7;
        
      default:
        return - 1;
       
    }
  }
}