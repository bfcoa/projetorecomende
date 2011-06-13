function Recomendar(cod_filme) {    
    $.ajax({
        type: 'POST',
        url: "JqueryHandler.ashx?action=Recomendar&cod_filme=" + cod_filme,
        contentType: 'application/json',
        context: document.body,
        success: function (retorno) {
            alert('Sua recomendação foi postada com sucesso!');
        }
    });    
}

function Comentar(cod_filme) {
    $.ajax({
        type: 'POST',
        url: "JqueryHandler.ashx?action=Comentar&cod_filme=" + cod_filme + "&comentario=" + document.getElementById('Comentario' + cod_filme).children[1].value,
        contentType: 'application/json',
        context: document.body,
        success: function (retorno) {
            if (retorno == "1") {
                alert('Seu comentário foi postado com sucesso!');
                OcultarElemento(cod_filme);
            } else {
                alert('Desculpe, mas seu comentário não foi postado!!');
            }
        }
    });
}

function ExibirElemento(IdFIlme) {
    document.getElementById('Comentario'+IdFIlme).hidden = false;
}

function OcultarElemento(IdFIlme) {
    document.getElementById('Comentario' + IdFIlme).hidden = true;
}

function Vazio() {
    return ' ';
}