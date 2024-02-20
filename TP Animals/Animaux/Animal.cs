public abstract class Animal{
    protected string cri;
    protected int age;
    protected int ageMax;
    public string Nom;

    public abstract void Crier();

    public abstract void SeDéplacer(int distance);
    public void Vieillir(int années){
        if(this.age > this.ageMax){
            Console.WriteLine("L'animal est déjà mort");
        }else{
            this.age = this.age + années;
            Console.WriteLine($"{this.Nom} à pris {années}ans");
            Console.WriteLine($"{this.Nom} à {this.age}ans");

            if(this.age > this.ageMax){
                Console.WriteLine($"{this.Nom} est mort");
            }
        }


        


    }

    public void Manger(){}

    public override string ToString(){
        return $"Ce {this.GetType()} à {age} ans et peut vivre jusqu'à {ageMax} ans. Il fait {cri}";
    }

}