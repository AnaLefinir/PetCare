$(document).ready(function () {
    var ctx = document.getElementById("myIncomeChart").getContext('2d');
    var myChart = new Chart(ctx, incomeChartData);
});
