function SumOfNumbers(input) {

    let number = input[0];
    let sum = 0;

    for (let index = 0; index < number.length; index++) {
        let currentNumber = number[index];

        sum += Number(currentNumber);
    }

    console.log(`The sum of the digits is:${sum}`);
}

SumOfNumbers(["564891"]);