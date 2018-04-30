using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            int[] prim = new int[9999899] ;
            prim[0] = 2;
            int jelenlegdb = 1;
            int osszdb = 0;
            int sz = 0;
            int _osszdb = 0;

                for (int i = 3; ; i++)
                {
                    for (int j = 0; j <= osszdb; j++)

                            if (i % prim[j] != 0)
                            {
                                
                                sz++;
                                if (sz == (osszdb + 1))
                                {
                                    prim[osszdb + 1] = i;
                                    //osszdb = jelenlegdb - 1;

                                    Console.WriteLine(i);
                                    jelenlegdb++;
                                    _osszdb = 1;
                                    break;
                                }

                            }
                                
                        else
                        { break; }
                    osszdb += _osszdb;
                    _osszdb = 0;
                    sz = 0;
                }
        }
    }
}
