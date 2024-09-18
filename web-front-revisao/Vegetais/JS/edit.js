document.querySelector('#btnAlterar').onclick = alterar
document.querySelector('#btnVoltar').onclick = voltar
document.querySelector('#btnExcluir').onclick = desejaExcluir

window.onload = () => {
    const id = new URLSearchParams(document.location.search).get('id')
    pesquisarPorid(id)    
}

function pesquisarPorid(id){
    const url = `https://localhost:44332/api/vegetais/${id}`
    pesquisar(url)
}

function pesquisar(url){
    fetch(url)
        .then(response => {
            if (response.status === 200)
                return response.json();
            if (response.status === 404)
                return null;
            return;
        })
        .then(vegetal => {
            if(vegetal !== undefined){
                if(vegetal !== null){
                    injetarVegetal(vegetal)
                }
                else{
                    alert('Nenhum vegetal foi encontrado')
                    voltar()
                }
            }
            else{
                alert('Erro interno no servidor! \nEntre em contato com o suporte!')
                voltar()
            }
        })
        .catch(() => {
            alert('Falha na requisição. \nEntre em contato com o suporte!')
        })
}
 
function injetarVegetal(vegetal){
    const id = pegarId()
    const nome = pegarNome()
    const preco = pegarPreco()
    const validade = pegarValidade()

    id.value = vegetal.Id
    nome.value = vegetal.Nome
    preco.value = vegetal.Preco
    validade.value = vegetal.Validade.substr(0,10)
}

function alterar(){
    const id = pegarId()
    const nome = pegarNome()
    const preco = pegarPreco()
    const validade = pegarValidade()

    const vegetal = {
        Id: id.value,
        Nome: nome.value,
        Preco: preco.value,
        Validade: validade.value
    }

    if(validarDadosExibirMensagem(vegetal)){

        const url = `https://localhost:44332/api/vegetais/${vegetal.Id}`

        fetch(url, {
            method: 'put',
            headers: {'content-type':'application/json'},
            body: JSON.stringify(vegetal)
        })
            .then(response => {
                if(response.status === 200) {
                    alert('Vegetal cadastrado com SUCESSO!')
                    voltar()
                } else if (response.status === 400) {
                    alert('Verifique os dados que estão sendo enviados!')
                } else if (response.status === 500) {
                    alert('Erro interno no servidor! \nEntre em contato com o suporte por favor!')
                }
            })
            .catch( () => 
                alert('Falha na requisição. \nEntre em contato com o suporte')
            )
    }
}

function validarDadosExibirMensagem(vegetal){
    let msg = ''
    if(vegetal.Nome === ''){
        msg += 'Nome;\n'
    }
    if(vegetal.Preco === ''){
        msg += 'Preco;\n'
    }    
    if(vegetal.Validade === ''){
        msg += 'Validade;\n'
    }
    if(msg !== ''){
        msg = 'Preencha corretamente os dados a seguir: \n' + msg
        alert(msg)
        return false
    }

    return true
}

function desejaExcluir(){
    const id = pegarId()
    const nome = pegarNome()
    if(confirm(`Deseja excluir o vegetal ${nome.value} ?`))
        excluir(id.value)
}

function excluir(id){
    const url = `https://localhost:44332/api/vegetais/${id}`

    fetch(url, {
        method: 'delete'
    })
        .then(response => {
            if (response.status === 200) {
                alert('Vegetal excluído com sucesso!')
                voltar();
            } else if (response.status === 404) {
                alert('Não foi possível excluir o Vegetal, pois o mesmo não foi encontrado!')
                voltar();
            } else if (response.status === 500) {
                alert('Erro interno no servidor!\nEntre em contato com o suporte!')
            }
        })
        .catch(() =>
            alert('Falha na requisição.\nEntre em contato com o suporte!')
        );
}

function voltar(){
    document.location = './index.html'
}


function pegarId(){
    return document.querySelector('#id')
}

function pegarNome(){
    return document.querySelector('#nome')
 
}

function pegarPreco(){
    return document.querySelector('#preco')
}

function pegarValidade(){
    return document.querySelector('#validade')
}