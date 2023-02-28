using Bytebank.Conta;
using Bytebank.Titular;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = new() { nome = "Andre Souza", Cpf = "289473894278", profissao = "Pedreiro" };
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta_corrente = "1010-X";
//contaDoAndre.saldo = 100;

//Console.WriteLine(contaDoAndre.ToString());

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = new() { nome = "Maria Souza", Cpf = "234123423", profissao = "CEO" };
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta_corrente = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine(contaDaMaria.ToString());

//contaDoAndre.Depositar(100);

//Console.WriteLine("Saldo da conta do André pós-depósito =" + contaDoAndre.saldo);

//if (contaDoAndre.Sacar(300) == true)
//    Console.WriteLine("Saldo da conta do André pós-saque =" + contaDoAndre.saldo);
//else
//    Console.WriteLine("Saldo insuficiente para saque.");

//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

//ContaCorrente contaDoPedro = new ContaCorrente();
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.conta_corrente);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.saldo);

//Console.WriteLine(contaDoPedro.ToString());

//ContaCorrente conta3 = new ContaCorrente();
//conta3.SetSaldo(-10);
//Console.WriteLine(conta3.GetSaldo());

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_Agencia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_Agencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_Agencia);

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta7 = new ContaCorrente(285, "1111-Z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadKey();
