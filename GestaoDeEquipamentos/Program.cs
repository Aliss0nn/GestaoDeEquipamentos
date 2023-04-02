
using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Data;

namespace GestaoDeEquipamentos
{

    internal class Program
    {
        #region
        static ArrayList nomeDoEquipamento = new ArrayList();
        static ArrayList precoDoEquipamento = new ArrayList();
        static ArrayList numeroDeFabricacao = new ArrayList();
        static ArrayList datadeFabricacao = new ArrayList();
        static ArrayList nomeDoFabricante = new ArrayList();

        static ArrayList nomeDochamado = new ArrayList();
        static ArrayList descricaoDoChamado = new ArrayList();
        static ArrayList nomeDoEquipamentoNochamado = new ArrayList();
        static ArrayList DataDeAbertura = new ArrayList();
        static ArrayList diasTotais = new ArrayList();


        #endregion

        static void GerarMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[1] - Controle de Equipamentos");
                Console.WriteLine("[2] - Controle de Chamados");
                Console.WriteLine("[0] - Pressione para sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        SubMenuEquip();
                        break;

                    case "2":
                        SubMenuChamados();                   
                        break;

                    case "0":
                        break;
                }



            }



        }


        static void SubMenuEquip()
        {
            int opcao = 1;
            do

            {
                Console.Clear();
                Console.WriteLine("[1] - Registrar equipamento");
                Console.WriteLine("[2] - Editar equipamento");
                Console.WriteLine("[3] - Excluir equipamento");
                Console.WriteLine("[4] - Mostrar equipamentos");
                Console.WriteLine("[0] - Para sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        RegistrarEquipamentos();
                        break;

                    case 2:
                        EditarEquipamentos();
                        break;

                    case 3:
                        ExcluirEquipamentos();
                        break;

                    case 4:
                        MostrarEquipamentos();
                        break;


                }



            } while (opcao != 0);


        }


        static void RegistrarEquipamentos()
        {
            Console.WriteLine("Digite o nome do equipamento");
            string nome = Console.ReadLine();

            if (nome.Length < 6)
            {
                Console.WriteLine("Digite novamente...\n");
                Console.WriteLine("Digite o nome do equipamento: ");
                nome = Console.ReadLine();
            }


            nomeDoEquipamento.Add(nome);

            Console.WriteLine();
            Console.WriteLine("Digite o preço do equipamento");
            int preco = int.Parse(Console.ReadLine());
            precoDoEquipamento.Add((int)preco);

            
            numeroDeFabricacao.Add(numeroDeFabricacao.Count);
            Console.WriteLine();
            Console.WriteLine("Data de fabricação");
            string data = Console.ReadLine();
            datadeFabricacao.Add(data);
            Console.WriteLine();
            Console.WriteLine("Nome do Fabricante");          
            string nomeDoFabri = Console.ReadLine();
            nomeDoFabricante.Add(nomeDoFabri);
            


        }


        static void EditarEquipamentos()
        {
            Console.Clear();
            MostrarEquipamentos();
            Console.WriteLine("Digite o Id do equipamento para editar");
            int trocarEquipamento = int.Parse(Console.ReadLine());
            int index = numeroDeFabricacao.IndexOf(trocarEquipamento);


            Console.WriteLine("Digite o nome do equipamento: ");
            string nome = Console.ReadLine();
            nomeDoEquipamento[index] = nome;

            if (nome.Length < 6)
            {
                Console.WriteLine("Digite novamente...");
                Console.WriteLine("Digite o nome do equipamento: ");
                nome = Console.ReadLine();
            }
            else
            {
                nomeDoEquipamento.Add(nome);
            }

            Console.WriteLine("Digite o preço do equipamento");
            int preco = int.Parse(Console.ReadLine());
            precoDoEquipamento[index] = ((int)preco);


            Console.WriteLine("Data de fabricação");
            string data = Console.ReadLine();
            datadeFabricacao[index] = (data);

            Console.WriteLine("Nome do Fabricante");
            string nomeDoFabri = Console.ReadLine();
            nomeDoFabricante[index] = (nomeDoFabri);




        }

        static void ExcluirEquipamentos()
        {
            Console.Clear();

            Console.Write("Qual o id da ferramenta deseja excluir: ");
            int excluirFerramenta = int.Parse(Console.ReadLine());

            int excluir = numeroDeFabricacao.IndexOf(excluirFerramenta);

            nomeDoEquipamento.RemoveAt(excluir);
            precoDoEquipamento.RemoveAt(excluir);
            numeroDeFabricacao.RemoveAt(excluir);
            datadeFabricacao.RemoveAt(excluir);
            nomeDoFabricante.RemoveAt(excluir);



        }

        static void MostrarEquipamentos()
        {

            Console.WriteLine("|       nomes        |       preços       |       datas        |     fabricantes    |          id        |");
            Console.WriteLine("|--------------------|--------------------|--------------------|--------------------|--------------------|");



            int count = nomeDoEquipamento.Count;


            for (int i = 0; i < count; i++)
            {

                Console.WriteLine($"{nomeDoEquipamento[i],14}  {precoDoEquipamento[i],18}   {numeroDeFabricacao[i],20}   {datadeFabricacao[i],20}   {nomeDoFabricante[i],20}");

            }
            
            for (int j = 0; j < 10 - count; j++)
            {
                Console.WriteLine("|                    |                    |                    |                    |                    |");
            }

            Console.WriteLine("\n");


        }



        static void SubMenuChamados()

        {
            
            int opcaoChamados = 1;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] - Registrar o chamado");
                Console.WriteLine("[2] - Visualizar os chamados");
                Console.WriteLine("[3] - Editar os chamados");
                Console.WriteLine("[4] - Excluir chamado");
                Console.WriteLine("[0] - Pressione para sair");

                opcaoChamados = int.Parse(Console.ReadLine());

                switch (opcaoChamados)
                {
                    case 1:
                        RegistrarChamados();
                        break;

                    case 2:
                        visualizarChamados();
                        break;

                    case 3:
                        EditarOsChamados();
                        break;

                    case 4:
                        ExcluirChamados();
                        break;

                }

            } while (opcaoChamados != 0);


        }


        static void RegistrarChamados()
        {

            Console.WriteLine("Digite o titulo do chamado");
            string tituloDoChamado = Console.ReadLine();
            nomeDochamado.Add(tituloDoChamado);
            Console.WriteLine();
            Console.WriteLine("Descrição do chamado");
            string descricaoChamado = Console.ReadLine();
            descricaoDoChamado.Add(descricaoChamado);
            Console.WriteLine();
            Console.WriteLine("Qual o equipamento do chamado");
            string nomechamadoequip2 = Console.ReadLine();
            nomeDoEquipamentoNochamado.Add(nomechamadoequip2);
            Console.WriteLine();
            Console.WriteLine("Qual a data do chamado");
            string dataDochamado = Console.ReadLine();
            DataDeAbertura.Add(dataDochamado);
            Console.WriteLine();
            DateTime dateTime = DateTime.Now;
            for (int i = 0; i < DataDeAbertura.Count; i++)
            {

                string dataInicial = (string)DataDeAbertura[i];
                string dataFinal = dateTime.ToString();

                TimeSpan date = Convert.ToDateTime(dataFinal) - Convert.ToDateTime(dataInicial);

                int DiasTotais = date.Days;

                diasTotais.Add(DiasTotais);

            }
        }

        static void visualizarChamados()
        {
            int count = nomeDochamado.Count;

            for ( int i = 0; i < count;i++)
            {

                Console.WriteLine($"{nomeDochamado}   {descricaoDoChamado}   {nomeDoEquipamentoNochamado}   {DataDeAbertura}   {diasTotais}");

            }

            for (  int j = 0; j < 10 - count;j++)
            {

                Console.WriteLine("|               |               |                 |               |                 | ");

                Console.WriteLine("\n");
            }


        }

        static void EditarOsChamados()
        {
            Console.Clear();
            visualizarChamados();
            Console.WriteLine("Digite o Id do equipamento para editar");
            int trocarChamado = int.Parse(Console.ReadLine());
            int index = numeroDeFabricacao.IndexOf(trocarChamado);

            Console.WriteLine("Digite o titulo do novo chamado");
            string tituloDoChamado = Console.ReadLine();
            nomeDochamado[index] = tituloDoChamado;

            Console.WriteLine("A nova descrição do chamado");
            string descricaoChamado = Console.ReadLine();
            descricaoDoChamado[index] = descricaoChamado;

            Console.WriteLine("Qual o novo equipamento do chamado");
            string nomechamadoequip2 = Console.ReadLine();
            nomeDoEquipamentoNochamado[index] = nomechamadoequip2;

            Console.WriteLine("Qual a nova data do chamado");
            string dataDochamado = Console.ReadLine();
            DataDeAbertura[index] = dataDochamado;
        }

        static void ExcluirChamados()
        {
            Console.Clear();

            Console.WriteLine("Qual o id do chamado que precisar ser excluido?");
            int excluirChamado = int.Parse(Console.ReadLine());

            int excluir = numeroDeFabricacao.IndexOf(excluirChamado);

            nomeDochamado.RemoveAt(excluir);
            descricaoDoChamado.RemoveAt(excluir);
            nomeDoEquipamentoNochamado.RemoveAt(excluir);
            DataDeAbertura.RemoveAt(excluir);
            diasTotais.RemoveAt(excluir);

        }



        static void Main(string[] args)
        {
            int opcao = 0;

            do
            {
                GerarMenu();
                SubMenuEquip();
                SubMenuChamados();

            } while( opcao != 0 );

        }
    }
}





















































}
