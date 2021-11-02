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
var texto = "";
var numero = 1;
while (numero < 10) {
    texto += numero + " ";
    numero++;
}
alert(texto);


