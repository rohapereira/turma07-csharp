function pesquisar(){
    var fetchString = criarFetchString()
    if (fetchString) { // Verifica se a URL de busca foi criada corretamente
        chamarApi(fetchString);
        limparCampos();
    }
}

function criarFetchString(){
    const id = document.querySelector('#id');
    const crm = document.querySelector('#crm');
    const nome = document.querySelector('#nome');

    console.log(id.value)
    console.log(crm.value)
    console.log(nome.value)

    let fetchString = 'https://localhost:44319/api/medicos/';

    if(id.value != ''){
        fetchString += `${id.value}`;
    } else {
        let params = [];
        if(nome.value != ''){ 
            if (nome.value.length < 3) {
                alert("O nome deve ter no mínimo 3 caracteres");
                return null;
            }
            params.push(`nome=${nome.value}`);
        }
        if(crm.value != ''){ 
            params.push(`crm=${crm.value}`);
        }
        if(params.length > 0) {
            fetchString += `?${params.join('&')}`;
        }
    }

    console.log(fetchString);
    return fetchString
}

function chamarApi(fetchString){
    fetch(fetchString)
        .then((response) => {
            console.log(response);
            if (response.ok) {
                return response.json();
            } else {
                alert('Médico não cadastrado!');
                return null;
            }
        })
        .then(resposta => {
            if (resposta) {
                if (Array.isArray(resposta) && resposta.length > 0) {
                    injetarMedicos(resposta);
                } else if (!Array.isArray(resposta) && resposta != null) {
                    injetarMedico(resposta);
                } else {
                    alert('Médico não cadastrado!');
                }
            }
        });
}

function limparCampos(){
    document.querySelector('#id').value = '';
    document.querySelector('#crm').value = '';
    document.querySelector('#nome').value = '';
}

function injetarMedico(jsonMedico){
    let conteudo = '';

    conteudo +=
    `<tr>
        <td><a href="./edit.html?id=${jsonMedico.Id}">${jsonMedico.Id}</a></td>
        <td>${jsonMedico.CRM}</td>
        <td>${jsonMedico.Nome}</td>
    </tr>`

    document.querySelector("[data-list]").innerHTML = conteudo;
}

function injetarMedicos(jsonMedicos){
    let conteudo = '';

    jsonMedicos.forEach(medico => {
        conteudo +=
        `<tr>
            <td><a href="./edit.html?id=${medico.Id}">${medico.Id}</a></td>
            <td>${medico.CRM}</td>
            <td>${medico.Nome}</td>
        </tr>`
    });

    document.querySelector("[data-list]").innerHTML = conteudo;
}

function novo(){
    document.location = './create.html';
}