using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CLsTooOldException:Exception //Exception is the super class of all sub class exception
    {
        public CLsTooOldException(string message):base(message)
        {
            
        }
    }
    internal class CLsTooYoungException : Exception
    {
        public CLsTooYoungException(string message) : base(message)
        {

        }
    }
    class ClsAge
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age >= 60)
                {
                    throw new CLsTooOldException("Age should not be 60 or more");
                }
                else if (age <= 20)
                {
                    throw new CLsTooYoungException("Age should not be 20 or below");
                }
                else
                {
                    Console.WriteLine("You are eligible to take the policy");
                }
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
            }   
            /*            catch(CLsTooOldException msg)
                        {
                            Console.WriteLine(msg);
                        }
                        catch (CLsTooYoungException msg)
                        {
                            Console.WriteLine(msg);
                        }*/
        }
    }
}
