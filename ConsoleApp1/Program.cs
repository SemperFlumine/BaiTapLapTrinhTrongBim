using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai bao h - k  
            int h = 0;
            int k = 0;
            int i = 0;

            int[] A = new int[i];
            int[] B = new int[h];
            int[] C = new int[k];

            // vong lap dong thoi khai bao i 
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<n; i++)
            {

                if (A[i] > 0) 
                B[h] = A[i];
                h++;
            
                else if (A[i] <= 0)
            {
                C[k] = A[i];
                k++;
                
            }
            else 
                    Console.ReadLine();









        }
    }
}
