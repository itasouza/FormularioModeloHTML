$(document).ready(function(){


    $('#nascimento').datetimepicker({
        format:'DD/MM/YYYY'
    });


    //validaçao de formulário
    $('#formulario').validate({
        rules:{
              nome:{ required: true}
        },
        apelido:{required:true}

    });


});

$(document).ready(function() {
 $('[data-toggle="popover"]').popover();
});