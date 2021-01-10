function hoursOfReading(input) {

    let numberOfPages = Number(input[0]);
    let pagesPerHour = Number(input[1]);
    let days = Number(input[2]);

    let timeSum = numberOfPages / pagesPerHour;
    let totalTime = timeSum / days;

    console.log(totalTime);
}

hoursOfReading((["432", "15", "4"]));