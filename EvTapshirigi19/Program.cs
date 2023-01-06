namespace EvTapshirigi19
{
    internal class Program
    {
        static void Main(string[] args)
        {   //ededlerin ededi ortasini tapmaq
            
            Console.Write("Massivin uzunlugunu daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
         
            int sum = 0;
       

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]= ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0 ; i < arr.Length; i++)
            {
                sum += arr[i];
                        
            }          
                int edediorta = sum / arr.Length;
                Console.WriteLine(edediorta);
               
        }
    }
}
