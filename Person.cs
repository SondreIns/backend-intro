public class Person
{
    public string Name { get; }
    public int Age { get; }
    public float Height { get; }
    public bool Employed { get; }
    public char FirstLetter => Name[0];

    public Person(string name, int age, float height, bool employed)
    {
        Name = name;
        Age = age;
        Height = height;
        Employed = employed;
    }

    public override string ToString() => $"{Name}, age {Age}, height: {Height}cm, is employed: {Employed}. Known by the initial {FirstLetter}.";

}