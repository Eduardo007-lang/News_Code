var agora = new Date();
var hora = agora.getHours();

console.log(`Agora são exatamente ${hora} hrs`)

if (hora < 6){

    console.log('Boa madrugada!')
}

else if(hora < 12){

    console.log('Bom Dia!')
}
else if(hora <= 18 ){

    console.log('Boa tarde!')

}
else if(hora <= 24 ){
    
    console.log('Boa noite!')
}

