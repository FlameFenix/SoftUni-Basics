function MetricConverter(input) {
    let number = Number(input[0]);

    let from = input[1];
    let to = input[2];

    if (from == 'm' && to == 'mm') {
        number *= 1000;
    } else if (from == 'mm' && to == 'm') {
        number /= 1000;
    } else if (from == 'm' && to == 'cm') {
        number *= 100;
    } else if (from == 'cm' && to == 'm') {
        number /= 100;
    } else if (from == 'cm' && to == 'mm') {
        number *= 10;
    } else if (from == 'mm' && to == 'cm') {
        number /= 10;
    }

    console.log(number.toFixed(3));
}

MetricConverter(["45", "cm", "mm"]);