namespace Week_7_1_OOP_Exercises_2.IntoductionToLinqs;

public class Person {
    private readonly String _name;
    private readonly int _age;

    public Person(String name, int age) {
        this._name = name;
        this._age = age;
    }

    public String GetName() {
        return _name;
    }

    public int GetAge() {
        return _age;
    }
}