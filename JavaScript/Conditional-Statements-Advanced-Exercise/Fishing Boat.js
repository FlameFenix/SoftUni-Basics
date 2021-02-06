function FishingBoat(input) {

    let budget = Number(input[0]);
    let season = input[1];
    let countOfPeople = Number(input[2]);

    let priceOfShip = 0;

    if (season == "Spring") {

        priceOfShip = 3000;

    } else if (season == "Summer" || season == "Autumn") {

        priceOfShip = 4200;

    } else if (season == "Winter") {

        priceOfShip = 2600;

    }

    if (countOfPeople > 0 && countOfPeople <= 6) {

        priceOfShip *= 0.90;

    } else if (countOfPeople > 6 && countOfPeople <= 11) {

        priceOfShip *= 0.85;

    } else if (countOfPeople > 11) {

        priceOfShip *= 0.75;

    }

    if (countOfPeople % 2 == 0 && season != "Autumn") {
        priceOfShip *= 0.95;
    }

    if (budget - priceOfShip >= 0) {
        console.log(`Yes! You have ${(budget - priceOfShip).toFixed(2)} leva left.`);
    } else {
        console.log(`Not enough money! You need ${(priceOfShip - budget).toFixed(2)} leva.`);
    }

}

FishingBoat((["2000",
"Winter",
"13"])
);