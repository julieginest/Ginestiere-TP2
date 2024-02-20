using System.Runtime.CompilerServices;

public class Dog : Animal{

    public Dog(string Nom, int age){
        this.Nom = Nom;
        this.age = age;
        this.cri = "OUAF OUAF!!!!!!!!!";
        this.ageMax = 16;
    }

    public override void Crier(){
        Console.WriteLine($"{this.Nom} fait {this.cri}");
    }

    public override void SeDéplacer(int distance)
    {
        Console.WriteLine($"{this.Nom} marche de {distance}m");
    }


}