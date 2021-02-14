function MinNumber(input) {

    let index = 0;
    let command = input[index];


    let maxNum = Number.MAX_SAFE_INTEGER;

    while (command !== "Stop") {

        let currentNumber = Number(command);
        index++;
        command = input[index];

        if (currentNumber < maxNum) {
            maxNum = currentNumber;
        }
    }
    console.log(maxNum);
}

MinNumber((["45",
"-20",
"7",
"99",
"Stop"])
);