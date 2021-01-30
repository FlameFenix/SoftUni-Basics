function Cinema(input) {

let typeOfTicket = input[0];
let numberOfRows = Number(input[1]);
let numberOfCols = Number(input[2]);

let priceOfTicket = 0.0;

if (typeOfTicket == "Premiere") {
    priceOfTicket = 12.00;
} else if (typeOfTicket == "Normal"){
    priceOfTicket = 7.50;
} else if (typeOfTicket == "Discount") {
    priceOfTicket = 5.00;
}
let finalSum = priceOfTicket * numberOfRows * numberOfCols;
console.log(`${finalSum.toFixed(2)} leva`);
}

Cinema((["Discount",
"12",
"30"])
);