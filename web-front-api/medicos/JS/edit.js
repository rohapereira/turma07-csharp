window.onload = () => {
    const id = new URLSearchParams(document.location.search).get('id');
    if (id) {
        fetch(`https://localhost:44319/api/medicos/${id}`)
            .then(response => {
                if (!response.ok) {
                    throw new Error('Erro na resposta da API');
                }
                return response.json();
            })
            .then(mostra => {
                if (mostra && mostra.Id && mostra.CRM && mostra.Nome) {
                    document.getElementById('id').value = mostra.Id;
                    document.getElementById('crm').value = mostra.CRM;
                    document.getElementById('nome').value = mostra.Nome;
                } else {
                    alert('Dados do médico não encontrados');
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
    const crm = document.querySelector('#crm');
    const nome = document.querySelector('#nome');
    
    if (!id.value || !crm.value || !nome.value ) {
        alert('Preencha todos os campos!');
        return;
    }
    
    const medico = {
        Id: id.value,
        CRM: crm.value,
        Nome: nome.value
    };
    
    fetch(`https://localhost:44319/api/medicos/${id.value}`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(medico)
    })
    .then(response => {
        if (response.ok) {
            alert('Médico atualizado com sucesso!');
            voltar();
        } else {
            throw new alert('Erro na atualização do médico');
        }
    })
    .catch(() => {
        alert('Erro ao atualizar dados');
    });
}

function excluir(){
    const id = document.querySelector('#id').value;

    if (!id) {
        alert('ID do médico não encontrado.');
        return;
    }

    if (confirm('Você tem certeza de que deseja deletar este médico?')) {
        fetch(`https://localhost:44319/api/medicos/${id}`, {
            method: 'delete',
            headers: { 'Content-Type': 'application/json' }
        })
        .then(response => {
            if (response.ok) {
                alert('Médico deletado com sucesso!');
                voltar();

            } else {
                throw new alert('Erro na exclusão do médico');
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