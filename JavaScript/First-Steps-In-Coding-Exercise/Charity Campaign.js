function Campaign(input) {
    let numberOfDays = Number(input[0]);
    let numberOfBakers = Number(input[1]);
    let numberOfCakes = Number(input[2]) * 45;
    let numberOfWaffles = Number(input[3]) * 5.80;
    let numberOfPancakes = Number(input[4]) * 3.20;

    let sumPerDay = numberOfBakers * (numberOfCakes + numberOfPancakes + numberOfWaffles);
    let TotalSum = (sumPerDay * numberOfDays) - ((sumPerDay * numberOfDays) / 8);

    console.log(TotalSum);

}

Campaign((["131",
    "5",
    "9",
    "33",
    "46"])
);