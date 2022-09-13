

using Polimorfismo;

Console.WriteLine("Digite três produtos a serem comprados: ");


List<string> produtos = new List<string>();

for (int i = 0; i < 3; i++)
{
    produtos.Add(Console.ReadLine());
}

Console.WriteLine("Qual forma de pagamento voce deseja? (Pix,Boleto,Cartão): ");

string formaPagamentoDesejada = Console.ReadLine();

if (formaPagamentoDesejada == FormasPagamentoEnum.Boleto.ToString())
{
    Boleto boleto = new Boleto();
    boleto.EfetuarPagamento();
}
else if (formaPagamentoDesejada == FormasPagamentoEnum.Pix.ToString())
{
    Pix pix = new Pix();
    pix.EfetuarPagamento();
}
else if (formaPagamentoDesejada == FormasPagamentoEnum.Cartao.ToString())
{
    new Cartao();
}