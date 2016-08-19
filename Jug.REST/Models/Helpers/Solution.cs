using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Jug.REST.Models.Helpers
{
    public static class Solution
    {
        public static bool IsSolutionPossible(Jug A, Jug B, int required)
        { 
            return (required % GetGCD(A.Limit, B.Limit) == 0);
        }

        public static int GetGCD(int n, int m)
        {
            if (m <= n && n % m == 0)
                return m;
            if (n < m)
                return GetGCD(m, n);
            else
                return GetGCD(m, n % m);
        }
        public static Result Solve(Jug A, Jug B, int required)
        {
            Result r = new Helpers.Result();
            while (A.CurrentLevel != required && B.CurrentLevel != required)
            {
                if (A.IsEmpty())
                {
                    A.Fill();
                    r.Status.Add(String.Format("Filling A : ({0} , {1})", A.CurrentLevel.ToString(), B.CurrentLevel.ToString()));
                    Debug.Write("Filling A - Current : " + A.CurrentLevel +  B.CurrentLevel);
                }
                if (A.CurrentLevel != required || B.CurrentLevel != required)
                {
                    A.TransferContent(B);
                    r.Status.Add(String.Format("Transferring : ({0},{1})", A.CurrentLevel, B.CurrentLevel));
                }
                else
                    break;
                //Debug.WriteLine("\n Transferring  - Current : ({0},{1})", A.CurrentLevel, B.CurrentLevel);
                if (A.CurrentLevel != required & B.CurrentLevel != required)
                {
                    if (B.IsFull())
                    {
                        B.Empty();
                        r.Status.Add(String.Format("Emptying B  : ({0},{1})", A.CurrentLevel, B.CurrentLevel));
                        // Debug.WriteLine(/*"\n Emptying B  - Current : ({0},{1})", A.CurrentLevel, B.CurrentLevel*/);

                    }
                }
                else
                    break;
               // Thread.Sleep(1000);
            }
            Console.WriteLine("Done");

            return r;
        }

    }
}