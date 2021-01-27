function FruitShop(input) {

    let fruit = input[0];
    let dayOfWeek = input[1];
    let quantity = Number(input[2]);
    let price = Number(0);

    let isFruitExist = true;
    let isDayExist = false;

    if (dayOfWeek == "Monday"
        || dayOfWeek == "Tuesday"
        || dayOfWeek == "Wednesday"
        || dayOfWeek == "Tuesday"
        || dayOfWeek == "Friday") {
        if (fruit == "banana") {
            price = 2.50 * quantity;
        } else if (fruit == "apple") {
            price = 1.20 * quantity;
        } else if (fruit == "orange") {
            price = 0.85 * quantity;
        } else if (fruit == "grapefruit") {
            price = 1.45 * quantity;
        } else if (fruit == "kiwi") {
            price = 2.70 * quantity;
        } else if (fruit == "pineapple") {
            price = 5.50 * quantity;
        } else if (fruit == "grapes") {
            price = 3.85 * quantity;
        } else {
            isFruitExist = false;
        }
        isDayExist = true;
    } else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday") {
        if (fruit == "banana") {
            price = 2.70 * quantity;
        } else if (fruit == "apple") {
            price = 1.25 * quantity;
        } else if (fruit == "orange") {
            price = 0.90 * quantity;
        } else if (fruit == "grapefruit") {
            price = 1.60 * quantity;
        } else if (fruit == "kiwi") {
            price = 3.00 * quantity;
        } else if (fruit == "pineapple") {
            price = 5.60 * quantity;
        } else if (fruit == "grapes") {
            price = 4.20 * quantity;
        } else {
            isFruitExist = false;
        }
        isDayExist = true;
    }
    if (isFruitExist && isDayExist) {
        console.log(`${price.toFixed(2)}`);
    } else {
        console.log("error");
    }

}

FruitShop();