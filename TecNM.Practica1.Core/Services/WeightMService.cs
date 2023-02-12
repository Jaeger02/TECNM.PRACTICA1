using TecNM.Practica1.Core.Services.Interfaces;
using TecNM.Practica1.Core.Entities;

namespace TecNM.Practica1.Core.Services;

public class WeightMService : IWeightMService{
    public WeightM ProcessWeightM(Person person){
        var weightM = new WeightM();
        weightM.Index = (person.WeightEarth / 9.81f)*3.711f;

        return weightM;
    }
}