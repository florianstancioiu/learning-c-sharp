using System.Collections;

namespace LearningCSharp.DerekBanasTutorial
{
    class IEnumerableNotion
    {
        public IEnumerableNotion()
        {
            AnimalFarm myAnimals = new AnimalFarm();

            myAnimals[0] = new Animal2("Wilbur");
            myAnimals[1] = new Animal2("Templeton");
            myAnimals[2] = new Animal2("Gandor");
            myAnimals[3] = new Animal2("Charlotte");


            foreach(Animal2 animal in myAnimals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }

    class Animal2
    {
        public String Name;

        public Animal2(String Name = "No Name")
        {
            this.Name = Name;
        }
    }

    class AnimalFarm : IEnumerable
    {
        private List<Animal2> animalList = new List<Animal2>();

        public AnimalFarm(List<Animal2> animalList)
        {
            this.animalList = animalList;
        }

        public AnimalFarm()
        {
            
        }

        public Animal2 this[int index]
        {
            get
            {
                return (Animal2) animalList[index];
            }

            set
            {
                animalList.Insert(index, value);
            }
        }

        public int Count
        {
            get
            {
                return animalList.Count;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return animalList.GetEnumerator();
        }
    }
}