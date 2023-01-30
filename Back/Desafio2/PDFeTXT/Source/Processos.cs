using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDFeTXT.Models;
using static System.Console;

namespace PDFeTXT.Source
{
    public class Processos : Pessoa
    {
        private string nomeP;
        private string telefoneP;
        private string cidadeP;
        private string rgP;
        private string cpfP;

        const string DESAFIO = @"D:\desafio1.txt";
        const string ALUNO = @"D:\aluno.txt";
        const string PESSOAS = @"D:\pessoas.txt";
        private string _line;

        public bool Verifica()
        {
            if (!File.Exists(ALUNO) && !File.Exists(PESSOAS))
            {
                StreamWriter swAluno = File.CreateText(ALUNO);
                StreamWriter swProfessor = File.CreateText(PESSOAS);
                swAluno.Close();
                swProfessor.Close();
            }
            return true;
        }

        public void ReadText()
        {
            int cont = 0;
            int cont2 = 0;
            List<Processos> processos = new List<Processos>();

            Aluno aluno = new Aluno();
            List<Aluno> alunos = new List<Aluno>();

            Professor professor = new Professor();
            List<Professor> professores = new List<Professor>();

            using (StreamReader sr = new StreamReader(DESAFIO,Encoding.UTF8,true))
            {

                
                WriteLine("Exibindo somente os alunos!\n\n");

                while ((_line = sr.ReadLine()) != null)
                {
                    try
                    {
                        string[] lineArray = (_line.Split('-'));
                        if (lineArray[0] == "Z")
                        {
                            nomeP = lineArray[1];
                            telefoneP = lineArray[2];
                            cidadeP = lineArray[3];
                            rgP = lineArray[4];
                            cpfP = lineArray[5];
                            processos.Add(new Processos()
                            {
                                _nome = lineArray[1],
                                _telefone = lineArray[2],
                                _cidade = lineArray[3],
                                _rg = lineArray[4],
                                _cpf = lineArray[5]
                            });

                        }

                        else if (lineArray[0] == "Y")
                        {
                            alunos.Add(new Aluno()
                            {
                                _nome = nomeP,
                                _telefone = telefoneP,
                                _cidade = cidadeP,
                                _rg = rgP,
                                _cpf = cpfP,
                                _matricula = lineArray[1],
                                _codigoCurso = lineArray[2],
                                _nomeCurso = lineArray[3]
                            });


                        }
                    }
                    catch
                    {
                    }

                }
                sr.Close();
                if (Verifica())
                {
                    StreamWriter swAluno = new StreamWriter(ALUNO, true, Encoding.UTF8);
                    foreach (var alu in alunos)
                    {
                        swAluno.WriteLine($"{alu._nome}-{alu._telefone}-{alu._cidade}-{alu._cidade}-{alu._rg}-{alu._cpf}-{alu._matricula}-{alu._codigoCurso}-{alu._nomeCurso}");

                    }
                    swAluno.Close();

                    StreamWriter swPessoas = new StreamWriter(PESSOAS, true, Encoding.UTF8);
                    foreach (var alu in processos)
                    {
                        swPessoas.WriteLine($"{alu._nome}-{alu._telefone}-{alu._cidade}-{alu._cidade}-{alu._rg}-{alu._cpf}");

                    }
                    swPessoas.Close();

                }
                
                
                

            }

        }

    }
}