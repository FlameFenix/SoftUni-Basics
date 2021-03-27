function Histogram(input) {
    let index = 1;
    let n = Number(input[0]);
    let p1 = 0;
    let p2 = 0;
    let p3 = 0;
    let p4 = 0;
    let p5 = 0;
    let countP1 = 0;
    let countP2 = 0;
    let countP3 = 0;
    let countP4 = 0;
    let countP5 = 0;

    for (let index = 1; index <= n; index++) {

        let number = Number(input[index]);
        if(number < 200){
            p1 += number;
            countP1++;
        } else if(number >= 200 && number <= 399) {
            p2 += number;
            countP2++;
        } else if(number > 399 && number <= 599) {
            p3 += number;
            countP3++;
        } else if(number > 599 && number <= 799) {
            p4 += number;
            countP4++;
        } else if(number > 799) {
            p5 += number;
            countP5++;
        }
    }

    let sumP1 = countP1 / n * 100;
    let sumP2 = countP2 / n * 100;
    let sumP3 = countP3 / n * 100;
    let sumP4 = countP4 / n * 100;
    let sumP5 = countP5 / n * 100;

    console.log(`${sumP1.toFixed(2)}%`);
    console.log(`${sumP2.toFixed(2)}%`);
    console.log(`${sumP3.toFixed(2)}%`);
    console.log(`${sumP4.toFixed(2)}%`);
    console.log(`${sumP5.toFixed(2)}%`);
}

Histogram((["14",
"53",
"7",
"56",
"180",
"450",
"920",
"12",
"7",
"150",
"250",
"680",
"2",
"600",
"200"])
);