using Microsoft.AspNetCore.Mvc;

namespace testeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    // [HttpGet(Name = "GetWeatherForecast")]
    // public string Get()
    // {
    //     return "Ola!";
    // }

    [HttpGet(Name = "GetWeatherForecast")]
    public Motorista Get()
    {
        Motorista motomoto = new Motorista();

        motomoto.id = 1;
        motomoto.nome = "Cleber";
        motomoto.carro = "HB20";

        return motomoto;
    }
}
