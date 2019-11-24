// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $('#TabelaD').DataTable({
        "language": {
            "lengthMenu": "Mostrando _MENU_ Registros por página",
            "zeroRecords": "Nada encontrado - Desculpe",
            "info": "Mostrando página _PÁGINA_ DE _PÁGINAS_",
            "infoEmpty": "Nenhum registro disponível",
            "infoFiltered": "(Filtrado de _MAX_ regístros no total)"
        }

    });
});

function verImagem() {
    var oFReader = new FileReader();
    oFReader.readAsDataURL(document.getElementById("Imagem").files[0]);
    oFReader.onload = function (oFREvent) {
        document.getElementById("imgPreview").src = oFREvent.target.result;
    };
}

function editarAluno(id) {
    location.href = '/Aluno/Edit?id=' + id;
}

function apagarAluno(id) {
    if (confirm('Deseja realmente excluir o registro?')) {
        location.href = '/Aluno/Delete?id=' + id;
    }
}

function editarProfessor(id) {
    location.href = '/Professor/Edit?id=' + id;
}

function apagarProfessor(id) {
    if (confirm('Deseja realmente excluir o registro?')) {
        location.href = '/Professor/Delete?id=' + id;
    }
}

function editarDisciplina(id) {
    location.href = '/Disciplina/Edit?id=' + id;
}

function apagarDisciplina(id) {
    if (confirm('Deseja realmente apagar o registro?')) {
        location.href = '/Disciplina/Delete?id=' + id;
    }
}