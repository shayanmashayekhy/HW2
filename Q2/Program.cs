Main();
static void Main()
{
  string str,str1;
  int l = 0;
  int l2 = 0;
  int Count = 0;
  char ch;
  char[] arr,arr1;

  Console.WriteLine("Input the string 1 : ");
  str = Console.ReadLine();
  Console.WriteLine("Input the string 2 : ");
  str1 = Console.ReadLine();

  Console.WriteLine("The characters of the string are  :  ");
    while (l <= str.Length - 1)
    {
        Console.Write("{0} ", str[l]);
        l++;
    }
    Console.WriteLine();
    while (l2 <= str1.Length - 1)
    {
        Console.Write("{0} ", str1[l2]);
        l2++;

    }


}












        
    
