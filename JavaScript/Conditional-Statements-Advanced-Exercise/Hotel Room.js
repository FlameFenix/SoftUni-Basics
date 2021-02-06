function HotelRoom(input) {

    let month = input[0];
    let days = Number(input[1]);

    let studioPrice = 0;
    let apartmentPrice = 0;

    if (month == "May" || month == "October") {

        studioPrice = days * 50;
        apartmentPrice = days * 65;

        if(days > 7 && days <= 14) {
            studioPrice *= 0.95;
        } else if(days > 14) {
            studioPrice *= 0.70;
        }

    } else if (month == "June" || month == "September") {

        studioPrice = days * 75.20;
        apartmentPrice = days * 68.70;

        if(days > 14) {

            studioPrice *= 0.80;

        }

    } else if (month == "July" || month == "August") {

        studioPrice = days * 76;
        apartmentPrice = days * 77;
    }

    if(days > 14) {
        apartmentPrice *= 0.90;
    }

    console.log(`Apartment: ${apartmentPrice.toFixed(2)} lv.`);
    console.log(`Studio: ${studioPrice.toFixed(2)} lv.`);
}

HotelRoom((["August",
"20"])
);