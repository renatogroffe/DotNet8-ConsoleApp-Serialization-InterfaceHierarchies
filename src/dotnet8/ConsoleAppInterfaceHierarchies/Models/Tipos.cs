namespace ConsoleAppInterfaceHierarchies.Models;

public interface IContinente
{
    public string? NomeContinente { get; set; }
}

public interface IPais : IContinente
{
    public string? NomePais { get; set; }
}

public interface ICidade : IPais
{
    public string? NomeCidade { get; set; }
}

public class Localidade : ICidade
{
    public string? NomeContinente { get; set; }
    public string? NomePais { get; set; }
    public string? NomeCidade { get; set; }
}