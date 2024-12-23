using PeopleProject;

namespace TestPeopleProject
{
    public class Tests
    {
        PersonStatistics ps;
        List<Person> Teli = [
            new Person("Joe", 20, true, 90),
            new Person("Jill", 23, true, 75)
        ];
        List<Person> MasikTeli = [
            new Person("Joe", 20, true, 90),
            new Person("Jill", 23, true, 30),
            new Person("Jack", 25, false, 90),
            new Person("Jane", 21, true, 85),
            new Person("Bill", 23, false, 75),
            new Person("Gill", 20, true, 75)
        ];
        List<Person> Ures = new List<Person>();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void PersonStatistics_NullListaval_ArgumentNullExceptiontDob()
        {
            Assert.Throws<ArgumentNullException>(() => new PersonStatistics(null));
        }

        [Test]
        public void PersonStatistics_HelyesInputtal_NemDobExceptiont()
        {
            Assert.DoesNotThrow(() => new PersonStatistics(Teli));
        }

        [Test]
        public void getAverageAge_TeliListaval()
        {
            ps = new PersonStatistics(Teli);
            Assert.That(ps.getAverageAge(), Is.EqualTo(21.5));
        }

        [Test]
        public void getNumberOfStudents_TeliListaval()
        {
            ps = new PersonStatistics(Teli);
            Assert.That(ps.getNumberOfStudents(), Is.EqualTo(2));
        }

        [Test]
        public void getPersonWithHighestScore_TeliListaval()
        {
            ps = new PersonStatistics(Teli);
            Assert.That(ps.getPersonWithHighestScore().Name, Is.EqualTo("Joe"));
        }

        [Test]
        public void getAverageScoreOfStudents_TeliListaval()
        {
            ps = new PersonStatistics(Teli);
            Assert.That(ps.getAverageScoreOfStudents(), Is.EqualTo(82.5));
        }

        [Test]
        public void getOldestStudent_TeliListaval()
        {
            ps = new PersonStatistics(Teli);
            Assert.That(ps.getOldestStudent().Name, Is.EqualTo("Jill"));
        }

        [Test]
        public void isAnyoneFailing_TeliListaval()
        {
            ps = new PersonStatistics(Teli);
            Assert.That(ps.isAnyoneFailing(), Is.EqualTo(false));
        }

        [Test]
        public void getAverageAge_UresListaval()
        {
            ps = new PersonStatistics(Ures);
            Assert.That(ps.getAverageAge(), Is.EqualTo(0));
        }

        [Test]
        public void getNumberOfStudents_UresListaval()
        {
            ps = new PersonStatistics(Ures);
            Assert.That(ps.getNumberOfStudents(), Is.EqualTo(0));
        }

        [Test]
        public void getPersonWithHighestScore_UresListaval()
        {
            ps = new PersonStatistics(Ures);
            Assert.That(ps.getPersonWithHighestScore(), Is.EqualTo(null));
        }

        [Test]
        public void getAverageScoreOfStudents_UresListaval()
        {
            ps = new PersonStatistics(Ures);
            Assert.That(ps.getAverageScoreOfStudents(), Is.EqualTo(0));
        }

        [Test]
        public void getOldestStudent_UresListaval()
        {
            ps = new PersonStatistics(Ures);
            Assert.That(ps.getOldestStudent(), Is.EqualTo(null));
        }

        [Test]
        public void isAnyoneFailing_UresListaval()
        {
            ps = new PersonStatistics(Ures);
            Assert.That(ps.isAnyoneFailing(), Is.EqualTo(false));
        }

        [Test]
        public void getAverageAge_MasikTeliListaval()
        {
            ps = new PersonStatistics(MasikTeli);
            Assert.That(ps.getAverageAge(), Is.EqualTo(22));
        }

        [Test]
        public void getNumberOfStudents_MasikTeliListaval()
        {
            ps = new PersonStatistics(MasikTeli);
            Assert.That(ps.getNumberOfStudents(), Is.EqualTo(4));
        }

        [Test]
        public void getPersonWithHighestScore_MasikTeliListaval()
        {
            ps = new PersonStatistics(MasikTeli);
            Assert.That(ps.getPersonWithHighestScore().Name, Is.EqualTo("Joe"));
        }

        [Test]
        public void getAverageScoreOfStudents_MasikTeliListaval()
        {
            ps = new PersonStatistics(MasikTeli);
            Assert.That(ps.getAverageScoreOfStudents(), Is.EqualTo(70));
        }

        [Test]
        public void getOldestStudent_MasikTeliListaval()
        {
            ps = new PersonStatistics(MasikTeli);
            Assert.That(ps.getOldestStudent().Age, Is.EqualTo(23));
        }

        [Test]
        public void isAnyoneFailing_MasikTeliListaval()
        {
            ps = new PersonStatistics(MasikTeli);
            Assert.That(ps.isAnyoneFailing(), Is.EqualTo(true));
        }
    }
}