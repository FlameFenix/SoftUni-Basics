function NewHouse(input) {

    let type = input[0];
    let count = Number(input[1]);
    let budget = Number(input[2]);

    let price = 0;

    if (type == "Roses") {
        price = count * 5;
        if(count > 80) {
            price *= 0.90;
        }

    } else if (type == "Dahlias") {
        price = count * 3.80;
        if(count > 90) {
            price *= 0.85;
        }
    } else if (type == "Tulips") {
        price = count * 2.80;
        if (count > 80) {
            price *= 0.85;
        }
    } else if (type == "Narcissus") {
        price = count * 3;
        if(count < 120) {
            price *= 1.15;
        }
    } else if (type == "Gladiolus") {
        price = count * 2.50;
        if (count < 80) {
            price *= 1.20;
        }
    }
    if(budget - price >= 0) {
        console.log(`Hey, you have a great garden with ${count} ${type} and ${(budget - price).toFixed(2)} leva left.`);
    } else {
        console.log(`Not enough money, you need ${(price - budget).toFixed(2)} leva more.`);
    }
}

NewHouse((["Narcissus",
"119",
"360"])
);