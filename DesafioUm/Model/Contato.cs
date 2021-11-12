using System;

public class Contato
{
    public Guid Id { get; }
    public string Ddd { get; private set; }
    public string Numero { get; private set; }
    public TipoContato TipoContato { get; private set; }
    public Cliente Proprietario { get; private set; }
}