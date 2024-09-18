document.querySelector('#btnEnviar').onclick = enviar
document.querySelector('#btnVoltar').onclick = voltar

function coletarNome(){
    return document.querySelector('#nome')
}

function coletarPreco(){
    return document.querySelector('#preco')
}

function coletarValidade(){
    return document.querySelector('#validade')
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

function enviar(){

    const nome = coletarNome().value
    const preco = coletarPreco().value
    const validade = coletarValidade().value

    const vegetal = {
        Nome: nome,
        Preco: preco,
        Validade: validade
    }

    if(validarDadosExibirMensagem(vegetal)){
        
        const url = 'https://localhost:44332/api/vegetais'

        fetch(url, {
            method: 'post',
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

function voltar(){
    document.location = './index.html'
}