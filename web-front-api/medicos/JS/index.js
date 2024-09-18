let paginaAtual = 1;
const linhasPorPagina = 10;
let todosMedicos = []; // Variável correta para armazenar os médicos

function pesquisar(){
    var fetchString = criarFetchString();
    if (fetchString) { 
        chamarApi(fetchString);
        limparCampos();
    }
}

function criarFetchString(){
    const id = document.querySelector('#id');
    const crm = document.querySelector('#crm');
    const nome = document.querySelector('#nome');

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

    return fetchString;
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
                    todosMedicos = resposta; // Armazena os médicos na variável correta
                    renderizarTabela(paginaAtual);
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
    let conteudo = `
    <tr>
        <td><a href="./edit.html?id=${jsonMedico.Id}">${jsonMedico.Id}</a></td>
        <td>${jsonMedico.CRM}</td>
        <td>${jsonMedico.Nome}</td>
    </tr>`;

    document.querySelector("[data-list]").innerHTML = conteudo;
}

function injetarMedicos(jsonMedicos){
    let conteudo = '';

    jsonMedicos.forEach(medico => {
        conteudo += `
        <tr>
            <td><a href="./edit.html?id=${medico.Id}">${medico.Id}</a></td>
            <td>${medico.CRM}</td>
            <td>${medico.Nome}</td>
        </tr>`;
    });

    document.querySelector("[data-list]").innerHTML = conteudo;
}

function renderizarTabela(pagina) {
    const inicio = (pagina - 1) * linhasPorPagina;
    const fim = inicio + linhasPorPagina;
    const itensPaginados = todosMedicos.slice(inicio, fim); // Usar todosMedicos
    injetarMedicos(itensPaginados);
    renderizarPaginacao();
}

function renderizarPaginacao() {
    const numerosPaginas = document.getElementById('numerosPaginas');
    numerosPaginas.innerHTML = '';
    const totalPaginas = Math.ceil(todosMedicos.length / linhasPorPagina); // Usar todosMedicos

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
    const totalPaginas = Math.ceil(todosMedicos.length / linhasPorPagina); // Usar todosMedicos
    if (paginaAtual < totalPaginas) {
        paginaAtual++;
        renderizarTabela(paginaAtual);
    }
};

function novo(){
    document.location = './create.html';
}