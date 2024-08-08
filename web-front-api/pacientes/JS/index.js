function pesquisar(){
    var fetchString = criarFetchString()
    chamarApi(fetchString)
    limparCampos();
}

function criarFetchString(){
    const codigo = document.querySelector('#codigo');
    const nome = document.querySelector('#nome');

    console.log(codigo.value)
    console.log(nome.value)

    fetchString = 'https://localhost:44319/api/pacientes/';

    if(codigo.value != ''){
        fetchString += `${codigo.value}`;
    } else {
        if(nome.value != ''){ 
            if (nome.value.length < 3) {
                alert("O nome deve ter no mínimo 3 caracteres");
                return null;
            }
            fetchString += `?nome=${nome.value}&`;
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
                alert('Paciente não cadastrado!');
                return null;
            }
        })
        .then(resposta => {
            if (resposta) {
                if (Array.isArray(resposta) && resposta.length > 0) {
                    injetarPacientes(resposta);
                } else if (!Array.isArray(resposta) && resposta != null) {
                    injetarPaciente(resposta);
                } else {
                    alert('Paciente não cadastrado!');
                }
            }
        });
}

function limparCampos(){
    document.querySelector('#codigo').value = '';
    document.querySelector('#nome').value = '';
}

function injetarPaciente(jsonPaciente){
    let conteudo = '';

    conteudo +=
    `<tr>
        <td><a href="./edit.html?id=${jsonPaciente.Codigo}">${jsonPaciente.Codigo}</a></td>
        <td>${jsonPaciente.Nome}</td>
        <td>${jsonPaciente.DataNascimento}</td>
    </tr>`

    document.querySelector("[data-list]").innerHTML = conteudo;
}

function injetarPacientes(jsonPacientes){
    let conteudo = '';

    jsonPacientes.forEach(paciente => {
        conteudo +=
        `<tr>
            <td><a href="./edit.html?id=${paciente.Codigo}">${paciente.Codigo}</a></td>
            <td>${paciente.Nome}</td>
            <td>${paciente.DataNascimento}</td>
        </tr>`
    });

    document.querySelector("[data-list]").innerHTML = conteudo;
}

function novo(){
    document.location = './create.html';
}