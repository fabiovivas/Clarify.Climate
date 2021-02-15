var climate = climate || {}
climate.home = {
    configEvents: () => {
        $("#btnSearch").click(climate.home.loadClimate)
        $("#ddlCidade").change(climate.home.loadClimate)
    },

    loadClimate: () => {
        const data = $("#ddlCidade").val()
        if (data === "") {
            climate.home.showMessage("")
            $("#resultSearch").html("")
        }
        else {
            climate.home.showMessage($("#ddlCidade option:selected").text())
            $.ajax({
                url: '/Home/LoadCityClimate',
                data: { id: data },
                contentType: 'application/json',
                success: (result) => {
                    $("#resultSearch").html("")
                    $("#resultSearch").html(result)
                }
            })
        }
    },

    showMessage: (data) => {
        if (data !== "") {
            $("#message").css('display', '')
            $("#message h4").html("")
            $("#message h4").html(`Clima para os próximos 7 dias para a cidade ${data}`)
            $("#message").show()
        } else {
            $("#message").hide()
        }
    }
}

$(climate.home.configEvents);