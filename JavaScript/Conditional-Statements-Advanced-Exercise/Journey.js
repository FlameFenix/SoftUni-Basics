function Journey(input) {

    let budget = Number(input[0]);
    let season = input[1];
    let destination = "";
    let typeOfVacation = "";

    if (budget > 0 && budget <= 100) {

        if (season == "summer") {
            budget *= 0.30;
            typeOfVacation = "Camp"
        } else if (season == "winter") {
            budget *= 0.70;
            typeOfVacation = "Hotel";
        }

        destination = "Bulgaria";

    } else if (budget > 100 && budget <= 1000) {

        if (season == "summer") {

            budget *= 0.40;
            typeOfVacation = "Camp"

        } else if (season == "winter") {

            budget *= 0.80;
            typeOfVacation = "Hotel";
        }

        destination = "Balkans";

    } else if (budget > 1000) {

        budget *= 0.90;

        destination = "Europe";

        typeOfVacation = "Hotel";
    }

    console.log(`Somewhere in ${destination}`);
    console.log(`${typeOfVacation} - ${budget.toFixed(2)}`);
}

Journey((["1500", "summer"]));