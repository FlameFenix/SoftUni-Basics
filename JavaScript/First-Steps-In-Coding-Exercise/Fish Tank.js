function FishTank(input) {
    let length = Number(input[0]);
    let width = Number(input[1]);
    let height = Number(input[2]);
    let percent = Number(input[3]) * 0.01;

    let aquaVolume = length * width * height;
    let aquaWatterVolume = aquaVolume * 0.001;
    let totalSum = aquaWatterVolume * (1 - percent);

    console.log(totalSum);
}

FishTank((["105",
"77",
"89",
"18.5"])

);