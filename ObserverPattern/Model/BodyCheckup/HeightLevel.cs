using ObserverPattern.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Model.BodyCheckup
{
    public class HeightLevel : Subscriber<BodyInformationDTO>
    {
        private readonly double _maleAverageHight;
        private readonly double _femaleAverageHight;
        public HeightLevel()
        {
            _maleAverageHight = 170;
            _femaleAverageHight = 160;
        }

        public override void OnCompleted()
        {
            Console.WriteLine($"平均身高檢查結束");
            UnSubscribe();
        }

        public override void OnNext(BodyInformationDTO bodyInformation)
        {
            if (bodyInformation.IsMale)
            {
                if(_maleAverageHight > bodyInformation.Height)
                {
                    Console.WriteLine($"{bodyInformation.Name} 身高小於男性平均水準");
                }
                else
                {
                    Console.WriteLine($"{bodyInformation.Name} 身高達到男性平均水準");
                }
            }
            else
            {
                if (_femaleAverageHight > bodyInformation.Height)
                {
                    Console.WriteLine($"{bodyInformation.Name} 身高小於女性平均水準");
                }
                else
                {
                    Console.WriteLine($"{bodyInformation.Name} 身高達到女性平均水準");
                }
            }
        }
    }
}
