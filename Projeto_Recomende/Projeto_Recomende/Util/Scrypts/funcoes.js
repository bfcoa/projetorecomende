function Comentar(cod_filme) {
    var Paramters = "{teste:'teste'}";
    $.ajax({
        type: 'POST',
        url: "JqueryHandler.ashx?cod_filme=" + cod_filme,
        contentType: 'application/json',
        context: document.body,
        success: function (retorno) {
            alert('Sua recomendação foi postada com sucesso!');
        }
    });
}