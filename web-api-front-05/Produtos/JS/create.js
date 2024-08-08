function enviar(){
    const nome = document.querySelector('#nome');
    const estoque = document.querySelector('#estoque');

    let msg = '';
    if(nome.value === ''){
        msg += 'Nome;\n';
    }
    if(estoque.value === ''){
        msg += 'Estoque;\n';
    }
    if(msg !== '')
    {
        msg = 'Preencha corretamente os dados a seguir: \n' + msg;
        alert(msg);
        return;
    }

    const produto = {
        Nome: nome.value,
        Estoque: estoque.value
    }

    fetch('https://localhost:44352/api/produtos',{
        method: 'post',
        headers: {'content-type':'application/json'},
        body : JSON.stringify(produto)
    }).then(
        () => {
            alert('Produto cadastrado com Sucesso!');
            voltar();
    });
}

function voltar(){
    document.location = './index.html'
}