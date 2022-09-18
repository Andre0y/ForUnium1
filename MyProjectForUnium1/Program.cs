using System;

namespace MyProjectForUnium
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPeopleInQueue = 100;
            int timeOfWaiting = 10;
            int positionInQueue = 95;
            int totalTimeOfWaiting = timeOfWaiting * positionInQueue;

            Console.WriteLine("Количество человек в очереди: " + totalPeopleInQueue + "," + " Время ожидания: " + timeOfWaiting + " Секунд, " + " Позиция в очереди: " + positionInQueue + "-й, " + "Время ожидания в очереди: " + totalTimeOfWaiting + " Секунд");
        }
    }
}