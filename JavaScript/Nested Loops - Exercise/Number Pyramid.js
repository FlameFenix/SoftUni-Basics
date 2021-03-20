function Pyramid(input) {

    let n = Number(input[0]);

    let number = 1;
    let isReached = false;

    for (let rows = 1; rows <= n; rows++) {
        let currentRow = "";
        for (let cols = 1; cols <= rows; cols++) {

            currentRow += `${number} `
            
            if (number == n) {
                isReached = true;
                break;
            }
            number++;
        }

        console.log(currentRow);

        if (isReached) {
            break;
        }

    }
}

Pyramid(["15"]);