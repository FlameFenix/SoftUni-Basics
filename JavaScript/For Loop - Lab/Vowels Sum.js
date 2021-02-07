function VolewsSum(input) {

    let currentWord = input[0];
    let result = 0;

    for (let index = 0; index < currentWord.length; index++) {

        let currentChar = currentWord[index];
        
        if (currentChar == 'a') {

            result += 1;

        } else if (currentChar == 'e') {

            result += 2;

        } else if (currentChar == 'i') {

            result += 3;

        } else if (currentChar == 'o') {

            result += 4;

        } else if (currentChar == 'u') {

            result += 5;

        }
    }
    console.log(result);
}

VolewsSum(["bamboo"]);