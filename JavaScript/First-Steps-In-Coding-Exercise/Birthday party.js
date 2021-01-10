function sumOfParty(input) {

    let room = Number(input[0]);
    let cake = room * 0.20;
    let drinks = cake - (cake * 0.45);
    let animator = room / 3.0;

    let totalSum = cake + drinks + animator + room;

    console.log(totalSum);
}

sumOfParty((["2250"]));
