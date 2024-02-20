public class Program{
    static void Main(string[] args){
        Dog dog1 = new Dog("Kiki", 3);
        Console.WriteLine(dog1.ToString());
        dog1.SeDéplacer(3);
        dog1.Crier();
        dog1.Vieillir(2);
        
        Console.WriteLine("\n#####################################\n");

        Eagle bird1 = new Eagle("Pioupiou", 15);
        Console.WriteLine(bird1.ToString());
        bird1.SeDéplacer(3);
        bird1.Crier();
        bird1.Vieillir(2);
        bird1.Vieillir(75);
        bird1.Vieillir(75);
    }
}