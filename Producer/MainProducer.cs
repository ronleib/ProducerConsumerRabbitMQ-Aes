using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer
{
    public class MainProducer 
    {
        public static void Main(string[] args)
        {
            int temoFlag = 0;
            string flag = "1";
            while (temoFlag == 0)
            {
                if (flag == "2")
                {
                    temoFlag++;
                    Sender.send(flag);
                }
                else
                {
                    DataBild test1 = new DataBild();
                    DataJson testJson = new DataJson(test1);
                    Sender.send(testJson.BeldJsonDataCondition("age"));
                    Console.WriteLine("If you want to send more Click Enter , to exit Click number Enter: 2");
                    flag = Console.ReadLine();
                }
            }
        }
    }
}
