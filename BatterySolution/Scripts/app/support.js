$(function () {



    var support = {
        cargarMarcas: function () {
            $.ajax({
                type: "GET",
                url: "http://localhost:50149/api/bateria/obtenerMarcas",
                dataType: "json",
                success: function (data) {
                    var trows = "";
                    trows += "<tbody>";
                    data.forEach(function (element) {
                        trows += "<tr>";
                        trows += "<td>" + element.ID_Marca + "</td>"
                        trows += "<td>" + element.Nombre_Marca + "</td>"
                        trows += "<td><a href=''>Editar</a>|<a href=''>Eliminar</a></td>"
                        trows += "</tr>";
                    });
                    trows += "</tbody>";
                    $("#tableMarcas tbody").remove();
                    $("#tableMarcas").append(trows);
                }
            });
        },
        cargarAnno: function () {
            $.ajax({
                type: "GET",
                url: "http://localhost:50149/api/bateria/ObtenerModelos",
                dataType: "json",
                success: function (data) {
                    var trows = "";
                    trows += "<tbody>";
                    data.forEach(function (element) {
                        trows += "<tr>";
                        trows += "<td>" + element.ID_Modelo + "</td>"
                        trows += "<td>" + element.Nombre_Modelo + "</td>"
                        trows += "<td><a href=''>Editar</a>|<a href=''>Eliminar</a></td>"
                        trows += "</tr>";
                    });
                    trows += "</tbody>";
                    $("#tableModelo tbody").remove();
                    $("#tableModelo").append(trows);
                }
            });
        },
        cargarModelos: function () {
            $.ajax({
                type: "GET",
                url: "http://localhost:50149/api/bateria/ObtenerAnnos",
                dataType: "json",
                success: function (data) {
                    var trows = "";
                    trows += "<tbody>";
                    data.forEach(function (element) {
                        trows += "<tr>";
                        trows += "<td>" + element.ID_Anno + "</td>"
                        trows += "<td>" + element.Nombre_Anno + "</td>"
                        trows += "<td><a href=''>Editar</a>|<a href=''>Eliminar</a></td>"
                        trows += "</tr>";
                    });
                    trows += "</tbody>";
                    $("#tableAnno tbody").remove();
                    $("#tableAnno").append(trows);
                }
            });
        },
        cargarCilindrada: function () {
            $.ajax({
                type: "GET",
                url: "http://localhost:50149/api/bateria/ObtenerCilindrada",
                dataType: "json",
                success: function (data) {
                    var trows = "";
                    trows += "<tbody>";
                    data.forEach(function (element) {
                        trows += "<tr>";
                        trows += "<td>" + element.ID_Cilindrada + "</td>"
                        trows += "<td>" + element.Nombre_Cilindrada + "</td>"
                        trows += "<td><a href=''>Editar</a>|<a href=''>Eliminar</a></td>"
                        trows += "</tr>";
                    });
                    trows += "</tbody>";
                    $("#tableCilindrada tbody").remove();
                    $("#tableCilindrada").append(trows);
                }
            });
        },
        cargarBaterias: function () {
            $.ajax({
                type: "GET",
                url: "http://localhost:50149/api/bateria/ObtenerBaterias",
                dataType: "json",
                success: function (data) {
                    var trows = "";
                    trows += "<tbody>";
                    data.forEach(function (element) {
                        trows += "<tr>";
                        trows += "<td>" + element.ID_Bateria + "</td>";
                        trows += "<td>" + element.Detalles_Bateria + "</td>";
                        trows += "<td>" + element.Largo_Bateria + "</td>";
                        trows += "<td>" + element.Ancho_Bateria + "</td>";
                        trows += "<td>" + element.Alto_Bateria + "</td>";
                        trows += "<td>" + element.Peso_Bateria + "</td>";
                        trows += "<td>" + element.CCA_Bateria + "</td>";
                        trows += "<td><a href=''>Editar</a>|<a href=''>Eliminar</a></td>"
                        trows += "</tr>";
                    });
                    trows += "</tbody>";
                    $("#tableBaterias tbody").remove();
                    $("#tableBaterias").append(trows);
                }
            });
        },
        cargarMaster: function () {
            $.ajax({
                type: "GET",
                url: "http://localhost:50149/api/bateria/ObtenerMaster",
                dataType: "json",
                success: function (data) {
                    var trows = "";
                    trows += "<tbody>";
                    data.forEach(function (element) {
                        trows += "<tr>";
                        trows += "<td>" + element.Master_IDMarca + "</td>";
                        trows += "<td>" + element.Master_IDModelo + "</td>";
                        trows += "<td>" + element.Master_IDAnno + "</td>";
                        trows += "<td>" + element.Master_IDCilindrada + "</td>";
                        trows += "<td>" + element.Master_IDInyeccion + "</td>";
                        trows += "<td>" + element.Master_IDBateria + "</td>";
                        trows += "<td><a href='' id='masterBtnEditarRow'>Editar</a>|<a href=''>Eliminar</a></td>"
                        trows += "</tr>";
                    });
                    trows += "</tbody>";
                    $("#tableMaster tbody").remove();
                    $("#tableMaster").append(trows);
                }
            });
        },
        AgregarMaster: function () {

            var MasterDE = {
                Master_IDBateria: $("#Master_IDBateria").val(),
                Master_IDMarca: $("#Master_IDMarca").val(),
                Master_IDModelo: $("#Master_IDModelo").val(),
                Master_IDAnno: $("#Master_IDAnno").val(),
                Master_IDCilindrada: $("#Master_IDCilindrada").val(),
                Master_IDInyeccion: $("#Master_IDInyeccion").val()
            }

            $.ajax({
                type: "POST",
                url: "http://localhost:50149/api/Master/IngresarBateriaVehiculo",
                data: JSON.stringify(MasterDE),
                contentType: "application/json",
                success: function (data) {
                    alert(data);
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert(errorThrown);
                }
            });
        },
        EditarMaster: function () {

            var oldIds = "";

            var MasterUpdateDE = {
                Master_IDBateria: $("#Master_IDBateria").val(),
                Master_IDMarca: $("#Master_IDMarca").val(),
                Master_IDModelo: $("#Master_IDModelo").val(),
                Master_IDAnno: $("#Master_IDAnno").val(),
                Master_IDCilindrada: $("#Master_IDCilindrada").val(),
                Master_IDInyeccion: $("#Master_IDInyeccion").val(),
                Master_OldIDs: oldIds
            }

            $.ajax({
                type: "PUT",
                url: "http://localhost:50149/api/Master/ActualizarBateriaVehiculo",
                data: JSON.stringify(MasterDE),
                contentType: "application/json",
                success: function (data) {
                    alert(data);
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert(errorThrown);
                }
            });
        },
        EditarMasterRowClick: function (e) {
            e.preventDefault();
            var rowChilds = $(this).parent().parent().children();
            var stringList = [];
            rowChilds.each(function () {
                stringList.push($(this).text());
            })
            stringList.pop();


        },
        init: function () {
            this.cargarMarcas();
            this.cargarAnno();
            this.cargarModelos();
            this.cargarCilindrada();
            this.cargarBaterias();
            this.cargarMaster();
            $("#masterBtnAgregar").on("click", this.AgregarMaster)
            $("#masterBtnEditar").on("click", this.EditarMaster)
            $("body").on("click", "#masterBtnEditarRow", this.EditarMasterRowClick)
        }
    }

    support.init();
})