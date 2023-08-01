
using AbstractClass;


string answer;

Console.WriteLine("Enter the your prefer car Lanborhini or Ferrari");
answer = Console.ReadLine();

if (answer == "Lamborghini")
{
    var lambo = new Lamborghini();
    lambo.Color();
    lambo.Model();
    lambo.Price();
}
else if(answer == "Ferrari")
{
    var fer = new Ferrari();
    fer.Color();
    fer.Model();
    fer.Price();
}