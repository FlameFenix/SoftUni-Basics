function Sequence(input) {

    let number = Number(input[0]);

    let number2k = 0;

    while (number > number2k) {

        let prevNumber = number2k;

        number2k = (prevNumber * 2) + 1;
        if(number2k > number)
        {
            break;
        }
        console.log(number2k);
    }
}

Sequence(["31"]);