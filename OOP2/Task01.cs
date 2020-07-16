namespace OOP2
{
    // ЗАДАНИЕ 1
    class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
        }

        public virtual string Sound()
        {
            return $"Animal {name} sound";
        }
    }

    class Dog : Animal //наследование
    {
        public Dog(string name) : base(name)
        {
        }

        public override string Sound() // полиморфизм
        {
            return $"Animal {name} sound";
        }
    }

    class LadyWithAnAnimal
    {
        private Animal animal; // композиция
        public LadyWithAnAnimal(Animal animal)
        {
            this.animal = animal;
        }

        public string Sound()
        {
            return "Lady's " + animal.Sound();
        }
    }

    // ЗАДАНИЕ 2

    class Transport
    {
        public virtual void Move(){}

        public virtual void Stop(){}
    }

    class Bus : Transport // расширение - добавляем новые методы
    {
        public void LoadPassengers(){}
    }

    class Vehicle : Transport
    {
        public override void Move(){} // сужение - переопределяем метод родительского класса
    }

    // ЗАДАНИЕ 3
    /* В C# концепция класс-как-модуль, поддерживается, например, с помощью библиотек .dll. Можно скомпилировать даже один класс как библиотеку и в дальнейшем
     * подключать ее в нужных проектах
     */
}
