// alert("oi");

// var numero = 1;
// //comparação normal(compara os valores)
// if (numero == "1") {
//   alert("== compara apenas os valores");
// }

// var mensagem;
// if (numero === "'") {
//   //resultado: false
//   mensagem = "Nunca executa";
// } else {
//   mensagem = "Number é diferente de String com o ===";
// }

// /*
// Operador ternario(versão reduzida do IF)
// condição ? se_verdadeiro : se_false ;
// */
// var x = (numero === "1") ? "nunca executa" : "Number é diferente de String com o ===";

// var laranja = 6;
// switch (laranja) {
//   case 3:
//     alert("Fazer um copo de suco");
//     break;

//   case 6:
//     alert("Fazer dois copos de suco");
//     break;

//   case 9:
//     alert("Fazer uma jarra de suco");
//     break;
//   default:
//     alert("fazer quanto suco for possivel");
// }

// var pessoas = ["joão", "José","Maria","Sebastião","Antonio"];

// for(var i=0; i<pessoas.length; i++){
//     alert(pessoas[i]);
// }

// var nome="";
// var pessoa = {nome:"iara", sobrenome:"Almeida"};
// for (x in pessoa){
//     nome+= pessoa[x] + " ";
// }
// alert(nome);
//Exercicio 1

// for(var i = 2; i<10 ; i++){
//     if(i%2 != 0){
//         alert(i)
//     }
// }

//exercicio 2
// var soma=0;
// for (var i = 1; i <= 100; i++) {
//   soma = i + soma;
// }
// alert(soma);

function meaperte(){
    alert("Você me apertou :)");
}

function naomeaperte(){
    alert("porque voce me apertou?????, baka :(");
}

function funcaoNome(){
    var x = document.getElementById("nome");
    x.value = x.value.toUpperCase();
}

function funcaoNomeIdade(){
    var nome= document.getElementById("nome");
    var idade = document.getElementById("idade");

    alert(nome.value + " tem "+idade.value + " anos" );
}
function funcaoSoma(){
    var num1= document.getElementById("num1");
    var num2 = document.getElementById("num2");
    
    var soma=parseInt(num1.value) + parseInt(num2.value);
    alert( soma);
}

function funcaoSomaCor(){
    var num1= document.getElementById("num1");
    var num2 = document.getElementById("num2");
    var botao = document.getElementsById("botao1");
    var soma=parseInt(num1.value) + parseInt(num2.value);
    alert( soma);
    if(soma%2 === 0){
       Document.getElementById("botao1").style.backgroundColor = "green";
    }
    else{
        botao.style.backgroundColor = "green";
    }
    
}
