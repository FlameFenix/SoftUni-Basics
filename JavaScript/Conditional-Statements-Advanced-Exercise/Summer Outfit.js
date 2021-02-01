function SummerOutfit(input) {

    let degrees = Number(input[0]);
    let dayTime = input[1];
    let shirt = "";
    let shoes = "";
    if (degrees >= 10 && degrees <= 18) {
        if (dayTime == "Morning") {
            shirt = "Sweatshirt";
            shoes = "Sneakers";
        } else if (dayTime == "Afternoon" || dayTime == "Evening") {
            shirt = "Shirt";
            shoes = "Moccasins"
        }
    } else if (degrees > 18 && degrees <= 24) {
        if (dayTime == "Morning") {
            shirt = "Shirt";
            shoes = "Moccasins";
        } else if (dayTime == "Afternoon") {
            shirt = "T-Shirt";
            shoes = "Sandals";
        } else if (dayTime == "Evening") {
            shirt = "Swim Suit";
            shoes = "Barefoot";
        }
    } else if (degrees >= 25) {
        if (dayTime == "Morning") {
            shirt = "T-Shirt";
            shoes = "Sandals";
        } else if (dayTime == "Afternoon") {
            shirt = "Swim Suit";
            shoes = "Barefoot";
        } else if (dayTime == "Evening") {
            shirt = "Shirt";
            shoes = "Moccasins";
        }
    }
    console.log(`It's ${degrees} degrees, get your ${shirt} and ${shoes}`);
}

SummerOutfit((["28",
    "Evening"])
);