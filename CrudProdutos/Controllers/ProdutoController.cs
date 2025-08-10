using CrudProdutos.Entities;
using CrudProdutos.Repositories;
using CrudProdutos.Validators;

namespace CrudProdutos.Controllers
{
    public class ProdutoController
    {
        public void CadastrarProduto()
        {
            Console.WriteLine("\nCADASTRO DE PRODUTO:\n");

            var produto = new Produto();

            Console.Write("NOME DO PRODUTO ....: ");
            produto.Nome = Console.ReadLine() ?? string.Empty;

            Console.Write("PREÇO ..............: ");
            produto.Preco = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("QUANTIDADE .........: ");
            produto.Quantidade = int.Parse(Console.ReadLine() ?? "0");

            var validator = new ProdutoValidator();
            var result = validator.Validate(produto);

            if (result.IsValid)
            {
                var produtoRepository = new ProdutoRepository();
                produtoRepository.Inserir(produto);

                Console.WriteLine("\nPRODUTO CADASTRADO COM SUCESSO!");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    Console.WriteLine($"\nERRO: {item.ErrorMessage}");
                }
            }

            Console.Write("\n\nPRESSIONE QUALQUER TECLA PARA CONTINUAR!");
            Console.ReadKey();
        }

        public void AtualizarProduto()
        {
            Console.WriteLine("\nATUALIZAÇÃO DE PRODUTO:\n");

            var produto = new Produto();

            Console.Write("ID DO PRODUTO ......: ");
            produto.Id = Guid.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("NOME DO PRODUTO ....: ");
            produto.Nome = Console.ReadLine() ?? string.Empty;

            Console.Write("PREÇO ..............: ");
            produto.Preco = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("QUANTIDADE .........: ");
            produto.Quantidade = int.Parse(Console.ReadLine() ?? "0");

            var validator = new ProdutoValidator();
            var result = validator.Validate(produto);

            if (result.IsValid)
            {
                var produtoRepository = new ProdutoRepository();

                if (produtoRepository.Atualizar(produto))
                    Console.WriteLine("\nPRODUTO ATUALIZADO COM SUCESSO!");
                else
                    Console.WriteLine("\nNENHUM PRODUTO FOI ENCONTRADO. VERIFIQUE O ID INFORMADO.");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    Console.WriteLine($"\nERRO: {item.ErrorMessage}");
                }
            }

            Console.Write("\n\nPRESSIONE QUALQUER TECLA PARA CONTINUAR!");
            Console.ReadKey();
        }

        public void ExcluirProduto()
        {
            Console.WriteLine("\nEXCLUSÃO DE PRODUTO:\n");

            Console.Write("ID DO PRODUTO ......: ");
            var id = Guid.Parse(Console.ReadLine() ?? string.Empty);


            var produtoRepository = new ProdutoRepository();

            if (produtoRepository.Excluir(id))
                Console.WriteLine("\nPRODUTO EXCLUIDO COM SUCESSO!");
            else
                Console.WriteLine("\nNENHUM PRODUTO FOI ENCONTRADO. VERIFIQUE O ID INFORMADO.");


            Console.Write("\n\nPRESSIONE QUALQUER TECLA PARA CONTINUAR!");
            Console.ReadKey();
        }

        public void ConsultarProdutos()
        {
            Console.WriteLine("\nCONSULTA DE PRODUTO:\n");

            var produtoRepository = new ProdutoRepository();

            Console.Write("NOME DO PRODUTO ....: ");
            var nome = Console.ReadLine() ?? string.Empty;

            foreach (var produto in produtoRepository.Consultar(nome))
            {
                Console.WriteLine($"\n=============================================================");

                Console.Write($"\nID ....................: {produto.Id}");
                Console.Write($"\nNOME DO PRODUTO .......: {produto.Nome}");
                Console.Write($"\nPREÇO .................: {produto.Preco:C}");
                Console.Write($"\nQUANTIDADE ............: {produto.Quantidade}");

                Console.Write($"\n\n=============================================================");
            }

            Console.Write("\n\nPRESSIONE QUALQUER TECLA PARA CONTINUAR!");
            Console.ReadKey();
        }
    }
}
