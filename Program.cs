using Newtonsoft.Json;

// Início do programa
Console.WriteLine("Por favor informe o CEP que deseja consultar: ");

// Pegando o CEP do Prompt de comando
string inputCEP = Console.ReadLine();

//Se for digitado valor incorreto ou espaços em branco mostra a mensagem 
if(string.IsNullOrWhiteSpace(inputCEP))
    Console.WriteLine("Informe um CEP válido...");
else
{
    // Passando a variável por parâmetro na URL da API 
    string strUrl = string.Format("https://viacep.com.br/ws/{0}/json/", inputCEP.ToString());

    try
    {
        // Instanciando a conexão Web - caso exista
        using(HttpClient client = new HttpClient())
        {
            // Utilizando o método GetAsync() 
            var response = client.GetAsync(strUrl).Result;

            // Testando se o Status Code for Ok (200) retorna o resultado da consulta
            if(response.IsSuccessStatusCode)
            {
                // Guardando o resultado do conteúdo da API
                var result = response.Content.ReadAsStringAsync().Result;
                // Deserializando o Objeto JSON 
                Endereco res = JsonConvert.DeserializeObject<Endereco>(result);

                // Mostra no console as informações do CEP em questão
                Console.WriteLine("O CEP consultado é o " + inputCEP + " na cidade de " + res.Cidade + "-" + res.UF);
                Console.WriteLine("O Endereço fica na " + res.Logradouro + " no bairro da " + res.Bairro );                
            }
        }
    }
    catch (Exception ex)
    {
        // Retorna a mensagem de erro, caso ocorra.
        Console.WriteLine(ex.Message);
    }
}