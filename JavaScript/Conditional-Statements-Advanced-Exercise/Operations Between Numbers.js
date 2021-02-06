function Calculations(input) {

    let numberOne = Number(input[0]);
    let numberTwo = Number(input[1]);
    let operation = input[2];

    let result = 0;
    let evenOrOdd = "";

    if (operation == "+") {

        result = numberOne + numberTwo;

    } else if (operation == "-") {
        result = numberOne - numberTwo;
    } else if (operation == "*") {
        result = numberOne * numberTwo;
    } else if (operation == "/" && numberTwo != 0) {
        result = numberOne / numberTwo;
    } else if (operation == "%" && numberTwo != 0) {
        result = numberOne % numberTwo;
    } else {
        console.log(`Cannot divide ${numberOne} by zero`);
    }

    if (result % 2 == 0) {

        evenOrOdd = "even";

    } else {

        evenOrOdd = "odd";

    }

    if (numberTwo != 0 && operation != "%" && operation != "/") {

        console.log(`${numberOne} ${operation} ${numberTwo} = ${result} - ${evenOrOdd}`);

    } else if (numberTwo != 0 && operation == "/") {
        console.log(`${numberOne} ${operation} ${numberTwo} = ${result.toFixed(2)}`);
    } else if (numberTwo != 0 && operation == "%") {
        console.log(`${numberOne} ${operation} ${numberTwo} = ${result}`);
    }

}

Calculations((["10",
    "0",
    "%"])
);