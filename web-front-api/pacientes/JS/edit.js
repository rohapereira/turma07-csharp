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
    const id = new URLSearchParams(document.location.search).get('codigo');
    if (id) {
        fetch(`https://localhost:44319/api/pacientes/${id}`)
            .then(response => {
                if (!response.ok) {
                    throw new Error('Erro na resposta da API');
                }
                return response.json();
            })
            .then(mostra => {
                if (mostra && mostra.Codigo && mostra.Nome) {
                    document.getElementById('codigo').value = mostra.Codigo;
                    document.getElementById('nome').value = mostra.Nome;

                    document.getElementById('dtnasc').value = formatDateForInput(mostra.DataNascimento);
                } else {
                    alert('Dados do paciente não encontrados');
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
    const dtnasc = document.querySelector('#dtnasc');
    
    if (!id.value || !nome.value || !dtnasc.value ) {
        alert('Preencha todos os campos!');
        return;
    }
    
    const paciente = {
        Codigo: id.value,
        Nome: nome.value,
        DataNascimento: dtnasc.value,
    };
    
    fetch(`https://localhost:44319/api/pacientes/${id.value}`, {
        method: 'put',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(paciente)
    })
    .then(response => {
        if (response.ok) {
            alert('Paciente atualizado com sucesso!');
            voltar();
        } else {
            throw new alert('Erro na atualização do paciente');
        }
    })
    .catch(() => {
        alert('Erro ao atualizar dados');
    });
}

function excluir(){
    const id = document.querySelector('#id').value;

    if (!id) {
        alert('ID do paciente não encontrado.');
        return;
    }

    if (confirm('Você tem certeza de que deseja deletar este paciente?')) {
        fetch(`https://localhost:44319/api/pacientes/${id}`, {
            method: 'delete',
            headers: { 'Content-Type': 'application/json' }
        })
        .then(response => {
            if (response.ok) {
                alert('Paciente deletado com sucesso!');
                voltar();

            } else {
                throw new alert('Erro na exclusão do paciente');
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