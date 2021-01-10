function depositCalculator(input) {

    let sum = Number(input[0]);
    let time = Number(input[1]);
    let percent = Number(input[2]);

    let totalSum = sum + time * ((sum * percent / 100.0) / 12)

    console.log(totalSum.toFixed(2))
}

depositCalculator((["2350", "6", "7"]));