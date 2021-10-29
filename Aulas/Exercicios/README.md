### Exercício 1:

Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e armazene em um novo vetor primeiramente todos os números pares lidos e após todos os ímpares. 

**Exemplo:**
              a. lê: |7|40|3|9|21|0|63|31|7|22|
              b. escreve: |40|0|22|7|3|9|21|63|31|7|

```C#
static void Ex1()
        {
            int[] par = new int[10], impar = new int[10];
            int valor, countPar = 0, countImpar = 0;
            for (int i = 0; i < 10; i++)
            {
                Random rand = new();
                Write("Digite um o {0}º número: ", i + 1);
                valor = rand.Next(1,10);
                if (valor % 2 == 0)
                {
                    par[countPar] = valor;
                    countPar += 1;
                }
                else
                {
                    impar[countImpar] = valor;
                    countImpar += 1;
                }
            }
            WriteLine("\nDe todos os números digitados, {0} são pares e {1} são ímpares!\n", countPar, countImpar);
            for (int i = 0; i < countPar; i++)
            {
                Write(" {0} |", par[i]);
            }
            for (int i = 0; i < countImpar; i++)
            {
                Write(" {0} |", impar[i]);
            }
        }
```



### Exercício 2:

Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo os valores nulos por 2. 

Mostre os vetores lidos e o vetor resultado.

```

```











