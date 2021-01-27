function TradeCommisions(input) {
    let town = input[0];
    let sales = Number(input[1]);
    let comission = Number(0);

    let isTownValid = true;
    let isSalesValid = sales >= 0;

    if (sales >= 0 && sales <= 500) {
        if (town == "Sofia") {
            comission = sales * 0.05;
        } else if (town == "Varna") {
            comission = sales * 0.045;
        } else if (town == "Plovdiv") {
            comission = sales * 0.055;
        } else {
            isTownValid = false;
        }
    } else if (sales > 500 && sales <= 1000) {
        if (town == "Sofia") {
            comission = sales * 0.07;
        } else if (town == "Varna") {
            comission = sales * 0.075;
        } else if (town == "Plovdiv") {
            comission = sales * 0.08;
        } else {
            isTownValid = false;
        }
    } else if (sales > 1000 && sales <= 10000) {
        if (town == "Sofia") {
            comission = sales * 0.08;
        } else if (town == "Varna") {
            comission = sales * 0.10;
        } else if (town == "Plovdiv") {
            comission = sales * 0.12;
        } else {
            isTownValid = false;
        }
    } else if (sales > 10000) {
        if (town == "Sofia") {
            comission = sales * 0.12;
        } else if (town == "Varna") {
            comission = sales * 0.13;
        } else if (town == "Plovdiv") {
            comission = sales * 0.145;
        } else {
            isTownValid = false;
        }
    }
    if (isTownValid && isSalesValid) {
        console.log(comission.toFixed(2));
    } else {
        console.log("error")
    }

}

TradeCommisions((["Kaspichan",
"-50"])
);