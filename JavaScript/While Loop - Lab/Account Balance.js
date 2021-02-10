function Balance(input) {

    let index = 0;
    let command = input[index];
    let sum = 0;

    while (command != "NoMoreMoney") {

        
        index++;

        if(Number(command) >= 0)
        {
            sum += Number(command);
        } else {
            console.log("Invalid operation!");
            break;
        }
        console.log(`Increase: ${Number(command)}`);

        command = input[index];
    }

    console.log(`Total: ${sum.toFixed(2)}`);

}

Balance((["120",
"45.55",
"-150"])
);