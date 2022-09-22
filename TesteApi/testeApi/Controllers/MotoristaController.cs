using Microsoft.AspNetCore.Mvc;

namespace testeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MotoristaController : ControllerBase
{
    Motorista [] motomoto = new Motorista[5];
    List<Motorista> moto = new List<Motorista>();
    [HttpGet(Name = "GetMotorista")]
    public List<Motorista> Get()
    {       
        Motorista m = new Motorista ();

        m.id = 15;
        m.nome = "Cleber Jorge";
        m.carro = "Golf!";
        motomoto[0] = m;
        moto.Add(motomoto[0]);

        Motorista n = new Motorista ();
        n.id = 16;
        n.nome = "Gorge";
        n.carro = "Golf!!!!!!";
        motomoto[1] = n;
        moto.Add(motomoto[1]);

        // motomoto[2].id = 17;
        // motomoto[2].nome = "Cleberorge";
        // motomoto[2].carro = "Fiesta!";
        // moto.Add(motomoto[2]);

        // motomoto[3].id = 18;
        // motomoto[3].nome = "Clge";
        // motomoto[3].carro = "Corsa";
        // moto.Add(motomoto[3]);

        // motomoto[4].id = 15;
        // motomoto[4].nome = "Cleber Jorge";
        // motomoto[4].carro = "Golf!";
        // moto.Add(motomoto[4]);

        return moto;
    }
}
