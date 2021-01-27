function WorkingHours(input) {
    let hours = Number(input[0]);
    let dayOfWeek = input[1];

    if (dayOfWeek == "Monday"
        || dayOfWeek == "Tuesday"
        || dayOfWeek == "Wednesday"
        || dayOfWeek == "Thursday"
        || dayOfWeek == "Friday"
        || dayOfWeek == "Saturday") {
        if (hours >= 10 && hours <= 18) {
            console.log("open");
        }
        else {
            console.log("closed");
        }
    } else {
        console.log("closed");
    }
}

WorkingHours();