$(function () {

    var slider = {

        moveImage: function () {

            var slider = $('#slider');

            $("#slider img:first-child").clone().appendTo(slider);

            slider.animate({
                left: "-=" + 1140
            }, 1000, function () {
                $("#slider img:first-child").remove();
                slider.css('left', '0');
            });
        },

        init: function () {
            setInterval(this.moveImage, 5000);

        }
    }

    slider.init();

    $('#btnBuscar').on('click', function () {

        var marca = $("#selectMarca").val();
        var modelo = $("#selectModelo").val();
        var anno = $("#selectAnnos").val();
        var cilindrada = $("#selectCilindrada").val();
        var inyeccion = $("input[name=gasType]:checked").val();

        $.ajax({
            type: "GET",
            url: "http://localhost:50149/api/bateria/obtenerbateria",
            data: { ID_Marca: marca, ID_Modelo: modelo, ID_Anno: anno, ID_Inyeccion: inyeccion, ID_Cilindrada: cilindrada },
            dataType: "json",
            success: function (data) {
                if (data != null) {
                    $("#detallesBateria").show();

                    $("html, body").animate({ scrollTop: $('#detallesBateria').offset().top }, 1000);

                    $("#nombreBateria").text(data.Detalles_Bateria);
                    $("#largoBateria").text(data.Largo_Bateria);
                    $("#anchoBateria").text(data.Ancho_Bateria);
                    $("#altoBateria").text(data.Alto_Bateria);
                    $("#pesoBateria").text(data.Peso_Bateria);
                } else {
                    $("#noResult").modal('show');
                }
            }
        });
    });

    var app = {

        cargarMarcas: function () {
            $.ajax({
                type: "GET",
                url: "http://localhost:50149/api/bateria/obtenerMarcas",
                dataType: "json",
                success: function (data) {
                    var trows = "";
                    var firstOption = $("#selectMarca").first().html();
                    trows += firstOption;
                    data.forEach(function (element) {
                        trows += "<option value='" + element.ID_Marca + "'>" + element.Nombre_Marca + "</option>"
                    });
                    $("#selectMarca option").remove();
                    $("#selectMarca").append(trows);
                }
            });
        },
        cargarModelos: function () {

            var idMarca = $("#selectMarca option:selected").val();

            $.ajax({
                type: "GET",
                url: "http://localhost:50149/api/bateria/obtenerModelo",
                dataType: "json",
                data: { idMarca: idMarca },
                success: function (data) {
                    var trows = "";
                    var firstOption = "<option value='' selected disabled hidden>Modelo</option>";
                    trows += firstOption;
                    data.forEach(function (element) {
                        trows += "<option value='" + element.ID_Modelo + "'>" + element.Nombre_Modelo + "</option>"
                    });
                    $("#selectModelo option").remove();
                    $("#selectModelo").append(trows);
                }
            });
        },
        cargarCilindradas: function () {
            $.ajax({
                type: "GET",
                url: "http://localhost:50149/api/bateria/obtenerCilindrada",
                dataType: "json",
                success: function (data) {
                    var trows = "";
                    var firstOption = $("#selectCilindrada").first().html();
                    trows += firstOption;
                    data.forEach(function (element) {
                        trows += "<option value='" + element.ID_Cilindrada + "'>" + element.Nombre_Cilindrada + "</option>"
                    });
                    $("#selectCilindrada option").remove();
                    $("#selectCilindrada").append(trows);
                }
            });
        },
        cargarAnnos: function () {
            $.ajax({
                type: "GET",
                url: "http://localhost:50149/api/bateria/obtenerAnnos",
                dataType: "json",
                success: function (data) {
                    var trows = "";
                    var firstOption = $("#selectAnnos").first().html();
                    trows += firstOption;
                    data.forEach(function (element) {
                        trows += "<option value='" + element.ID_Anno + "'>" + element.Nombre_Anno + "</option>"
                    });
                    $("#selectAnnos option").remove();
                    $("#selectAnnos").append(trows);
                }
            });
        },
        init: function () {
            this.cargarMarcas();
            $("#selectMarca").change(this.cargarModelos);
            this.cargarCilindradas();
            this.cargarAnnos();
        }
    }
    app.init();

});