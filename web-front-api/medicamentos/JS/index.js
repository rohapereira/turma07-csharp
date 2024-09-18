let paginaAtual = 1;
const linhasPorPagina = 10;
let todosMedicamentos = []; // Certifique-se de que todosMedicamentos está declarada

function pesquisar(){
    var fetchString = criarFetchString();
    if (fetchString) {
        chamarApi(fetchString);
        limparCampos();
    }
}

function criarFetchString(){
    const id = document.querySelector('#id');
    const nome = document.querySelector('#nome');

    let fetchString = 'https://localhost:44319/api/medicamentos/';

    if(id.value !== ''){
        fetchString += `${id.value}`;
    } else if(nome.value !== '') { 
        if (nome.value.length < 3) {
            alert("O nome deve ter no mínimo 3 caracteres");
            return null;
        }
        fetchString += `?nome=${nome.value}&`;
    }

    return fetchString;
}

function chamarApi(fetchString){
    fetch(fetchString)
        .then((response) => {
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
                    todosMedicamentos = resposta; // Atribua a todosMedicamentos corretamente
                    renderizarTabela(paginaAtual);
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
    let conteudo = `
        <tr>
            <td><a href="./edit.html?id=${jsonMedicamento.Id}">${jsonMedicamento.Id}</a></td>
            <td>${jsonMedicamento.Nome}</td>
            <td>${jsonMedicamento.DataDeFabricacao}</td>
            <td>${jsonMedicamento.DataDeVencimento}</td>
        </tr>`;
    document.querySelector("[data-list]").innerHTML = conteudo;
}

function injetarMedicamentos(jsonMedicamentos){
    let conteudo = '';

    jsonMedicamentos.forEach(medicamento => {
        conteudo += `
        <tr>
            <td><a href="./edit.html?id=${medicamento.Id}">${medicamento.Id}</a></td>
            <td>${medicamento.Nome}</td>
            <td>${medicamento.DataDeFabricacao}</td>
            <td>${medicamento.DataDeVencimento}</td>
        </tr>`;
    });

    document.querySelector("[data-list]").innerHTML = conteudo;
}

function renderizarTabela(pagina) {
    const inicio = (pagina - 1) * linhasPorPagina;
    const fim = inicio + linhasPorPagina;
    const itensPaginados = todosMedicamentos.slice(inicio, fim);
    injetarMedicamentos(itensPaginados);
    renderizarPaginacao();
}

function renderizarPaginacao() {
    const numerosPaginas = document.getElementById('numerosPaginas');
    numerosPaginas.innerHTML = '';
    const totalPaginas = Math.ceil(todosMedicamentos.length / linhasPorPagina);

    for (let i = 1; i <= totalPaginas; i++) {
        const numeroPagina = document.createElement('button');
        numeroPagina.className = 'pure-button';
        numeroPagina.innerText = i;
        if (i === paginaAtual) {
            numeroPagina.classList.add('active');
        }
        numeroPagina.onclick = () => {
            paginaAtual = i;
            renderizarTabela(paginaAtual);
        };
        numerosPaginas.appendChild(numeroPagina);
    }
}

window.paginaAnterior = function () {
    if (paginaAtual > 1) {
        paginaAtual--;
        renderizarTabela(paginaAtual);
    }
};

window.proximaPagina = function () {
    const totalPaginas = Math.ceil(todosMedicamentos.length / linhasPorPagina);
    if (paginaAtual < totalPaginas) {
        paginaAtual++;
        renderizarTabela(paginaAtual);
    }
};

function novo(){
    document.location = './create.html';
}