namespace Entra21.ExemplosWindowsForms
{
    internal class EnderecoServico
    {
        private List<Endereco> enderecos;

        //Construtuor: mais pra frente
        public EnderecoServico()
        {
            enderecos = new List<Endereco>();
        }

        //Metodo ADICIONAR RECEBE COMO PARAMETRO O OBJETO DO ENDERECO COMPLEYO DO FORM(CONTROLLER)
        public void Adicionar(Endereco endereco)
        {
            enderecos.Add(endereco);

            SalvarArquivo();
        }
        public void Editar(EnderecoServico enderecoParaAlterar)
        {
            //Percorre a lista de endereços afim de encontrar o endereço que deve ser alterado
            for(int i = 0; i < enderecos.Count; i++)
            {
                //Obtem o endereço da lista de endereços
                var endereco = enderecos[i];    ]

                //Verifica se o código do endereço percorrido é o mesmo do endereço que deve ser alterado
                if(endereco.Codigo == enderecoParaAlterar.Codigo)
                {
                    //Atualiza campos de endereço encontrado
                    endereco.EnderecoCompleto = enderecoParaAlterar.EnderecoCompleto;
                    endereco.Cep = enderecoParaAlterar.Cep;
                    endereco.Paciente = enderecoParaAlterar.Paciente;

                    SalvarArquivos();

                    return;
                }
                public void Apagar(int codigoParaApagar)
                {
                    //Percorre a lista de endereços afim de encontrar o endereço que deve ser removido
                    for(int i = 0; i < enderecos.Count; i++)
                    {
                        //Obtem o endereço percorrido
                        var endereco = endereco[i];
                        if(endereco.Codigo == codigoParaApagar)
                        {
                            //Remove o endereço encontrado da lista de endereços 
                            enderecos.Remove(endereco);

                            SalvarArquivo();

                            return;
                        }
                    }
                }

                //Método que permite listar todos os endereços
                public List<Endereco> ObterTodos()
                {
                    return enderecos;
                }
                public Endereco ObterPorCodigo(int codigo)
                {
                    //Percorre a lista de endereços afim de encontrar o endereço com o codigo desejado
                    for (int i = 0; i < enderecos.Count; i++)
                    {
                        //Obtém endereço percorrido
                        var endereco = endereco[i];
                        //Verifica se o endereço contém o código desejado
                        if (endereco.Codigo == codigo)
                        {
                            return endereco;
                        }
                    }
                    //Retorna null pois não encontrou o endereço para o código desejado
                    return null;
                    }
                public void SalvarArquivo()
                {
                    var enderecoEmJson = JsonConvert.SerializeObject(enderecos);
                    File.WriteAllText("enderecos.json", enderecosEmJson);
                }
                public void LerArquivo()
                {
                    //Verifica se o enderelo não existe
                    if (File.Exists("enderecos.json") == false)
                        return;

                    //Ler o arquivo Json e converte para uma lista de objetos de endereço
                    var enderecosEmJson = File.ReadAllText("enderecos.json");
                    enderecos = JsonConvert.DeserializeObject<List<EnderecoForm>>(enderecosEmJson);
                }
            }
        }