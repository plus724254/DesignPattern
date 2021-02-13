using ObserverPattern.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Model.BodyCheckup
{
    public class BMI : Subscriber<BodyInformationDTO>
    {
        public override void OnCompleted()
        {
            Console.WriteLine($"BMI檢查結束");
            UnSubscribe();
        }

        public override void OnNext(BodyInformationDTO bodyInformation)
        {
            var BMI = bodyInformation.Weight / Math.Pow(bodyInformation.Height / 100, 2);
            if (BMI >= 18.5 && BMI < 24)
            {
                Console.WriteLine($"{bodyInformation.Name} BMI為正常");
            }
            else
            {
                Console.WriteLine($"{bodyInformation.Name} BMI為異常");
            }
        }
    }
}
