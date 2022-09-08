using System.Dynamic;
// See https://aka.ms/new-console-template for more information

class Program{
    
    
    static void Main(string[]args)
    {   
       /* putinfo info = new putinfo(); 
        string Nameshop = putinfo.getnameshop();
        string Tax = putinfo.getTaxnum();
        long converttax = putinfo.converttaxtolong(Tax);
        string nameofowner = putinfo.getOwnername();
        string Registerednumber = putinfo.getRegisValue();
        long convertregis = putinfo.convertregistolong(Registerednumber);
        showinfoshop infoshop = new showinfoshop();
        showinfoshop.Showinformation(Nameshop,Tax,nameofowner,Registerednumber);
        */
        //Converting money
         MoneyCon showconvert = new MoneyCon();
        string  Money = putinfo.getmoney();
        double convertmoney = putinfo.convertmoneytodouble(Money);
       
        showconvert.Convertmoney(convertmoney);
    }
}
