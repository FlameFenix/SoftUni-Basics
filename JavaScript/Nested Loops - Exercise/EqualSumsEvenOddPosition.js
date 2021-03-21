function Sum(input) {
    let numberOne = Number(input[0]);
    let numberTwo = Number(input[1]);
    let result = "";
    for (let rows = numberOne; rows <= numberTwo; rows++) {

        let oddSum = 0;
        let evenSum = 0;
        let numberAsString = `${rows}`;

        for (let num = 0; num < numberAsString.length; num++) {
            if (num % 2 == 0) {
                evenSum += Number(numberAsString[num]);
            }
            else if (num % 2 != 0) {
                oddSum += Number(numberAsString[num]);
            }

        }
        if(evenSum == oddSum)
        {
            result += `${rows} `;
        }
    }

    console.log(result);
}
Sum(["100115", "100120"]);