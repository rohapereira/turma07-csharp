let paginaAtual = 1;
const linhasPorPagina = 10;
let todosPacientes = []; // Variável correta para armazenar os pacientes

function pesquisar(){
    var fetchString = criarFetchString();
    if (fetchString) {
        chamarApi(fetchString);
        limparCampos();
    }
}

function criarFetchString(){
    const codigo = document.querySelector('#codigo');
    const nome = document.querySelector('#nome');

    let fetchString = 'https://localhost:44319/api/pacientes/';

    if(codigo.value != ''){
        fetchString += `${codigo.value}`;
    } else {
        if(nome.value != ''){ 
            if (nome.value.length < 3) {
                alert("O nome deve ter no mínimo 3 caracteres");
                return null;
            }
            fetchString += `?nome=${nome.value}`;
        }
    }

    console.log(fetchString);
    return fetchString;
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
                    todosPacientes = resposta; // Armazena os pacientes na variável correta
                    renderizarTabela(paginaAtual);
                } else if (!Array.isArray(resposta) && resposta != null) {
                    todosPacientes = [resposta]; // Coloca o único paciente em um array para paginar corretamente
                    renderizarTabela(paginaAtual);
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
    let conteudo = `
    <tr>
        <td><a href="./edit.html?id=${jsonPaciente.Codigo}">${jsonPaciente.Codigo}</a></td>
        <td>${jsonPaciente.Nome}</td>
        <td>${jsonPaciente.DataNascimento}</td>
    </tr>`;

    document.querySelector("[data-list]").innerHTML = conteudo;
}

function injetarPacientes(jsonPacientes){
    let conteudo = '';

    jsonPacientes.forEach(paciente => {
        conteudo += `
        <tr>
            <td><a href="./edit.html?id=${paciente.Codigo}">${paciente.Codigo}</a></td>
            <td>${paciente.Nome}</td>
            <td>${paciente.DataNascimento}</td>
        </tr>`;
    });

    document.querySelector("[data-list]").innerHTML = conteudo;
}

function renderizarTabela(pagina) {
    const inicio = (pagina - 1) * linhasPorPagina;
    const fim = inicio + linhasPorPagina;
    const itensPaginados = todosPacientes.slice(inicio, fim); // Usar todosPacientes
    injetarPacientes(itensPaginados);
    renderizarPaginacao();
}

function renderizarPaginacao() {
    const numerosPaginas = document.getElementById('numerosPaginas');
    numerosPaginas.innerHTML = '';
    const totalPaginas = Math.ceil(todosPacientes.length / linhasPorPagina); // Usar todosPacientes

    for (let i = 1; i <= totalPaginas; i++) {
        const numeroPagina = document.createElement('button');
        numeroPagina.className = 'pure-button';
        numeroPagina.innerText = i;
        if (i === paginaAtual) {
            numeroPagina.classList.add('active'); // Adiciona a classe 'active' à página atual
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
    const totalPaginas = Math.ceil(todosPacientes.length / linhasPorPagina); // Usar todosPacientes
    if (paginaAtual < totalPaginas) {
        paginaAtual++;
        renderizarTabela(paginaAtual);
    }
};

function novo(){
    document.location = './create.html';
}
