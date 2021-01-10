function Area(input) {
    let typeOfFigure = input[0];
    if (typeOfFigure == "square") {

        let square = Number(input[1]);
        console.log((square * square).toFixed(3));

    } else if (typeOfFigure == "rectangle") {

        let length = Number(input[1]);
        let width = Number(input[2]);
        console.log((length * width).toFixed(3));

    } else if (typeOfFigure == "circle") {

        let radius = Number(input[1]);
        console.log((Math.PI * (radius * radius)).toFixed(3));

    } else if (typeOfFigure == "triangle") {

        let side = Number(input[1]) * Number(input[2]) / 2;
        console.log(side.toFixed(3));

    }
}

Area(["rectangle",
"7","2.5"]
);