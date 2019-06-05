var myDataTable;

$(document).ready(function(){
        AplicarDataTableEstatico();

        $('#tableEstatico tbody td span').live('click', function () {
                var nTr = $(this).parents('tr')[0];
                if ( myDataTable.fnIsOpen(nTr) )
                {
                    myDataTable.fnClose( nTr );
                }
                else
                {
                    myDataTable.fnOpen( nTr, FormatarDetalhes(nTr), 'details' );
                }
            } );
    }
);

function AplicarDataTableEstatico() {
    myDataTable = $("#tableEstatico").dataTable({
            "aLengthMenu": [[10, 20, 50, -1], ["10 Registros", "20 Registros", "50 Registros", "Todos os registros"]],
            "bPaginate": true,
            "sPaginationType": "full_numbers",
            "bLengthChange": true,
            "bFilter": true,
            "bSort": true,
            "bInfo": true,
            "bStateSave": true,
            "oLanguage": 
            {
              "sSearch": "Digite um valor para uma busca global",
              "sFirst": "Primeira Página",
              "sLast": "Última Página",
              "sNext": "Próxima Página",
              "sPrior": "Página Anterior",
              "sInfo": "Exibidos um total de _TOTAL_ registros (_START_ to _END_)",
              "sInfoEmpty": "Nenhum registro para exibir",
              "sInfoFiltered": " - Filtrados de _MAX_ registros",
               "sLengthMenu": "Exibir _MENU_"
            },
            "aoColumnDefs": [
                                { "bSearchable": true, "bVisible": true, "aTargets": [ 2 ],
                                 "mRender": function ( data, type, row ) {
                                    return "<a href=# onclick='alert(\"Você clicou em " + row[0] + "\")'>" + data;
                                    }
                                },
                                { "bSortable": true, "bVisible": true, "aTargets": [ 3 ] },
                                { "bSortable": true, "bVisible": true, "aTargets": [ 4 ],
                                    "fnCreatedCell": function (nTd, sData, oData, iRow, iCol) {
                                        if ( sData < 2500 ) {
                                          $(nTd).css('color', 'red')
                                        }
                                        else
                                        if ( sData < 5000 ) {
                                          $(nTd).css('color', 'green')
                                        }
                                        else{
                                          $(nTd).css('color', 'blue')
                                        }
                                      }
                                },
                                { "bSortable": false, "bSearchable": false, "aTargets": [ 5 ] }
                            ],
            "fnFooterCallback": function ( nRow, aaData, iStart, iEnd, aiDisplay ) {
                var totalSalarios = 0;
                for ( var i=0 ; i<aaData.length ; i++ )
                {
                    totalSalarios += aaData[i][4]*1;
                }
                
                var totalSalariosPagina = 0;
                for ( var i=iStart ; i<iEnd ; i++ )
                {
                    totalSalariosPagina += aaData[ aiDisplay[i] ][4]*1;
                }

                var totalPorEstado = [];
                for ( var i=0 ; i<aaData.length ; i++ )
                {
                    if(totalPorEstado[aaData[i][2]] == undefined)
                        totalPorEstado[aaData[i][2]] = 0;

                    totalPorEstado[aaData[i][2]] += aaData[i][4]*1;
                }

                var resultadoHtml = "Total da Página: " + totalSalariosPagina; 

                for(var key in totalPorEstado)
                {
                    resultadoHtml += "<br>Total de " + key + ": " + totalPorEstado[key];
                }

                resultadoHtml += "<br>Total Geral: " + totalSalarios;

                $("#lblTotal").html(resultadoHtml).css("font-size","12px").css("color","blue");
            }
        });

    $("#tableEstatico tfoot input").keyup( function () {
        myDataTable.fnFilter( this.value, $("tfoot input").index(this) );
    });
}

function AdicionarRegistro(){
    var novaRow = [];
    novaRow.push($("#textNovoCodigo").val());
    novaRow.push($("#textNovoPais").val());
    novaRow.push($("#textNovoEstado").val());
    novaRow.push($("#textNovoCidade").val());
    novaRow.push($("#textNovoSalario").val());
    novaRow.push("<span>Detalhes</span>");
    
    myDataTable.fnAddData(novaRow);
}

function FormatarDetalhes(nTr )
{
    var aData = myDataTable.fnGetData( nTr );
    var htmlDetalhe = '<table cellpadding="5" cellspacing="0" border="0" style="padding-left:50px;">';
    htmlDetalhe += '<tr><td>Código:</td><td>'+aData[0]+'</td></tr>';
    htmlDetalhe += '<tr><td>País:</td><td>'+aData[1]+'</td></tr>';
    htmlDetalhe += '<tr><td>Estado:</td><td>'+aData[2]+'</td></tr>';
    htmlDetalhe += '<tr><td>Cidade:</td><td>'+aData[3]+'</td></tr>';
    htmlDetalhe += '<tr><td>Salario:</td><td>'+aData[4]+'</td></tr>';
    htmlDetalhe += '</table>';
     
    return htmlDetalhe;
}