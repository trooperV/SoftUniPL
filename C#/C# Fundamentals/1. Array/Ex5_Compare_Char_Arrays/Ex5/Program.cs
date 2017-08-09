using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr11 = Console.ReadLine();
            string arr22 = Console.ReadLine();

            List<char> result = arr11.ToList();
            result.RemoveAll(c => c == ' ');
            arr11 = new string(result.ToArray());
            char[] arr1 = arr11.ToCharArray();

            
            List<char> result2 = arr22.ToList();
            result2.RemoveAll(c => c == ' ');
            arr22 = new string(result2.ToArray());
            char[] arr2 = arr22.ToCharArray();


            for (int i = 0; i < (arr1.Length > arr2.Length ? arr2.Length : arr1.Length ); i++)
            {
                if(arr1[i] == arr2[i])
                {
                    if(i == (arr1.Length > arr2.Length ? arr2.Length : arr1.Length) - 1)
                    {
                        if (arr1.Length < arr2.Length)
                        {
                            Console.WriteLine(string.Join("", arr1));
                            Console.WriteLine(string.Join("", arr2));
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", arr2));
                            Console.WriteLine(string.Join("", arr1));
                        }
                        break;
                    }

                }else if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr1));
                    break;
                }
                else
                {
                    Console.WriteLine(string.Join("", arr1));
                    Console.WriteLine(string.Join("", arr2));
                    break;
                }
            }
        }
    }
}
