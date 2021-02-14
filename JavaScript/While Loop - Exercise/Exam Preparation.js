function ExamPreparation(input) {
    let badGradesLimit = Number(input[0]);

    let index = 1;
    let countOfExercises = 0
    let sumGrade = 0;
    let poorGrades = 0;
    let isFinished = true;

    let lastExercise = "";

    while (true) {
        let nameOfExercise = input[index];

        if (nameOfExercise == "Enough") {
            break;
        }
        let grade = Number(input[index + 1]);

        if (grade <= 4.00) {
            poorGrades++
        }

        if (poorGrades == badGradesLimit) {
            isFinished = false;
            break;
        }

        index += 2;

        sumGrade += grade;
        countOfExercises++;
        lastExercise = nameOfExercise;

    }

    if (isFinished) {

        console.log(`Average score: ${(sumGrade / countOfExercises).toFixed(2)}`);
        console.log(`Number of problems: ${countOfExercises}`);
        console.log(`Last problem: ${lastExercise}`);

    } else {
        console.log(`You need a break, ${poorGrades} poor grades.`);
    }
}

ExamPreparation((["2",
"Income",
"3",
"Game Info",
"6",
"Best Player",
"4"])
);