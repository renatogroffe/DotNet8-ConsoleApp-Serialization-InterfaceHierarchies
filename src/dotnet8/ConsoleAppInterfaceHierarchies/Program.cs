using ConsoleAppInterfaceHierarchies.Models;
using System.Runtime.InteropServices;
using System.Text.Json;

Console.WriteLine("***** Testes com .NET 8 | Serializacao usando Interface Hierarchies *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

var localidades = new Localidade[]
{
    new () { NomeCidade = "Sao Paulo", NomePais = "Brasil", NomeContinente = "America do Sul" },
    new () { NomeCidade = "Roma", NomePais = "Italia", NomeContinente = "Europa" },
    new () { NomeCidade = "Toquio", NomePais = "Japao", NomeContinente = "Asia" }
};

Console.WriteLine();
Console.WriteLine("*** Resultados da serializacao usando as interfaces IContinente, IPais e ICidade ***");
foreach (var cidade in localidades)
{
    Console.WriteLine();
    ExibirInfoLocalidade<IContinente>(cidade);
    ExibirInfoLocalidade<IPais>(cidade);
    ExibirInfoLocalidade<ICidade>(cidade);
}

static void ExibirInfoLocalidade<T>(T cidade) =>
    Console.WriteLine($"{typeof(T).Name} = {JsonSerializer.Serialize<T>(cidade)}");