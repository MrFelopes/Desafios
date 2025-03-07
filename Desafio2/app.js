const apiBaseUrl = "https://localhost:7082/api/endereco"; //Caso necessário, alterar para a porta designada da API

async function buscarEndereco() {
    const cep = document.getElementById("cep").value;
    if (!cep) {
        alert("Digite um CEP válido!");
        return;
    }

    const response = await fetch(`${apiBaseUrl}/buscar/${cep}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json' 
        },
        credentials: 'include'  
    });
    const data = await response.json();

    if (response.ok) {
        alert(`Endereço encontrado: ${data.logradouro}, ${data.bairro}, ${data.localidade} - ${data.uf}`);
        listarEnderecos();
    } else {
        alert("CEP não encontrado!");
    }
}

async function listarEnderecos(ordenarPor = "", ordem = "asc") {
    const response = await fetch(`${apiBaseUrl}/listar?ordenarPor=${ordenarPor}&ordem=${ordem}`, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'  
        },
        credentials: 'include' 
    });
    const enderecos = await response.json();

    const lista = document.getElementById("enderecos");
    lista.innerHTML = "";

    enderecos.forEach(endereco => {
        const item = document.createElement("li");
        item.textContent = `${endereco.logradouro}, ${endereco.bairro}, ${endereco.localidade} - ${endereco.uf}`;
        lista.appendChild(item);
    });
}

listarEnderecos();
