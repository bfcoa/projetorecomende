function Recomendar(cod_filme, id_usuario) {
    $.ajax({
        type: 'POST',
        url: "JqueryHandler.ashx?action=Recomendar&cod_filme=" + cod_filme+"&id_usuario="+id_usuario,
        contentType: 'application/json',
        context: document.body,
        success: function (retorno) {
            if (retorno == "1") {
                alert('Sua recomendação foi postada com sucesso!');
            } else {
                alert(retorno);
            }
        }
    });    
}

function Comentar(cod_filme, id_usuario) {
    $.ajax({
        type: 'POST',
        url: "JqueryHandler.ashx?action=Comentar&cod_filme=" + cod_filme + "&id_usuario="+id_usuario+"&comentario=" + document.getElementById('Comentario' + cod_filme).children[1].value,
        contentType: 'application/json',
        context: document.body,
        success: function (retorno) {
            if (retorno == "1") {
                alert('Seu comentário foi postado com sucesso!');
                OcultarElemento(cod_filme);
            } else {
                alert(retorno);
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