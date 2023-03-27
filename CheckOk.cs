using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CheckOk
    {
        public CheckOk() {
        
           

        }    
        public static string CheckOkFn(string res)
        {

            while (res.Contains("ok"))
            {
                for(int i=0;i<res.Length;i++)
                {
                    if (res[i] == 'o')
                    {
                        if(i+1 < res.Length && res[i+1] == 'k')
                        {
                            res = res.Substring(0, i) + res.Substring(i + 2);
                            CheckOkFn(res);
                            break;
                        }
                    }
                }
            }
            return res;

        }
    }
}
