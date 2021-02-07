function CountWords(input) {

    let sentence = input[0];

    let count = 1;

    for (let index = 0; index < sentence.length; index++) {

        if (sentence[index] == " ") {
            count++;
    }
}

if (count <= 10) {
    console.log(`The message was send successfully!`);
} else {
    console.log(`The message is too long to be send! Has ${count} words.`)
}

}

CountWords(["This message has exactly eleven words. One more as it's allowed!"]);
