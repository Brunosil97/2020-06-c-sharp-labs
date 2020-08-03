using System;

namespace lab_30_oop_events
{
    class Program
    {
        static void Main(string[] args)
        {
            //Goal : annual event (triggered by calendar) - have a birthday party
            var james = new Child("james");

            //events ==> not reachable externally, have to call from method within the class
            for (int i = 0; i < 20; i++)
            {
                james.AnotherYearOlder();
            }
        }
    }

    class Child
    {
        delegate void BirthdayDelegate(int age);
        event BirthdayDelegate BirthdayEvent;

        public Child(string name)
        {
            //new person allocate name but age = 0
            this.Name = name;
            this.Age = 0;

            //fill event
            BirthdayEvent += Celebrate; // event no longer null
        }
        public string Name { get; set; }
        public int Age { get; set; }

        void Celebrate(int age)
        {
            Console.WriteLine($"Congratulations !! You have reached the age of {age}");
        }

        public void AnotherYearOlder()
        {
            this.Age++;
            BirthdayEvent(this.Age);
        }
    }
}
