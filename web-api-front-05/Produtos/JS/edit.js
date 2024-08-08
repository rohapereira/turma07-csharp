window.onload = () => {
    const id = new URLSearchParams(document.location.search).get('id');
    if (id) {
        fetch(`https://localhost:44352/api/produtos/${id}`)
            .then(response => {
                if (!response.ok) {
                    throw new Error('Erro na resposta da API');
                }
                return response.json();
            })
            .then(mostra => {
                if (mostra && mostra.Id && mostra.Nome) {
                    document.getElementById('id').value = mostra.Id;
                    document.getElementById('nome').value = mostra.Nome;
                    document.getElementById('estoque').value = mostra.Estoque;
                } else {
                    alert('Dados do medicamento não encontrados');
                }
            })
            .catch(error => {
                console.error('Erro ao buscar dados:', error);
                alert('Erro ao buscar dados');
            });
    }
};

function alterar() {

    const id = document.querySelector('#id'); 
    const nome = document.querySelector('#nome');
    const estoque = document.querySelector('#estoque');
    
    if (!id.value || !nome.value || !estoque.value ) {
        alert('Preencha todos os campos!');
        return;
    }
    
    const produto = {
        Id: id.value,
        Nome: nome.value,
        Estoque: estoque.value
    };
    
    fetch(`https://localhost:44352/api/produtos/${id.value}`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(produto)
    })
    .then(response => {
        if (response.ok) {
            alert('Produto atualizado com sucesso!');
            voltar();
        } else {
            throw new alert('Erro na atualização do produto');
        }
    })
    .catch(() => {
        alert('Erro ao atualizar dados');
    });
}

function excluir(){
    const id = document.querySelector('#id').value;

    if (!id) {
        alert('ID do produto não encontrado.');
        return;
    }

    if (confirm('Você tem certeza de que deseja deletar este produto?')) {
        fetch(`https://localhost:44352/api/produtos/${id}`, {
            method: 'delete',
            headers: { 'Content-Type': 'application/json' }
        })
        .then(response => {
            if (response.ok) {
                alert('Produto deletado com sucesso!');
                voltar();

            } else {
                throw new alert('Erro na exclusão do produto');
            }
        })
        .catch(() => {
            alert('Erro ao deletar dados:');
        });
    }
}

function voltar(){
    document.location = './index.html'
}