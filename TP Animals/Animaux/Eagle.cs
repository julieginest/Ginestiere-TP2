public class Eagle : Bird{

    public Eagle(string Nom, int age){
        this.Nom = Nom;
        this.age = age;
        this.cri = "CUICUI!!!!";
        this.ageMax = 70;
    }

    public override void SeDéplacer(int distance){
        Console.WriteLine($"{this.Nom} vole de {distance}m");
    }
    public override void Crier(){
        Console.WriteLine($"{this.Nom} fait {this.cri}");
    }
}