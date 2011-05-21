function clickAdm() {
    Ext.onReady(function () {
        var formNoticias = {
            xtype: 'form',
            title: 'Postar Noticias',
            id: 'formNoticia',
            frame: true,
            //autoHeight: true,
            height: 500,
            bodyStyle: 'padding-top:100px',
            labelAlign: 'right',
            labelWidth: 130,
            buttonAlign: 'center',
            defaults: {
                allowBlank: false
            },
            items: [
                    { xtype: 'textfield', name: 'txtTitulo', fieldLabel: 'Título', width: 400 },
                    { xtype: 'htmleditor', name: 'txtCorpo', fieldLabel: 'Noticia', width: 510, height: 200 },
                ],
            buttons: [
        {
            text: 'Postar',
            handler: function () {
                var fmNoticia = Ext.getCmp('formNoticia').getForm();
                if (fmNoticia.isValid())
                    fmNoticia.submit({
                        waitTitle: 'Postar Noticia',
                        waitMsg: 'Postando...',
                        url: 'ExtHandler.ashx',
                        params: {
                            action: 'PostarNoticia'
                        },
                        success: function () {
                            Ext.MessageBox.show({
                                title: 'PostarNoticia',
                                msg: '<b>Noticia Postada com sucesso</b><br/>Tente Novamente!',
                                buttons: Ext.MessageBox.OK,
                                icon: Ext.MessageBox.INFO
                            });
                        },
                        failure: function () {
                            Ext.MessageBox.show({
                                title: 'Postar Noticia',
                                msg: '<b>Não foi possivel postar a noticia!</b><br/>Tente Novamente!',
                                buttons: Ext.MessageBox.OK,
                                icon: Ext.MessageBox.WARNING
                            });
                        }
                    });
            }
        },
        {
            text: 'Cancelar'
        }
    ]
        };

        winAdm = new Ext.Window({
            title: 'Administração',
            closable: true,
            closeAction: 'hide',
            width: 800,
            modal: true,
            height: 550,
            layout: 'form',
            items: [{
                xtype: 'tabpanel',
                activeTab: 0,

                items: [formNoticias]
            }]
        });
        winAdm.show();
    });
};