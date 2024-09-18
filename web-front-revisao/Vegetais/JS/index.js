document.querySelector('#btnPesquisar').onclick = definirPesquisa;
document.querySelector('#btnNovo').onclick = novo;

function definirPesquisa(){
    let id = pegarId().value
    let nome = pegarNome().value

    if(id !== ''){
        pesquisarPorId(id)
        return 
    }

    if(nome !== ''){
        pesquisarPorNome(nome)
        return 
    }
    
    pesquisarTodos();
    
}

function pesquisarPorId(id){
    const url = `https://localhost:44332/api/vegetais/${id}`
    pesquisar(url)
}

function pesquisarPorNome(nome){
    const url = `https://localhost:44332/api/vegetais?nome=${nome}`
    pesquisar(url)
}

function pesquisarTodos(){
    const url = 'https://localhost:44332/api/vegetais'
    pesquisar(url)
}

function pesquisar(url){
    fetch(url)
        .then(response => {
            if (response.status === 200)
                return response.json()
            if (response.status === 404)
                return []
            return
        })
        .then(jsonVegetais => {
            if(jsonVegetais !== undefined){

                if(!Array.isArray(jsonVegetais))
                    jsonVegetais = [jsonVegetais]

                if(jsonVegetais.lenght !== 0)
                    injetarVegetais(jsonVegetais)
                else
                    alert('Nenhum medicamento foi encontrado!')
            }
            else  
                alert('Erro interno no servior! \n Entre em contato com o suporte!')
            
        })
        .catch(() => {
            alert('Falha na requisição. \n Entre em contato com o suporte!')
        })
}

function injetarVegetais(jsonVegetais){
    let conteudo = ''
    jsonVegetais.forEach(vegetais => {
        conteudo +=
        `<tr>
            <td><a href="./edit.html?id=${vegetais.Id}">${vegetais.Id}</a></td>
            <td>${vegetais.Nome}</td>
            <td>${vegetais.Preco}</td>
            <td>${vegetais.Validade}</td>
        </tr>`
    });
    pegarTabela().innerHTML = conteudo
}

function pegarTabela(){
    return document.querySelector("[data-list]")
}

function pegarId(){
    return document.querySelector('#id')
}

function pegarNome(){
    return document.querySelector('#nome')
}

function novo(){
    document.location = './create.html'
}