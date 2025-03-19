using Newtonsoft.Json;

public class Endereco
{

    //   "cep": "01001-000",
    //   "logradouro": "Praça da Sé",
    //   "complemento": "lado ímpar",
    //   "unidade": "",
    //   "bairro": "Sé",
    //   "localidade": "São Paulo",
    //   "uf": "SP",
    //   "estado": "São Paulo",
    //   "regiao": "Sudeste",
    //   "ibge": "3550308",
    //   "gia": "1004",
    //   "ddd": "11",
    //   "siafi": "7107"

    [JsonProperty(PropertyName= "cep")]
    public string CEP { get; set; }

    [JsonProperty(PropertyName= "logradouro")]
    public string Logradouro { get; set; }

    [JsonProperty(PropertyName= "complemento")]
    public string Complemento { get; set; }

    [JsonProperty(PropertyName= "unidade")]
    public string Unidade { get; set; }

    [JsonProperty(PropertyName= "bairro")]
    public string Bairro { get; set; }

    [JsonProperty(PropertyName= "localidade")]
    public string Cidade { get; set; }

    [JsonProperty(PropertyName= "uf")]
    public string UF { get; set; }

    [JsonProperty(PropertyName= "regiao")]
    public string Regiao { get; set; }

    [JsonProperty(PropertyName= "ibge")]
    public string IBGE { get; set; }

    [JsonProperty(PropertyName= "gia")]
    public string GIA { get; set; }

    [JsonProperty(PropertyName= "ddd")]
    public int DDD { get; set; }

    [JsonProperty(PropertyName= "siafi")]
    public int SIAFI { get; set; }
}