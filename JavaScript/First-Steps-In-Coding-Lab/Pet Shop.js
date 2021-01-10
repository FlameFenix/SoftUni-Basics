function PetShop(input) {
    let dogFood = 2.50 * Number(input[0]);
    let restFood = 4.00 * Number(input[1]);

    let total = dogFood + restFood;

    console.log(`${total} lv.`)
}

PetShop((["13", "9"]));