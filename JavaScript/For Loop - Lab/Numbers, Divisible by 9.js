function DivisibleNumbers(input) {

    let firstNum = Number(input[0]);
    let secondNum = Number(input[1]);

    let sum = 0;

    for (let index = firstNum; index <= secondNum; index++) {

        if (index % 9 == 0) {
            sum += index;
        }

    }

    console.log(`The sum: ${sum}`);

    for (let index = firstNum; index <= secondNum; index++) {

        if (index % 9 == 0) {
            console.log(index);
        }

    }
}

DivisibleNumbers(["100", "200"]);