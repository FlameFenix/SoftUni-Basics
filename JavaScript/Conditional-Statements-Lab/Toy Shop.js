function ToyShop(input) {

    let holidaysPrice = Number(input[0]);
    let numberOfPuzzles = Number(input[1]);
    let numberOfDolls = Number(input[2]);
    let numberOfBears = Number(input[3]);
    let numberOfMinions = Number(input[4]);
    let numberOfTrucks = Number(input[5]);

    let countOfToys = numberOfPuzzles + numberOfDolls + numberOfBears + numberOfMinions + numberOfTrucks;

    let pricePuzzles = numberOfPuzzles * 2.60;
    let priceDolls = numberOfDolls * 3.00;
    let priceBears = numberOfBears * 4.10;
    let priceMinions = numberOfMinions * 8.20;
    let priceTrucks = numberOfTrucks * 2.00;

    let totalSum = pricePuzzles + priceDolls + priceBears + priceMinions + priceTrucks;

    if (countOfToys >= 50) {

        totalSum *= 0.75;

    }

    totalSum *= 0.90;

    if (totalSum >= holidaysPrice) {
        console.log(`Yes! ${(totalSum - holidaysPrice).toFixed(2)} lv left.`);
    } else {
        console.log(`Not enough money! ${Math.abs(totalSum - holidaysPrice).toFixed(2)} lv needed.`);
    }

}

ToyShop(["40.8", "20", "25", "30", "50", "10"]);