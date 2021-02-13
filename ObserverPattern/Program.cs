using ObserverPattern.DTO;
using ObserverPattern.Model;
using ObserverPattern.Model.BodyCheckup;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var bodyInfomationPublisher = new Publisher<BodyInformationDTO>();

            var BMICheckup = new BMI();
            var freeMealCheckup = new FreeMeal();
            var heightLevelCheckup = new HeightLevel();

            BMICheckup.Subscribe(bodyInfomationPublisher);
            freeMealCheckup.Subscribe(bodyInfomationPublisher);
            heightLevelCheckup.Subscribe(bodyInfomationPublisher);

            bodyInfomationPublisher.Notification(new BodyInformationDTO() { Name = "Leo", Age = 24, Height = 170, Weight = 70, IsMale = true });
            bodyInfomationPublisher.Notification(new BodyInformationDTO() { Name = "Mendy", Age = 26, Height = 162, Weight = 50, IsMale = false });
            bodyInfomationPublisher.Notification(new BodyInformationDTO() { Name = "Lucy", Age = 20, Height = 152, Weight = 42, IsMale = false });
            bodyInfomationPublisher.Notification(new BodyInformationDTO() { Name = "Jack", Age = 25, Height = 165, Weight = 80, IsMale = true });

            bodyInfomationPublisher.EndSpread();

        }
    }
}
