function greening(input) {
    let sum = Number(input[0]) * 7.61;
    let discount = sum * 0.18;
    console.log(`The final price is: ${sum - discount} lv.`);

    console.log(`The discount is: ${discount} lv.`);

}

greening((["150"]));