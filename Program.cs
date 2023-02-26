// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
  
        static void CracklePop()
        {
                for (int i = 1; i < 100; i++)
                {
                    //Check modulos of 3 and print Crackle
                    if (i % 3 == 0)
                    {
                        System.Console.WriteLine(" Crackle");
                    }
                    //Check modulos of 5 and print Pop
                    if (i % 3 == 0)
                    {
                        System.Console.WriteLine(" Pop");
                    }
                    //Check modulos of 3 and 5 and print CracklePop
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        System.Console.WriteLine(" CracklePo");
                    }
                    if (i % 3 != 0 || i % 5 != 0)
                    {
                        System.Console.WriteLine(i);
                    }
                }

            }
            CracklePop();
    
