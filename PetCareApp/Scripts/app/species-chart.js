$(document).ready(function () {
    var ctx = document.getElementById("mySpeciesChart").getContext('2d');
    var myChart = new Chart(ctx, speciesChartData);
});