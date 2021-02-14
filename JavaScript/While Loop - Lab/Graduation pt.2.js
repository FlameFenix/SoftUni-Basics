function Graduation(input) {
    let index = 1;
    let grade = input[index] * 1.00;
    let name = input[0];

    let countClass = 1;

    let isExcluded = false;
    let sumGrades = 0;

    while (true) {

        if (grade >= 4.00) {
            sumGrades += Number(grade);    
        } else if (grade < 4.00) {
            isExcluded = true;
            break;
        }
        if (countClass == 12) {
            break;
        }
        countClass++;
        index++;
        grade = input[index];
    }
    if (isExcluded) {
        console.log(`${name} has been excluded at ${countClass} grade`);
    } else {
        console.log(`${name} graduated. Average grade: ${(sumGrades/countClass).toFixed(2)}`);
    }

}

Graduation((["Mimi", 
"5",
"6",
"5",
"6",
"5",
"6",
"6",
"2",
"3"])
);