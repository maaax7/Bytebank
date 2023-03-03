
using ByteBank;

try
{
    using (LeitorDeArquivo leitor = new("caminho.txt"))
    {
        leitor.LerProximaLinha();
    }
}
catch(IOException ex)
{
    Console.WriteLine(ex.Message); 
}


//try
//{
//    ContaCorrente conta1 = new(283, "1234-X");
//    conta1.Sacar(500);
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine("Parâmetro com erro: " + ex.ParamName);
//    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
//    Console.WriteLine(ex.Message);
//}
//catch (SaldoInsuficienteException ex)
//{
//    Console.WriteLine("Operação negada! Saldo insuficiente!");
//    Console.WriteLine(ex.Message);
//}
//catch (OperacaoFinanceiraException e)
//{
//    Console.WriteLine(e.Message);
//    Console.WriteLine(e.StackTrace);

//    Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

//    Console.WriteLine(e.InnerException.Message);
//    Console.WriteLine(e.InnerException.StackTrace);
//}

Console.ReadKey();