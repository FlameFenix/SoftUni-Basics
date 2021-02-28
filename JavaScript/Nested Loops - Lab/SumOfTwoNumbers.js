function SumOfNumbers(input) {

    let startNumber = Number(input[0]);
    let endNumber = Number(input[1]);
    let magicNumber = Number(input[2]);

    let countCombinations = 0;

    let isFound = false;

    for (let x1 = startNumber; x1 <= endNumber; x1++) {
        for (let x2 = startNumber; x2 <= endNumber; x2++) {

            countCombinations++;

            if(x1 + x2 == magicNumber)
            {
                console.log(`Combination N:${countCombinations}`);
                console.log(`${x1} + ${x2} = ${magicNumber}`);
                isFound = true;
                break;
            }
        }
        if(isFound)
        {
            break;
        }
    }

    if(!isFound)
    {
        console.log(`${countCombinations} combinations - neither equals ${magicNumber}`)
    }

}

SumOfNumbers((["88", 
"888", 
"2000"])
);