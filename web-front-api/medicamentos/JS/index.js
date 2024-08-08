function pesquisar(){
    var fetchString = criarFetchString()
    chamarApi(fetchString)
    limparCampos();
}

function criarFetchString(){
    const id = document.querySelector('#id');
    const nome = document.querySelector('#nome');

    console.log(id.value)
    console.log(nome.value)

    fetchString = 'https://localhost:44319/api/medicamentos/';

    if(id.value != ''){
        fetchString += `${id.value}`;
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
                alert('Medicamento não cadastrado!');
                return null;
            }
        })
        .then(resposta => {
            if (resposta) {
                if (Array.isArray(resposta) && resposta.length > 0) {
                    injetarMedicamentos(resposta);
                } else if (!Array.isArray(resposta) && resposta != null) {
                    injetarMedicamento(resposta);
                } else {
                    alert('Medicamento não cadastrado!');
                }
            }
        });
}

function limparCampos(){
    document.querySelector('#id').value = '';
    document.querySelector('#nome').value = '';
}

function injetarMedicamento(jsonMedicamento){
    let conteudo = '';

    conteudo +=
    `<tr>
        <td><a href="./edit.html?id=${jsonMedicamento.Id}">${jsonMedicamento.Id}</a></td>
        <td>${jsonMedicamento.Nome}</td>
        <td>${jsonMedicamento.DataDeFabricacao}</td>
        <td>${jsonMedicamento.DataDeVencimento}</td>
    </tr>`

    document.querySelector("[data-list]").innerHTML = conteudo;
}

function injetarMedicamentos(jsonMedicamentos){
    let conteudo = '';

    jsonMedicamentos.forEach(medicamento => {
        conteudo +=
        `<tr>
            <td><a href="./edit.html?id=${medicamento.Id}">${medicamento.Id}</a></td>
            <td>${medicamento.Nome}</td>
            <td>${medicamento.DataDeFabricacao}</td>
            <td>${medicamento.DataDeVencimento}</td>
        </tr>`
    });

    document.querySelector("[data-list]").innerHTML = conteudo;
}

function novo(){
    document.location = './create.html';
}