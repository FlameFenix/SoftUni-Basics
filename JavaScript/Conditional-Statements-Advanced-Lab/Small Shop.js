function Shop(input) {

    let product = input[0];
    let town = input[1];
    let productQuantity = Number(input[2]);

    let price = Number(0);

    if (town == "Sofia") {
        if (product == "coffee") {
            price = productQuantity * 0.50;
        } else if (product == "water") {
            price = productQuantity * 0.80;
        } else if (product == "beer") {
            price = productQuantity * 1.20;
        } else if (product == "sweets") {
            price = productQuantity * 1.45;
        } else if (product == "peanuts") {
            price = productQuantity * 1.60;
        }
    } else if (town == "Plovdiv") {
        if (product == "coffee") {
            price = productQuantity * 0.40;
        } else if (product == "water") {
            price = productQuantity * 0.70;
        } else if (product == "beer") {
            price = productQuantity * 1.15;
        } else if (product == "sweets") {
            price = productQuantity * 1.30;
        } else if (product == "peanuts") {
            price = productQuantity * 1.50;
        }
    } else if (town == "Varna") {
        if (product == "coffee") {
            price = productQuantity * 0.45;
        } else if (product == "water") {
            price = productQuantity * 0.70;
        } else if (product == "beer") {
            price = productQuantity * 1.10;
        } else if (product == "sweets") {
            price = productQuantity * 1.35;
        } else if (product == "peanuts") {
            price = productQuantity * 1.55;
        }
    }

    console.log(price);
}

Shop(["beer",
"Sofia",
"6"]);