function Password(input) {

    let username = input[0];
    let password = input[1];
    let userInput = input[2];
    let index = 3;

    while (userInput !== password) {

        index++
        userInput = input[index];

    }

    console.log(`Welcome ${username}!`)
}

Password((["Gosho",
"secret",
"secret"])
);