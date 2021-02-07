function Numbers(input) {

    let number = Number(input[0]);

    for (let index = 1; index <= number; index += 3) {

        console.log(index);

    }
}

Numbers(["15"]);