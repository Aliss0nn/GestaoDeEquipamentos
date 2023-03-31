




using System.Collections;
using System.Runtime.CompilerServices;

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
                Console.WriteLine("[1] - Controle de Equipamentos");
                Console.WriteLine("[2] - Controle de Chamados");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        SubMenuEquip();
                        break;

                    case "2": SubMenuChamados();
                        break;

                }


            }



        }


        static void SubMenuEquip()
        {
           do
          
           {
                Console.Clear();
                Console.WriteLine("[1] - Registrar equipamento");
                Console.WriteLine("[2] - Editar equipamento");
                Console.WriteLine("[3] - Excluir equipamento");
                Console.WriteLine("[4] - Mostrar equipamentos");
                Console.WriteLine("[5] - Para sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        RegistrarEquipamentos();
                        break;

                    case 2:EditarEquipamentos();
                        break;

                    case 3: ExcluirEquipamentos();
                        break;

                    case 4: MostrarEquipamentos();
                        break;

                    case 5: 
                        break;
                }



           }  while (true);


        }


        static void RegistrarEquipamentos()
        {
            Console.WriteLine("Digite o nome do equipamento: ");
            string nome = Console.ReadLine();

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
            precoDoEquipamento.Add((int)preco);

            Console.WriteLine("Digite o número de fabricação");
            int fabricacao = int.Parse(Console.ReadLine());
            numeroDeFabricacao.Add(fabricacao);

            Console.WriteLine("Data de fabricação");
            string data = Console.ReadLine();
            datadeFabricacao.Add(data);

            Console.WriteLine("Nome do Fabricante");
            string nomeDoFabri = Console.ReadLine();
            nomeDoFabricante.Add(nomeDoFabri);



        }
              
        
        static void EditarEquipamentos()
        {
            Console.WriteLine("Digite o Id do equipamento para editar");
           








        }

        static void ExcluirEquipamentos()
        {

        }

        static void MostrarEquipamentos()
        {


        }
       
        
        
        static void SubMenuChamados()
        {
            Console.Clear();
            Console.WriteLine("[1] - Registrar o chamado");
            Console.WriteLine("[2] - Visualizar os chamados");
            Console.WriteLine("[3] - Editar os chamados");
            Console.WriteLine("[0] - Pressione para sair");

            int opcaoChamados = int.Parse(Console.ReadLine());

            switch(opcaoChamados)
            {
                case 1: RegistrarChamados();
                    break;

                case 2:
                    break;


            }




        }


        static void RegistrarChamados()
        {

            Console.WriteLine("Digite o titulo do chamado");
            string tituloDoChamado = Console.ReadLine();
            nomeDochamado.Add(tituloDoChamado);

            Console.WriteLine("Descrição do chamado");
            string descricaoChamado = Console.ReadLine();
            descricaoDoChamado.Add(descricaoChamado);

            Console.WriteLine("Qual o equipamento do chamado");
            string nomechamadoequip2 = Console.ReadLine();
            nomeDoEquipamentoNochamado.Add(nomechamadoequip2);

            Console.WriteLine("Qual a data do chamado");
            string dataDochamado = Console.ReadLine();
            DataDeAbertura.Add(dataDochamado);

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

        }

        static void EditarOsChamados()
        {

        }
       
        
        static void Main(string[] args)
        {
            GerarMenu();
            SubMenuEquip();
            SubMenuChamados();



        }


























































    }


















































}