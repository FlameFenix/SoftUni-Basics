function ReadText(input) {

    let index = 0;

    while (input[index] != "Stop") {

        console.log(input[index]);
        index++;
    }

}

ReadText((["Nakov",
"SoftUni",
"Sofia",
"Bulgaria",
"SomeText",
"Stop",
"AfterStop",
"Europe",
"HelloWorld"])
);