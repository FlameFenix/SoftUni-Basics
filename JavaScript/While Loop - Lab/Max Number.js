function MaxNumber(input) {

    let index = 0;
    let command = input[index];


    let maxNum = Number.MIN_SAFE_INTEGER;

    while (command !== "Stop") {

        let currentNumber = Number(command);
        index++;
        command = input[index];

        if (currentNumber > maxNum) {
            maxNum = currentNumber;
        }
    }
    console.log(maxNum);
}

MaxNumber((["-1",
"-2",
"Stop"])
);