function Factoriel(input) {

    let range = Number(input[0]);

    let result = 1;

    for (let index = 0; index <= range; index++) {

        if (index != 0) {
            result *= index;
        }

    }

    console.log(result);
}

Factoriel(["5"]);