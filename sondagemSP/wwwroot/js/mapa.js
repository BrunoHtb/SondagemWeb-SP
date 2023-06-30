
function mostrarPopupClicado(lat, long, nome, estaca) {
    L.marker([lat, long])
        .addTo(map)
        .bindPopup(nome + "<br>" + estaca)
        .openPopup();
}

//Função responsavel para verificar qual linha foi clicado na tabela
var linhasTabela = document.querySelectorAll('.linha-tabela');
linhasTabela.forEach(function (linha) {
    linha.addEventListener('click', function () {
        $('tr').removeClass('table-active');
        $(this).addClass('table-active');

        var lat = document.querySelector('.table-active #latitude-prevista').textContent.replace(",", ".");
        var long = document.querySelector('.table-active #longitude-prevista').textContent.replace(",", ".");
        var nome = document.querySelector('.table-active #nome').textContent;
        var estaca = document.querySelector('.table-active #estaca').textContent;

        mostrarPopupClicado(lat, long, nome, estaca);
        // voa para a posição do marcador e aplica o nível de zoom desejado
        map.flyTo([lat, long], 18);
    });
});

