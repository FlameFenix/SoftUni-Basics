function projectsCreation(input) {

    let numberOfProjects = Number(input[1]);
    let hoursNeeded = Number(numberOfProjects * 3);
    let name = input[0];

    console.log(`The architect ${name} will need ${hoursNeeded} hours to complete ${numberOfProjects} project/s.`);

}

projectsCreation((["Sanya",
    "9"])


);