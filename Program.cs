// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите числа через пробел ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int Kol(int[] array)
{
  int j = 0;

   for (int i = 0; i < array.Length; i++)
   {
       if ( array[i] > 0) j = j + 1; 
   }
  return j;
}


Console.WriteLine($"Количетво элементов больше 0: {Kol(arr)}");
