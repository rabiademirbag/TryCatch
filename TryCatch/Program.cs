public class Program
{
    public static void Main(string[] args)
    {
        bool isValid = false;
        while (!isValid) {

            try
            {
                Console.WriteLine("Lütfen bir sayı girin: ");
                int number=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayının karesi: "+number*number);
                isValid = true;
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Geçersiz giriş!");
            }
            
        }
    }
}
