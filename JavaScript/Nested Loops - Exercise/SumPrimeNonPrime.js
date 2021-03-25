function SumPrimeNonPrime(input) {

    let index = 0;
    let command = input[index];

    let primeNumbersSum = 0;
    let nonPrimeNumbersSum = 0;
    

    while (command != "stop") {
        let number = Number(command);
        let isPrime = true;
        if (number < 0) {
            console.log(`Number is negative.`);
            index++;
            command = input[index];
            continue;
        }
        else {
            for (let index = 2; index < number; index++) {
                if (number % index == 0) {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime) {
            primeNumbersSum += number;
        }
        else {
            nonPrimeNumbersSum += number;
        }

        index++;
        command = input[index];
    }

    console.log(`Sum of all prime numbers is: ${primeNumbersSum}`);
    console.log(`Sum of all non prime numbers is: ${nonPrimeNumbersSum}`);
}

SumPrimeNonPrime((["3",
"9",
"0",
"7",
"19",
"4",
"stop"])

);