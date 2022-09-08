class MoneyCon{
    public static string getmoney()
    {
        Console.Write("Get Money : ");
        return Console.ReadLine();
    }
     public static double  convertmoneytodouble(string getmoney)
    {
        if (double.TryParse(getmoney,out double onlynum2))
        {
            return onlynum2;
        }
        throw new Exception("Please put just number ");
    }
    
    public void Convertmoney(double Moneyex)
    { 
        double bank1000,remain1000,bank500,remain500,demical;
        double bank100,remain100,bank50,remain50,coin20,remain20,coin10,remain10,coin2,remain2,coin1,remain1;
        demical = Moneyex % 1; //0.25
        Moneyex = Moneyex - demical; //5120
        
        bank1000 = Moneyex /1000;
        remain1000 = Moneyex % 1000;
        Console.WriteLine("Bank 1000: {0}",Convert.ToInt32(bank1000));
     

        bank500 = remain1000 /500;
        remain500= remain1000 %500;
         Console.WriteLine("Bank 500: {0}",Convert.ToInt32(bank500));
      

        bank100 = remain500 /100;
        remain100 = remain500 % 100;
        Console.WriteLine("Bank 100: {0}",Convert.ToInt32(bank100));
        

        bank50 = remain100 / 50;
        remain50 = remain100 % 50;
         Console.WriteLine("Bank 50: {0}",Convert.ToInt32(bank50));
       

        coin20 = remain50/ 20;
        remain20 = remain50 % 20;
         Console.WriteLine("Coin 20: {0}",Convert.ToInt32(coin20));
       

        coin10 = remain20/ 10;
        remain10 = remain20 % 10;
         Console.WriteLine("Coin 10: {0}",Convert.ToInt32(coin10));
      

         coin2 = remain10/2;
        remain2 = remain10 % 2;
         Console.WriteLine("Coin 2: {0}",Convert.ToInt32(coin2));
 

          coin1 = remain2/1;
        remain1 = remain2 % 1;
         Console.WriteLine("Coin 1: {0}",Convert.ToInt32(coin1));
  

        //demical
        double coin050,remain050,coin025,remain025;
        
        coin050 = 0.5/demical;
        remain050 = coin050 % 0.5;
         Console.WriteLine("Coin 0.50: {0}",Convert.ToInt32(coin050));
         
         coin025 = 0.25/demical;
          Console.WriteLine("Coin 0.25: {0}",Convert.ToInt32(coin025));
         


    }
}