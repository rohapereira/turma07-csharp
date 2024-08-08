function validar(){
    const nome = document.querySelector('#nome');
    const email = document.querySelector('#email');
    const dataNascimento = document.querySelector('#dn');
    const motivo1 = document.querySelector('input[name="motivo"]:checked');
    const motivo2 = document.querySelector('#motivo1');
    const descricao = document.querySelector('#descricao');

    let msg = '';
    if(nome.value === ''){
        msg += 'Nome;\n'
    }
    if(email.value === ''){
        msg += 'Email;\n';
    }
    if(dataNascimento.value === ''){
        msg += 'Data Nascimento;\n';
    }
    if(motivo1 === null){
        msg += 'Motivo1;\n';
    }
    if(motivo2.value === 'Selecione'){
        msg += 'Motivo2;\n';
    }
    if(descricao.value === ''){
        msg += 'Descricao;\n';
    }

    if(msg !== ''){
        msg = 'Os dados abaixo são obrigatórios: \n' + msg;
        alert(msg);
        return;
    }

    const contato = {
        nome: nome.value,
        email: email.value,
        dataNascimento: dataNascimento.value,
        motivo1: motivo1,
        motivo2: motivo2.value,
        descricao: descricao.value
    };

    console.log(contato);
}