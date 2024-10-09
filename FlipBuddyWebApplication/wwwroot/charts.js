function renderChart() {
    console.log("Render chart function called");

    var options = {
        series: [{
            name: "Sales",
            data: [30, 40, 45, 50, 49, 60, 70, 91, 125]
        }],
        chart: {
            height: 350,
            type: 'line',
            zoom: {
                enabled: false
            }
        },
        dataLabels: {
            enabled: true
        },
        stroke: {
            curve: 'smooth'
        },
        xaxis: {
            categories: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep']
        },
        tooltip: {
            shared: true,
            intersect: false
        }
    };

    var chart = new ApexCharts(document.querySelector("#chart"), options);
    chart.render();
}