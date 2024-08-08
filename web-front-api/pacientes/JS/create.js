function enviar(){
    const nome = document.querySelector('#nome');
    const dtnasc = document.querySelector('#dtnasc');

    let msg = '';
    if(nome.value === ''){
        msg += 'Nome;\n';
    }
    if(dtnasc.value === ''){
        msg += 'Data de Nascimento;\n';
    }
    if(msg !== '')
    {
        msg = 'Preencha corretamente os dados a seguir: \n' + msg;
        alert(msg);
        return;
    }

    const paciente = {
        Nome: nome.value,
        DataNascimento: dtnasc.value,
    }

    fetch('https://localhost:44319/api/pacientes',{
        method: 'post',
        headers: {'content-type':'application/json'},
        body : JSON.stringify(paciente)
    }).then(
        () => {
            alert('Paciente cadastrado com Sucesso!');
            voltar();
    });
}

function voltar(){
    document.location = './index.html'
}