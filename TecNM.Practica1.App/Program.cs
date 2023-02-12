using System;
using TecNM.Practica1.Core.Managers;
using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Services;

namespace TecNM.Practica1.App;

public static class Program{
    public static void Main(string[] args){
        float weightEarth = 0;

        System.Console.Write("Please enter the Weight (kg): ");
        Single.TryParse(System.Console.ReadLine(), out weightEarth);

        var person = new Person{WeightEarth = weightEarth};

        var service = new WeightMService();
        var manager = new WeightMManager(service);

        WeightM weightM = manager.GetWeightM(person);

        System.Console.WriteLine($"Weight on Mars: {weightM.Index} kg");
    }
}


