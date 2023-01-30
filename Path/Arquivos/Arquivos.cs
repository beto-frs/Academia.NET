
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Text;

namespace Path
{
    public class Arquivos : IArquivos
    {
        IConfiguration configuration;
        public Arquivos()
        { 
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json").Build();
        }
        

        public bool Verifica()
        {
            NLog.LogManager.GetLogger("Desafio1").Info("Verificando se contém o arquivo do desafio.");

            if (!File.Exists(ReturnJson("Arquivos:Desafio")))
            {
                NLog.LogManager.GetLogger("Desafio1").Warn("Arquivo não localizado.");
                NLog.LogManager.GetLogger("Desafio1").Debug("Criando o arquivo do desafio.");
                StreamWriter sr = File.CreateText(ReturnJson("Arquivos:Desafio"));
                sr.WriteLine("X - 4565 - 486544");
                sr.WriteLine("Z-Bernard Cornwell-5587849565-Recife-5458745982-04148562486");
                sr.WriteLine("Y-1356-1313-Arqueologia Marinha");
                sr.WriteLine("Z-Mary Shelley-5185695214-Santa Maria-5698547895-15478569840");
                sr.WriteLine("Y-1797-1851-Enxertos");
                sr.WriteLine("Z-Phillips Lovecraft-5584709655-Porto Alegre-5645895632-54898745625");
                sr.WriteLine("Y-1917-1854-Variaveis Dimensionais ");
                sr.WriteLine("Z-Harlan Coben-5487965899-São Paulo-5485489652-36521478541");
                sr.WriteLine("Z-Danielle Perry-1358485265-Caxias do Sul-5632144569-02654187490");
                sr.WriteLine("Y-1152-3354-Contagiosidade");
                sr.WriteLine("Z-William Peter Blatty-5532114587-Santa Maria-5102526547-01919647080");
                sr.WriteLine("Y-666-1114-Demologia");
                sr.WriteLine("Z-Suzanne Collins-4598562321-Florianópolis-6587878841-02587412369");
                sr.Close();
                NLog.LogManager.GetLogger("Desafio1").Info("Arquivo texto do Desafio foi criado.");
            }


            if (!File.Exists(ReturnJson("Arquivos:Alunos")) && !File.Exists(ReturnJson("Arquivos:Pessoas")))
            {
                NLog.LogManager.GetLogger("Desafio1").Debug("Criando os 2 arquivos textos");
                StreamWriter swAluno = File.CreateText(ReturnJson("Arquivos:Alunos"));
                StreamWriter swPessoas = File.CreateText(ReturnJson("Arquivos:Pessoas"));
                swAluno.Close();
                swPessoas.Close();
                NLog.LogManager.GetLogger("Desafio1").Info("Arquivos criados com sucesso.");
            }
            else
            {
                NLog.LogManager.GetLogger("Desafio1").Info("Arquivos de texto já existem.");
            }

            if (!File.Exists(ReturnJson("Arquivos:Log1")) && !File.Exists(ReturnJson("Arquivos:Log2")) && !File.Exists(ReturnJson("Arquivos:Log3")))
            {
                StreamWriter swLog1 = File.CreateText(ReturnJson("Arquivos:Log1"));
                swLog1.Close();
                StreamWriter swLog2 = File.CreateText(ReturnJson("Arquivos:Log2"));
                swLog2.Close();
                StreamWriter swLog3 = File.CreateText(ReturnJson("Arquivos:Log3"));
                swLog2.Close();
                NLog.LogManager.GetLogger("Desafio1").Info("Arquivo de log criado com sucesso");
            }
            NLog.LogManager.GetLogger("Desafio1").Info("Processo de verificação concluído.");

            if (!File.Exists(ReturnJson("Arquivos:Remedios")))
            {
                StreamWriter swRemed = File.CreateText(ReturnJson("Arquivos:Remedios"));
                swRemed.Close();
            }
            return true;
        }

        public string ReturnJson(string index)
        {
            var mensagem = (string)configuration.GetSection($"{index}").Value;
            return mensagem;
        }

        public void WriterPessoas(string texto)
        {
            StreamWriter sw;
            sw = new StreamWriter(ReturnJson("Arquivos:Pessoas"), true, Encoding.UTF8);
            sw.WriteLine(texto);
            sw.Close();
        }
        public void WriterAlunos(string texto)
        {
            StreamWriter sw;
            sw = new StreamWriter(ReturnJson("Arquivos:Alunos"), true, Encoding.UTF8);
            sw.WriteLine(texto);
            sw.Close();
        }
    }
}
