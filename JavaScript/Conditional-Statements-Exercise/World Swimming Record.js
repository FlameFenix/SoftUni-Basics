function SwimmingRecord(input) {
    let record = Number(input[0]);
    let distance = Number(input[1]);
    let timePerMeter = Number(input[2]);

    let secondsNeeded = distance * timePerMeter;
    let slow = Math.floor((distance / 15)) * 12.5;

    let finalSum = secondsNeeded + slow;

    if (finalSum < record) {
        console.log(`Yes, he succeeded! The new world record is ${finalSum.toFixed(2)} seconds.`);
    } else {
        console.log(`No, he failed! He was ${Math.abs(finalSum - record).toFixed(2)} seconds slower.`);
    }

}

SwimmingRecord(["55555.67",
    "3017",
    "5.03"]
);