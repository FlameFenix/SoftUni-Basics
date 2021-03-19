function Building(input) {

    let numberOne = Number(input[0]);
    let numberTwo = Number(input[1]);

    for (let floors = numberOne; floors > 0; floors--) {
        let floorAsString = "";
        for (let offices = 0; offices < numberTwo; offices++) {
            if(floors == numberOne)
            {
                floorAsString += `L${floors}${offices} `;
                continue;
            }

            if(floors % 2 == 0)
            {
                floorAsString += `O${floors}${offices} `;
            }
            else
            {
                floorAsString += `A${floors}${offices} `;
            }
        }
        console.log(floorAsString);
    }
}

Building(["6", "4"]);
