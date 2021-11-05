/*
alert('Hello World')

var objeto = 
{
    nome: 'Roberto',
    cargo: '.NET Developer'
}

var array = ["C#", "CSS", "HTML","JS"]

var numero = 1;
if (numero == "1") 
{
   alert('True'); 
}
else
{
    alert('False');
}

if (numero === "1") // ==> Compara o tipo e o valor ( ambos devem ser iguais)
{
   alert('True'); 
}
else
{
    alert('False');
}

*/

// var numero = 1;
// if (numero == "1") { //compara os valores/conteúdos
//     alert('True');
// }
// else {
//     alert('False');
// }
// if (numero === "1") {//compara o tipo e o valor (ambos devem ser iguais)
//     alert('True');
// }
// else {
//     alert('False');
// }
// var suco = 3;
// switch (suco) {
//     case 1:
//         alert('fazer 1 copo de suco');
//         break;
//     case 2:
//         alert('fazer meia jarra de suco');
//         break;
//     case 3:
//         alert('Fazer uma jarra de suco');
//         break;
//     default:
//         alert('opção default');
// }
// var alunos = ["Rodrigo", "Eduardo", "Thiago", "Pablo", "Francisco"];
// for (let i = 0; i < alunos.length; i++) {
//     alert(alunos[i]);
// }
/*var texto = "";
var numero = 1;
while (numero < 10) {
    texto += numero + " ";
    numero++;
}
alert(texto);
*/
/*for (let i = 0; i<10;i++){
    if(i%2==0){
        alert(i+' é um número par');
    }
}

var total=0;
for (let i = 0; i<=100;i++)
{
 total += i;   
}
alert(total);*/



// var numero = 1;

// if (numero == "1") { //compara os valores/conteúdos
//     alert('True');
// }
// else {
//     alert('False');
// }

// if (numero === "1") {//compara o tipo e o valor (ambos devem ser iguais)
//     alert('True');
// }
// else {
//     alert('False');
// }



// var suco = 3;

// switch (suco) {
//     case 1:
//         alert('fazer 1 copo de suco');
//         break;
//     case 2:
//         alert('fazer meia jarra de suco');
//         break;
//     case 3:
//         alert('Fazer uma jarra de suco');
//         break;
//     default:
//         alert('opção default');
// }

// var alunos = ["Rodrigo", "Eduardo", "Thiago", "Pablo", "Francisco"];

// for (let i = 0; i < alunos.length; i++) {
//     alert(alunos[i]);
// }


// var texto = "";
// var numero = 1;

// while (numero < 10) {
//     texto += numero + " ";
//     numero++;
// }

// alert(texto);


// for (let i = 0; i <= 10; i++) 
// {
//     if(i%2==0)
//     {
//         alert(i);
//     }
// }


// var total = 0;

// for (let i = 0; i <= 100; i++) {
//     total += i;
// }

// alert(total);




function minhafuncao() 
{
    alert('Hello!');
}


function mostrarPares() 
{
    for (let i = 0; i <= 10; i++) 
    {
        if(i%2==0)
        {
            alert(i);
        }
    }
} 
 
function mostrarSomatorio() 
{
    var total = 0;

    for (let i = 0; i <= 100; i++) 
    {
        total += i;
    }

    alert(total);
}

function deixarcaixaalta()
{
    var x = document.getElementById("nome");
    x.value = x.value.toUpperCase();
    // document.getElementById("nome").value = document.getElementById("nome").valeu.toUpperCase();
}

function mostrarDados()
{
    var nome = document.getElementById("nome").value;
    var idade = document.getElementById("idade").value;

    alert(nome + " tem " + idade + " anos!");
}

function verificarIdade()
{
    var nome = document.getElementById("nome").value;
    var idade = document.getElementById("idade").value;

    if(idade >= 18)
    {
        alert(nome + " é maior de idade!");
    }
    else
    {
        alert(nome + " não é maior de idade!")
    }
}

function somar()
{
    var valor1 = parseInt(document.getElementById("valor1").value);
    var valor2 = parseInt(document.getElementById("valor2").value);

    var soma = valor1 + valor2;
    console.log(soma);
    alert(soma);
}

function somarcor(botao)
{
    var valor1 = parseInt(document.getElementById("valor1").value);
    var valor2 = parseInt(document.getElementById("valor2").value);

    var soma = valor1 + valor2;

    if(soma %2 ==0)
    {
        // document.getElementById("btn").style.background = '#F00';
        botao.style.background = '#F00';
    }
    else
    {
        botao.style.background = '#00F';
    }
}