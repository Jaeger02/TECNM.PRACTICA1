using TecNM.Practica1.Core.Entities;
using TecNM.Practica1.Core.Managers.Interfaces;
using TecNM.Practica1.Core.Services.Interfaces;

namespace TecNM.Practica1.Core.Managers;

public class WeightMManager : IWeightMManager{
    private readonly IWeightMService _service;
    public WeightMManager(IWeightMService service){
        _service = service;
    }

    public WeightM GetWeightM(Person person){
        return _service.ProcessWeightM(person);
    }
}