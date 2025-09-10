namespace POOWorkshop.Domain.People
{
    public abstract class Person
    {
        public string FullName { get; set; }

        public Person(string fullName)
        {
            FullName = fullName;
        }
    }
}
