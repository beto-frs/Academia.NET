using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace EntityFramework
{
    public class Initial
    {
        Pessoa pessoa;
        Email email;
        Contexto context;

        public Initial(Pessoa pe, Email em, Contexto co)
        {
            pessoa = pe;
            email = em;
            context = co;
        }

        public void Start()
        {
        inicio:
            Clear();
            WriteLine("Informe 1 para criar uma pessoa\n" +
                "2 para alterar o nome\n" +
                "3 para inserir o email\n" +
                "4 para consultar as pessoas\n" +
                "5 para as pessoas (todas)\n" +
                "6 para consultar pelo ID\n\n");
            WriteLine("==============================================================================\n");
            
            int op = int.Parse(ReadLine());
            if (Escolha(op))
            {
                goto inicio;
            }

        }

        public bool Escolha(int id)
        {

            switch (id)
            {
                case 1:

                    try
                    {
                        WriteLine("Insira o nome da pessoa");
                        pessoa.Nome = ReadLine();
                        WriteLine("Insira o email da pessoa");
                        email.email = ReadLine();

                        pessoa.Emails = new List<Email>();
                        pessoa.Emails.Add(email);
                        context.Pessoas.Add(pessoa);
                        context.SaveChanges();
                        ReadKey();
                    }
                    catch (Exception ex)
                    {
                        WriteLine($"Erro -> {ex.Message}");
                    }
                    return true;


                case 2:

                    WriteLine("Informe o ID da pessoa:");
                    int idPessoa2 = int.Parse(ReadLine());
                    pessoa = context.Pessoas.Find(idPessoa2);
                    WriteLine("Informe un novo nome:");
                    pessoa.Nome = ReadLine();
                    context.Pessoas.Update(pessoa);
                    context.SaveChanges();
                    ReadKey();
                    return true;
                    //break;

                case 3:

                    WriteLine("Informe o ID da pessoa:");
                    int idPessoa3 = int.Parse(ReadLine());
                    Pessoa pess = context.Pessoas.Find(idPessoa3);
                    WriteLine("Insria um novo email:");
                    email.email = ReadLine();

                    

                    if (pess.Emails == null)
                    {
                        pess.Emails = new List<Email>();
                    }

                    pess.Emails.Add(email);

                    context.Pessoas.Update(pess);
                    context.SaveChanges();
                    return true;
                    //break;



                case 4:

                    WriteLine("Informe o Id da pessoa: ");
                    int idExec = int.Parse(ReadLine());

                    Pessoa pExc = context.Pessoas.Find(idExec);

                    WriteLine($"Confirma a exclusão de: {pExc.Nome}");
                    WriteLine("e dos seus emails: ");
                    foreach (Email item in pExc.Emails)
                    {
                        WriteLine($"   {item.email}");
                    }
                    WriteLine("1 - SIM\n2 - NÃO");
                    int retorno = int.Parse(ReadLine());

                    if (retorno == 1)
                    {
                        context.Pessoas.Remove(pExc);
                        context.SaveChanges();
                    }

                    return true;
                    //break;


                case 5:

                    List<Pessoa> pessoas = new List<Pessoa>();
                    pessoas = (from Pessoa p in context.Pessoas select p).
                        Include(e => e.Emails).ToList<Pessoa>();

                    foreach (Pessoa pessoaItem in pessoas)
                    {
                        WriteLine($"Nome: {pessoaItem.Nome}");
                        foreach (Email emailItem in pessoaItem.Emails)
                        {
                            WriteLine($" ---- Email: {emailItem.email}\n");
                        }
                        //WriteLine("");
                    }
                    ReadKey();
                    return true;
                    //break;


                case 6:

                    WriteLine("Informe o ID da pessoa:");
                    int idPessoa = int.Parse(ReadLine());
                    pessoa = context.Pessoas.
                        Include(p => p.Emails).FirstOrDefault(p => p.Id == idPessoa);
                    WriteLine(pessoa.Nome);
                    foreach (Email emailItem in pessoa.Emails)
                    {
                        WriteLine($" ---- Email: {emailItem.email}");
                    }
                    WriteLine("");
                    ReadKey();
                    return true;
                    //break;

                case 0:
                    return false;

                default:
                    return false;
            }
        }
    }
}
