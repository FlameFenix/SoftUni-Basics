function Numbers(input) {

    let number = Number(input[0]);

    for (let index = 0; index <= number; index++) {

        if(index % 2 == 0)
        {
            console.log(Math.pow(2, index));
        }

    }

}

Numbers("7");