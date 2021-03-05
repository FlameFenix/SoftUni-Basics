function Trip(input) {


    let index = 0;

    while (true) {
        let destination = input[index];
        index++;
        if(destination == "End") {
            break;
        }

        let budget = Number(input[index]);
        let tripSum = 0;

        while (true) {

            index++;
            let currentMoney = Number(input[index]);
            tripSum += currentMoney;

            if(tripSum >= budget) {
                console.log(`Going to ${destination}!`);
                index++
                break;
            }
        }
    }
        
}

Trip((["France",
"2000",
"300",
"300",
"200",
"400",
"190",
"258",
"360",
"Portugal",
"1450",
"400",
"400",
"200",
"300",
"300",
"Egypt",
"1900",
"1000",
"280",
"300",
"500",
"End"])
);