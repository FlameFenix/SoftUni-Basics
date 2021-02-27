function Combinations(input) {

    let count = 0;
    for (let x1 = 0; x1 < 255; x1++) {
        for (let x2 = 0; x2 < 255; x2++) {
            for (let x3 = 0; x3 < 255; x3++) {
                if (x1 + x2 + x3 == Number(input[0])) {
                    count++;
                }
            }
        }
    }
    console.log(count);
}

Combinations((["5"]));