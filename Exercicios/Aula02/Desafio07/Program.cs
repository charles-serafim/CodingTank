/*
DESAFIO 07:

Uma loja de produtos eletrônicos com vendas regulares opta por contratar uma equipe
para a organização de um sistema de gerenciamento de vendas. Elabore um algoritmo que,
a partir de dados fornecidos pelo usuário, calcule o valor da venda de um produto,
exibindo uma saída em vídeo contendo o código do produto, o nome, a quantidade
comprada, o valor unitário e o valor total.
*/


using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Desafio07
{
    class Program
    {
        static int productCount = 0;
        static Dictionary<int, Product> productList = new Dictionary<int, Product> {};
        static int purchaseCount = 0;
        static Dictionary<int, List<Order>> purchases = new Dictionary<int, List<Order>> {};

        static void Main(string[] args)
        {
            bool menu = true;

            Console.Clear();

            while(menu)
            {
                int option = Menu();

                switch(option)
                {
                    case 1:
                        AddProduct(productList); // Cadastrar produto
                        break;
                    
                    case 2:
                        PrintProducts(productList); // Mostrar produtos cadastrados
                        break;
                    
                    case 3:
                        RegisterPurchase(productList); // Registrar compra
                        break;
                    
                    case 4:
                        PrintPurchases(); // Mostrar compras registradas
                        break;
                    
                    case 5:
                        menu = false; // Sair
                        break;

                    default:
                        break;
                }
            }
        }

        // função para exibir o menu e ler uma entrada do usuário
        static int Menu()
        {
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Mostrar produtos cadastrados");
            Console.WriteLine("3 - Registrar compra");
            Console.WriteLine("4 - Mostrar compras registradas");
            Console.WriteLine("5 - Sair");

            int option = ReadOption(5);

            return option;
        }

        // função para ler entrada do usuário que aceita um numero inteiro entre 1 e max
        static int ReadOption(int max)
        {
            int option;

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("Escolha uma opção: ");

                try
                {
                    option = int.Parse(Console.ReadLine());

                    if(option < 1 || option > max)
                    {
                        Console.WriteLine($"Digite um número entre 1 e {max}: ");
                        Console.WriteLine();
                        continue;
                    }

                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    Console.WriteLine();
                }
            }
            return option;
        }

        // função para registrar um produto
        static void AddProduct(Dictionary<int, Product> productList)
        {
            productCount++;

            Console.Clear();

            Console.WriteLine("Digite o nome do produto: ");
            string productName = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto: ");
            double productPrice = double.Parse(Console.ReadLine());

            // cria um novo objeto Product com as informações fornecidas
            Product newProduct = new Product(productCount, productName, productPrice);
            
            // adicionar o produto ao dicionário de produtos usando o código gerado como chave
            productList[newProduct.Code] = newProduct;

            Console.WriteLine();
            Console.WriteLine($"Produto cadastrado com sucesso.\n");

            GoOn();
        }

        // função para registrar uma compra
        static void RegisterPurchase(Dictionary<int, Product> productList)
        {
            Console.Clear();

            // cria um novo pedido
            Dictionary<Product, int> order = new Dictionary<Product, int>();
            double totalPurchasePrice = 0;

            // Solicita o código do produto e a quantidade para adicionar ao pedido
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Digite o código do produto: ");
                int productCode = int.Parse(Console.ReadLine());

                if (productList.ContainsKey(productCode))
                {
                    Product product = productList[productCode];

                    Console.WriteLine();
                    Console.WriteLine($"Produto selecionado: {product.Name}");
                    Console.WriteLine($"Preço unitário: R$ {product.Price:C2}");

                    Console.WriteLine();
                    Console.WriteLine("Digite a quantidade desejada: ");
                    int quantity = int.Parse(Console.ReadLine());

                    // adiciona o produto e a quantidade ao pedido
                    order[product] = quantity;

                    // calcula o preço total do produto
                    double productTotalPrice = product.TotalShippingPrice(quantity);
                    Console.WriteLine();
                    Console.WriteLine($"Valor total para este produto: R$ {productTotalPrice:C2}");

                    totalPurchasePrice += productTotalPrice;
                }
                else
                {
                    Console.WriteLine("Código de produto inválido. Tente novamente.");
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("Deseja adicionar outro produto? (s/n)");
                if (Console.ReadLine()?.ToLower() != "s")
                {
                    break;
                }
            }

            // Gere um código para a compra
            purchaseCount++;
            purchases[purchaseCount] = new List<Order>();

            // Registra o pedido na compra
            foreach (var item in order)
            {
                Product product = item.Key;
                int quantity = item.Value;

                purchases[purchaseCount].Add(new Order(quantity, product));
            }

            Console.WriteLine();
            Console.WriteLine($"Compra registrada com sucesso. Código da compra: {purchaseCount:D3}");
            Console.WriteLine($"Valor total da compra: R$ {totalPurchasePrice:C2}");
            GoOn();
        }
        // função para listar os produtos cadastrados
        static void PrintProducts(Dictionary<int, Product> productList)
        {
            Console.Clear();
            Console.WriteLine("Lista de produtos cadastrados:");
            Console.WriteLine();

            foreach (var entry in productList)
            {
                int productCode = entry.Key;
                Product product = entry.Value;

                Console.WriteLine($"Código do Produto: {productCode:D3}");
                Console.WriteLine($"Nome: {product.Name}");
                Console.WriteLine($"Preço: R$ {product.Price:C2}");
                Console.WriteLine();
            }

            GoOn();
        }

        // função para listar compras realizadas
        static void PrintPurchases()
        {
            Console.Clear();
            Console.WriteLine("Compras registradas:");
            Console.WriteLine();

            foreach (var purchase in purchases)
            {
                int purchaseCode = purchase.Key;
                List<Order> orderList = purchase.Value;

                Console.WriteLine($"CÓDIGO DA COMPRA: {purchaseCode:D3}");
                Console.WriteLine();
                Console.WriteLine($"{"Item ",- 25}{"Quantidade ",- 20}{"Preço unitário ",- 20}{"Preço total",- 20}");

                double totalPurchase = 0;

                foreach (var order in orderList)
                {
                    Product product = order.OrderedProduct;
                    int quantity = order.Quantity;
                    totalPurchase += order.TotalPrice;
                    
                    Console.WriteLine($"{product.Name,- 25}{quantity,- 20}{$"{product.Price:C2}",- 20}{$"{order.TotalPrice:C2}",- 20}");
                }

                Console.WriteLine();
                Console.WriteLine($"Valor total da compra: R$ {totalPurchase:C2}");

                Console.WriteLine();
            }

            GoOn();
        }

        static void GoOn()
        {
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
        }
    }

    // classe que define a estrutura de um produto
    class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(int code, string name, double price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        // método para calcular o valor total da compra com base na quantidade comprada
        public double TotalShippingPrice(int quantity)
        {
            return quantity * Price;
        }
    }

    // classe que define a estrutura de um pedido
    class Order
    {
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public Product OrderedProduct { get; set; }

        public Order(int quantity, Product orderedProduct)
        {
            Quantity = quantity;
            OrderedProduct = orderedProduct;
            TotalPrice = OrderedProduct.TotalShippingPrice(quantity); // acessa o método do produto para calcular o total da compra
        }
    }
}