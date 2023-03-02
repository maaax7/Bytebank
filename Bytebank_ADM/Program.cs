using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Parceria;
using Bytebank_ADM.SistemaInterno;
using Bytebank_ADM.Utilitario;

#region comentado
//var roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.ToString());

//var pedro = new Designer("123456789");
//pedro.Nome = "Pedro malazartes";

//Console.WriteLine(pedro.ToString());

//var jose = new Gerente("123456789");
//jose.Nome = "Jose Severino";

//Console.WriteLine(jose.ToString());

//var conceicao = new Auxiliar("123456789");
//conceicao.Nome = "Conceicao das Dores";

//Console.WriteLine(conceicao.ToString());

//var gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);
//gerenciador.Registrar(jose);
//gerenciador.Registrar(conceicao);

//Console.WriteLine("\nTotal de bonificações: " + gerenciador.TotalDeBonificacao);
//Console.WriteLine("\nTotal de funcionarios: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();
//jose.AumentarSalario();
//conceicao.AumentarSalario();


//Console.WriteLine("\nNovo salário do Pedro: " + pedro.Salario);
//Console.WriteLine("\nNovo salário da Roberta: " + roberta.Salario);
//Console.WriteLine("\nNovo salário do Jose: " + jose.Salario);
//Console.WriteLine("\nNovo salário da Conceicao: " + conceicao.Salario); 
#endregion

CalcularBonificacao();
void CalcularBonificacao()
{
    var gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("0168186186");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("1681681");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("1818186");
    igor.Nome = "Igor Souza";

    Gerente camila = new Gerente("84186468");
    camila.Nome = "Camila Souza";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de Bonificacao = " + gerenciador.TotalDeBonificacao);
}

UsarSistema();
void UsarSistema()
{
    var sistema = new SistemaInterno();

    Diretor paula = new Diretor("1681681");
    paula.Nome = "Paula Souza";
    paula.Login = "paula";
    paula.Senha = "123";

    Gerente camila = new Gerente("84186468");
    camila.Nome = "Camila Souza";
    camila.Login = "camila";
    camila.Senha = "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";
    caio.Login = "caio";

    sistema.Logar(paula, "paula", "848");
    sistema.Logar(camila, "camilo", "321");
    sistema.Logar(caio, "caio", "999");
}