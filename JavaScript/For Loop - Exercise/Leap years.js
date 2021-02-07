function LeapYears(input) {

    let startYear = Number(input[0]);
    let endYear = Number(input[1]);

    for (let index = startYear; index <= endYear; index += 4) {
        console.log(index);
    }

}

LeapYears(["2020", "2032"]);