function Walking(input) {
    let index = 0;
    let stepsSum = 0;
    let target = 10000;
    let isTargetSuccessful = false;

    while (input[index] != "Going home") {

        let steps = Number(input[index]);
        index++;
        stepsSum += Number(steps);

        if (stepsSum >= target) {
            isTargetSuccessful = true;
            break;
        }

    }

    if(input[index] == "Going home") {
        index++;
        stepsSum += Number(input[index]);
    }
    if(stepsSum >= target || isTargetSuccessful) {
        console.log("Goal reached! Good job!");
        console.log(`${stepsSum - target} steps over the goal!`);
    } else {
        console.log(`${target - stepsSum} more steps to reach goal.`);
    }

}

Walking((["125",
"250",
"4000",
"30",
"2678",
"4682"])
);