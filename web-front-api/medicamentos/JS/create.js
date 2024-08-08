function enviar(){
    const nome = document.querySelector('#nome');
    const dtfab = document.querySelector('#dtfab');
    const dtvenc = document.querySelector('#dtvenc');

    let msg = '';
    if(nome.value === ''){
        msg += 'Nome;\n';
    }
    if(dtfab.value === ''){
        msg += 'Data de Fabricação;\n';
    }
    if(dtvenc.value !== '' && dtfab.value > dtvenc.value){
        msg += 'Data de Fabricação não pode ser maior que a data de vencimento;\n';
    }
    if(msg !== '')
    {
        msg = 'Preencha corretamente os dados a seguir: \n' + msg;
        alert(msg);
        return;
    }

    const medicamento = {
        Nome: nome.value,
        DataDeFabricacao: dtfab.value,
        DataDeVencimento: dtvenc.value
    }

    fetch('https://localhost:44319/api/medicamentos',{
        method: 'post',
        headers: {'content-type':'application/json'},
        body : JSON.stringify(medicamento)
    }).then(
        () => {
            alert('Medicamento cadastrado com Sucesso!');
            voltar();
    });
}

function voltar(){
    document.location = './index.html'
}