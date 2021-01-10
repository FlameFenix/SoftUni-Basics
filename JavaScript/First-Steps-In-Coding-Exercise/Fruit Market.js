function fruitMarket(input) {

    let strawberriesPrice = Number(input[0]);
    let raspberriesPrice = strawberriesPrice / 2.0;
    let orangePrice = raspberriesPrice - (raspberriesPrice * 0.40);
    let bananasPrice = raspberriesPrice - (raspberriesPrice * 0.80);

    let bananasQuantity = Number(input[1]) * bananasPrice;
    let orangeQuantity = Number(input[2]) * orangePrice;
    let raspberriesQuantity = Number(input[3]) * raspberriesPrice;
    let strawberriesQuantity = Number(input[4]) * strawberriesPrice;

    let totalSum = bananasQuantity + orangeQuantity + raspberriesQuantity + strawberriesQuantity;

    console.log(totalSum);

}

fruitMarket((["63.5",
"3.57",
"6.35",
"8.15",
"2.5"])

);