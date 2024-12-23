namespace PeopleProject
{

    /*
     a.) 
Az osztály tárolja az emberek adatait egy people nevű lista adattagban. A lista adattag 
konstruktor paraméterében, valamint setter segítségével is legyen megadható. Csak egy 
konstruktorral rendelkezzen az osztály, amelyben a lista adattag megadása kötelező. A 
lista lehet üres is, viszont null értéket nem vehet fel. A további függvények ebben a 
listában található adatokkal dolgozzanak. Megvalósítási javaslat: 
• C# nyelv esetén People nevű property, melynek settere publikus, gettere privát. 
Külön adattag létrehozása nem kötelező, használhatóak a C# nyelvi elemei. 
• Java nyelv esetén people privát adattag létrehozása és hozzá publikus setPeople 
függvény létrehozása (lombok használható) 
• JavaScript / TypeScript esetén people privát adattag létrehozása és hozzá publikus 
set property létrehozása. 
b.) getAverageAge() – adja vissza az összes személy átlagéletkorát 
c.) 
getNumberOfStudents() – Adja vissza a tanulók számát. 
d.) getPersonWithHighestScore() – Adja a legtöbb ponttal rendelkező személyt 
e.) 
getAverageScoreOfStudents() – Adja vissza a tanulók átlag pontszámát 
f.) 
getOldestStudent()– Adja vissza a legidősebb tanulót 
g.) isAnyoneFailing()– Adja vissza hogy van-e olyan személy, aki megbukott a teszten 
(kevesebb mint 40 pontot ért el)*/
    public class PersonStatistics
    {
        public List<Person> People { private get; set; }

        public PersonStatistics(List<Person> people)
        {
            if (people == null)
            {
                throw new ArgumentNullException("A people lista nem lehet null",nameof(people));
            }
            this.People = people;
        }

        public double getAverageAge()
        {
            double sum = 0;
            if (People.Count == 0) return 0;
            foreach (Person person in People)
            {
                sum += person.Age;
            }
            return sum / People.Count;
        }

        public int getNumberOfStudents()
        {
            int count = 0;
            foreach (Person person in People)
            {
                if (person.IsStudent)
                {
                    count++;
                }
            }
            return count;
        }

        public Person getPersonWithHighestScore()
        {
            Person highestScorePerson = null;
            foreach (Person person in People)
            {
                if (highestScorePerson == null || person.Score > highestScorePerson.Score)
                {
                    highestScorePerson = person;
                }
            }
            return highestScorePerson;
        }

        public double getAverageScoreOfStudents()
        {
            double sum = 0;
            int count = 0;
            if(People.Count == 0) return 0;
            foreach (Person person in People)
            {
                if (person.IsStudent)
                {
                    sum += person.Score;
                    count++;
                }
            }
            return sum / count;
        }

        public Person getOldestStudent()
        {
            Person oldestStudent = null;
            foreach (Person person in People)
            {
                if (person.IsStudent)
                {
                    if (oldestStudent == null || person.Age > oldestStudent.Age)
                    {
                        oldestStudent = person;
                    }
                }
            }
            return oldestStudent;
        }

        public bool isAnyoneFailing()
        {
            foreach (Person person in People)
            {
                if (person.Score < 40)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
