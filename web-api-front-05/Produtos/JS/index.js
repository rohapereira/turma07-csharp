let paginaAtual = 1;
const linhasPorPagina = 10;
let todosProdutos = [];

function pesquisar() {
    var fetchString = criarFetchString();
    if (fetchString) {
        chamarApi(fetchString);
        limparCampos();
    }
}

function criarFetchString() {
    const id = document.querySelector('#id');
    const nome = document.querySelector('#nome');

    fetchString = 'https://localhost:44352/api/produtos/';

    if (id.value != '') {
        fetchString += `${id.value}`;
    } else {
        if (nome.value != '') {
            if (nome.value.length < 3) {
                alert("O nome deve ter no mínimo 3 caracteres");
                return null;
            }
            fetchString += `?nome=${nome.value}&`;
        }
    }

    return fetchString;
}

function chamarApi(fetchString) {
    fetch(fetchString)
        .then((response) => {
            if (response.ok) {
                return response.json();
            } else {
                alert('Produto não cadastrado!');
                return null;
            }
        })
        .then(resposta => {
            if (resposta) {
                if (Array.isArray(resposta) && resposta.length > 0) {
                    todosProdutos = resposta;
                    renderizarTabela(paginaAtual);
                } else if (!Array.isArray(resposta) && resposta != null) {
                    injetarProduto(resposta);
                } else {
                    alert('Produto não cadastrado!');
                }
            }
        });
}

function limparCampos() {
    document.querySelector('#id').value = '';
    document.querySelector('#nome').value = '';
}

function injetarProduto(jsonProduto) {
    let conteudo = '';

    conteudo +=
        `<tr>
            <td><a href="./edit.html?id=${jsonProduto.Id}">${jsonProduto.Id}</a></td>
            <td>${jsonProduto.Nome}</td>
            <td>${jsonProduto.Estoque}</td>
        </tr>`;

    document.querySelector("[data-list]").innerHTML = conteudo;
}

function injetarProdutos(produtos) {
    let conteudo = '';

    produtos.forEach(produto => {
        conteudo +=
            `<tr>
                <td><a href="./edit.html?id=${produto.Id}">${produto.Id}</a></td>
                <td>${produto.Nome}</td>
                <td>${produto.Estoque}</td>
            </tr>`;
    });

    document.querySelector("[data-list]").innerHTML = conteudo;
}

function renderizarTabela(pagina) {
    const inicio = (pagina - 1) * linhasPorPagina;
    const fim = inicio + linhasPorPagina;
    const itensPaginados = todosProdutos.slice(inicio, fim);
    injetarProdutos(itensPaginados);
    renderizarPaginacao();
}

function renderizarPaginacao() {
    const numerosPaginas = document.getElementById('numerosPaginas');
    numerosPaginas.innerHTML = '';
    const totalPaginas = Math.ceil(todosProdutos.length / linhasPorPagina);

    for (let i = 1; i <= totalPaginas; i++) {
        const numeroPagina = document.createElement('button');
        numeroPagina.className = 'pure-button';
        numeroPagina.innerText = i;
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
    const totalPaginas = Math.ceil(todosProdutos.length / linhasPorPagina);
    if (paginaAtual < totalPaginas) {
        paginaAtual++;
        renderizarTabela(paginaAtual);
    }
};

function novo() {
    document.location = './create.html';
}