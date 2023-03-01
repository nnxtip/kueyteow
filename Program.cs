class Program{
    static void Main(string[] Args) {
        int odd = 0;

        while(true) {
            int x = int.Parse(Console.ReadLine());
        

        if (x % 2 == 0) {
            Console.WriteLine("even");
            odd = 0;
            
        } else {
            if (odd ==1) {
                break;
            } else {
                Console.WriteLine("-1");
                odd = 1;
            }
        }
    }
}
}
        
            
            
                
            

        

    

