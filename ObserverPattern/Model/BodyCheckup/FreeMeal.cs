using ObserverPattern.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Model.BodyCheckup
{
    public class FreeMeal : Subscriber<BodyInformationDTO>
    {
        public override void OnCompleted()
        {
            Console.WriteLine($"免費餐點檢查結束");
            UnSubscribe();
        }

        public override void OnNext(BodyInformationDTO bodyInformation)
        {
            if(bodyInformation.Age < 12 || bodyInformation.Height < 150)
            {
                Console.WriteLine($"{bodyInformation.Name} 符合免費餐點門檻");
            }
            else
            {
                Console.WriteLine($"{bodyInformation.Name} 不符合免費餐點門檻");
            }
        }
    }
}
