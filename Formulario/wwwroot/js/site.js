document.getElementById("cep").addEventListener("blur", function () {
    var cep = this.value.replace(/\D/g, '');
    if (cep.length === 8) {
        fetch(`https://viacep.com.br/ws/${cep}/json/`)
            .then(response => response.json())
            .then(data => {
                if (!data.erro) {
                    document.getElementById("logradouro").value = data.logradouro;
                    document.getElementById("bairro").value = data.bairro;
                    document.getElementById("cidade").value = data.localidade;
                    // Se necessário, limpar o campo complemento
                    document.getElementById("complemento").value = data.complemento || '';
                } else {
                    alert("CEP não encontrado.");
                }
            })
            .catch(error => {
                console.error("Erro ao buscar o CEP: ", error);
                alert("Erro ao buscar o CEP.");
            });
    }
});