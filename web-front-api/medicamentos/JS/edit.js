function formatDateForInput(dateString) {
    if (!dateString) {
        return '';
    }
    const date = new Date(dateString);
    const day = String(date.getDate()).padStart(2, '0');
    const month = String(date.getMonth() + 1).padStart(2, '0');
    const year = date.getFullYear();
    return `${year}-${month}-${day}`;
}

window.onload = () => {
    const id = new URLSearchParams(document.location.search).get('id');
    if (id) {
        fetch(`https://localhost:44319/api/medicamentos/${id}`)
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

                    document.getElementById('dtfab').value = formatDateForInput(mostra.DataDeFabricacao);
                    document.getElementById('dtvenc').value = formatDateForInput(mostra.DataDeVencimento);
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
    const dtfab = document.querySelector('#dtfab');
    const dtvenc = document.querySelector('#dtvenc');
    
    if (!id.value || !nome.value || !dtfab.value ) {
        alert('Preencha todos os campos!');
        return;
    }
    
    const medicamento = {
        Id: id.value,
        Nome: nome.value,
        DataDeFabricacao: dtfab.value,
        DataDeVencimento: dtvenc.value || null
    };
    
    fetch(`https://localhost:44319/api/medicamentos/${id.value}`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(medicamento)
    })
    .then(response => {
        if (response.ok) {
            alert('Medicamento atualizado com sucesso!');
            voltar();
        } else {
            throw new alert('Erro na atualização do medicamento');
        }
    })
    .catch(() => {
        alert('Erro ao atualizar dados');
    });
}

function excluir(){
    const id = document.querySelector('#id').value;

    if (!id) {
        alert('ID do medicamento não encontrado.');
        return;
    }

    if (confirm('Você tem certeza de que deseja deletar este medicamento?')) {
        fetch(`https://localhost:44319/api/medicamentos/${id}`, {
            method: 'delete',
            headers: { 'Content-Type': 'application/json' }
        })
        .then(response => {
            if (response.ok) {
                alert('Medicamento deletado com sucesso!');
                voltar();

            } else {
                throw new alert('Erro na exclusão do medicamento');
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