function enviar(){
    const crm = document.querySelector('#crm');
    const nome = document.querySelector('#nome');

    let msg = '';
    if(crm.value === ''){
        msg += 'CRM;\n';
    }
    if(nome.value === ''){
        msg += 'Nome;\n';
    }
    if(msg !== '')
    {
        msg = 'Preencha corretamente os dados a seguir: \n' + msg;
        alert(msg);
        return;
    }

    const medico = {
        CRM: crm.value,
        Nome: nome.value
    }

    fetch('https://localhost:44319/api/medicos',{
        method: 'post',
        headers: {'content-type':'application/json'},
        body : JSON.stringify(medico)
    }).then(
        () => {
            alert('Médico cadastrado com Sucesso!');
            voltar();
    });
}

function voltar(){
    document.location = './index.html'
}