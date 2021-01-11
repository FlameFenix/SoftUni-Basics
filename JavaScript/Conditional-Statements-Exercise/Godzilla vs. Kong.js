function Movie(input) {

    let budget = Number(input[0]);
    let numberOfPeople = Number(input[1]);
    let clothesForPeople = Number(input[2]);

    let decor = budget * 0.10;
    let pricePerClothes = numberOfPeople * clothesForPeople * 1.0;

    if (numberOfPeople > 150) {
        pricePerClothes *= 0.90;
    }

    let sum = decor + pricePerClothes * 1.0;
    if (sum > budget) {
        console.log(`Not enough money!`);
        console.log(`Wingard needs ${(sum - budget).toFixed(2)} leva more.`);
    } else {
        console.log(`Action!`);
        console.log(`Wingard starts filming with ${(budget - sum).toFixed(2)} leva left.`);
    }
}

Movie(["9587.88",
    "222",
    "55.68"]
);