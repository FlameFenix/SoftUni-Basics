function OldBooks(input) {

    let lookingForBook = input[0];
    let index = 1;
    let currentBook = input[index];
    let countBooks = 0;
    let isBookFound = false;

    while (currentBook !== "No More Books") {

        currentBook = input[index];
        index++;
        if (currentBook == lookingForBook) {
            isBookFound = true;
            break;
        }


        if (currentBook == "No More Books") {
            break;
        }
        countBooks++;
    }

    if (!isBookFound) {
        console.log("The book you search is not here!");
        console.log(`You checked ${countBooks} books.`);
    } else {
        console.log(`You checked ${countBooks} books and found it.`);
    }
}

OldBooks((["Bourne",
"True Story",
"Forever",
"More Space",
"The Girl",
"Spaceship",
"Strongest",
"Profit",
"Tripple",
"Stella",
"The Matrix",
"Bourne"])
);