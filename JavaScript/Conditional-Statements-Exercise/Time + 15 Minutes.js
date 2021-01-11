function timeWith15Minutes(input) {

    let hours = Number(input[0]);
    let mintues = Number(input[1]);

    if (mintues + 15 >= 60) {
        hours++;
        mintues += 15;
        mintues -= 60;
    } else {
        mintues += 15;
    }

    if (hours > 23) {
        hours = 0;
    }

    if (mintues < 10) {
        console.log(`${hours}:0${mintues}`);
    } else {
        console.log(`${hours}:${mintues}`);
    }

}

timeWith15Minutes(["12", "49"]);