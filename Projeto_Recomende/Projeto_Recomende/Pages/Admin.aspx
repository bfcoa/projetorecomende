<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Projeto_Recomende.Pages.Admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Util/Scrypts/ExtJS/resources/css/ext-all.css" rel="stylesheet" type="text/css" />
    <script src="../Util/Scrypts/ExtJS/adapter/ext/ext-base.js" type="text/javascript"></script>
    <script src="../Util/Scrypts/ExtJS/ext-all.js" type="text/javascript"></script>
    <link href="../Util/Scrypts/ExtJS/resources/css/xtheme-gray.css" rel="stylesheet"
        type="text/css" />
    <script src="../Util/Scrypts/ExtJS/src/locale/ext-lang-pt_BR.js" type="text/javascript"></script>
</head>
<body>
    <script>

       //tabPanel
       var tabPanelCentral = new Ext.TabPanel({
            activeTab: 0,
            defaults: { closable: false },
            items: []
        });


       var formNoticias = new Ext.form.FormPanel({
           title: 'Postar Noticias',
           id: 'formNoticia',
           hidden: true,
           frame: true,           
           height: 500,
           width:500,           
           labelAlign: 'right',
           labelWidth: 300,
           buttonAlign: 'center',
           defaults: {
               allowBlank: false
           },
           items: [
                    { xtype: 'textfield', name: 'txtTitulo', fieldLabel: 'Título', width: 400 },
                    { xtype: 'htmleditor', name: 'txtCorpo', fieldLabel: 'Noticia', width: 400, height: 200 },
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
       });



       var vp = new Ext.Viewport({
           layout: 'border',
           items: [
           {
               id: 'viewCenter',
               frame: true,
               region: 'center',
               margins: '5 5 5 0',
               items:[tabPanelCentral]

           },
           {
               region: 'west',
               collapsible: true,
               title: 'Menu Administração',
               xtype: 'treepanel',
               width: 200,
               autoScroll: true,
               split: true,
               loader: new Ext.tree.TreeLoader(),
               root: new Ext.tree.AsyncTreeNode({
                   expanded: true,
                   children: [
                        {
                            text: 'Noticias ',
                            leaf: true,
                            componente: 'formNoticiaPanel',
                            listeners: {
                                click: {
                                    fn: function (node) {
                                        var titulo = node.text;
                                        var novaAba = tabPanelCentral.items.find(
                                            function (aba) {
                                                return aba.title === titulo;
                                            }
                                        );

                                        if (!novaAba) {
                                            novaAba = tabPanelCentral.add(formNoticias);
                                        }
                                        tabPanelCentral.activate(novaAba);
                                    }
                                }
                            }
                        }
                    ]
               }),
               rootVisible: false,
               listeners: {
                   click: function (n) {
                       
                   }
               }
           }
            ]
       });
   
    </script>
</body>
</html>
