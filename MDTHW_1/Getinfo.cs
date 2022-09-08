class putinfo{
    public static string getnameshop()
    {
        Console.Write("Get Name : ");
        return Console.ReadLine();
    }
     public static string getTaxnum()
    {
        Console.Write("Get Taxnum : ");
       return Console.ReadLine();
    }
    public static long  converttaxtolong(string getTaxnum)
    {
        if (long.TryParse(getTaxnum,out long onlynum))
        {
            return onlynum;
        }
        throw new Exception("Please put just number ");
    }
    public static string getOwnername()
    {
        Console.Write("Get Ownername : ");
        return Console.ReadLine();
    }
    
    public static string getRegisValue()
    {
        Console.Write("Get Registered Value : ");
        return Console.ReadLine();
    }
    public static long  convertregistolong(string getValueregis)
    {
        if (long.TryParse(getValueregis,out long onlynum1))
        {
            return onlynum1;
        }
        throw new Exception("Please put just number ");
    }
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
    
}