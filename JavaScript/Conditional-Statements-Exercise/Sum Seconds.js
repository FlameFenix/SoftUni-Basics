function SumSeconds(input) {

    let totalSeconds = 0;
    let totalMinutes = 0;

    for (let index = 0; index < 3; index++) {

        if (totalSeconds + Number(input[index]) < 60) {

            totalSeconds += Number(input[index]);

        } else {
            totalSeconds += Number(input[index]) - 60;
            totalMinutes++;
        }

    }
    if (totalSeconds > 9) {
        console.log(`${totalMinutes}:${totalSeconds}`);
    } else {
        console.log(`${totalMinutes}:0${totalSeconds}`);
    }

}

SumSeconds(["50", "50", "49"]);