let birthdays = []; // Creates an empty array
let tableCreated = false;

// Fetches and add initial birthdays from a JSON file
function fetchData() {
    fetch('./assets/data.json')
        .then(response => {
            if (!response.ok) {
                throw new Error('Could not fetch data.');
            }
            return response.json();
        })
        .then(data => {
            birthdays = birthdays.concat(data);
            updateTable();
        })
        .catch(error => {
            console.error('Error fetching json:', error);
            document.getElementById("error-message").textContent = "Error loading data.";
        });
}

// Calls fetchData on page load
fetchData();

// Calculates age from user input of dob
function calculateAge(dob) {
    const today = new Date();
    const birthDate = new Date(dob);
    let age = today.getFullYear() - birthDate.getFullYear();
    const month = today.getMonth() - birthDate.getMonth();
    if (month < 0 || (month === 0 && today.getDate() < birthDate.getDate())) {
        age--;
    }
    return age;
}

// Gets user star sign from dob
function getStarSign(dob) {
    const birthDate = new Date(dob);
    const month = birthDate.getMonth() + 1;
    const day = birthDate.getDate();

    if ((month === 3 && day >= 21) || (month === 4 && day <= 19)) return "Aries ♈";
    if ((month === 4 && day >= 20) || (month === 5 && day <= 20)) return "Taurus ♉";
    if ((month === 5 && day >= 21) || (month === 6 && day <= 20)) return "Gemini ♊";
    if ((month === 6 && day >= 21) || (month === 7 && day <= 22)) return "Cancer ♋";
    if ((month === 7 && day >= 23) || (month === 8 && day <= 22)) return "Leo ♌";
    if ((month === 8 && day >= 23) || (month === 9 && day <= 22)) return "Virgo ♍";
    if ((month === 9 && day >= 23) || (month === 10 && day <= 22)) return "Libra ♎";
    if ((month === 10 && day >= 23) || (month === 11 && day <= 21)) return "Scorpio ♏";
    if ((month === 11 && day >= 22) || (month === 12 && day <= 21)) return "Sagittarius ♐";
    if ((month === 12 && day >= 22) || (month === 1 && day <= 19)) return "Capricorn ♑";
    if ((month === 1 && day >= 20) || (month === 2 && day <= 18)) return "Aquarius ♒";
    if ((month === 2 && day >= 19) || (month === 3 && day <= 20)) return "Pisces ♓";
    return "Unknown";
}

// Adds user input to the table
function addBirthday() {
    const nameInput = document.getElementById("name");
    const dobInput = document.getElementById("dob");
    const errorParagraph = document.getElementById("error-message");

    const name = nameInput.value.trim();
    const dob = dobInput.value;

    // throws 'error' if fields are empty
    if (!name) {
        errorParagraph.textContent = "Please enter a name.";
        return;
    }
    if (!dob) {
        errorParagraph.textContent = "Please select a date of birth.";
        return;
    }

    errorParagraph.textContent = "";

    const birthday = {
        name: name,
        dob: dob,
    };

    birthdays.push(birthday);
    updateTable();
    document.getElementById("birthdayForm").reset();
    showUpdateMessage(name);
}

// Displays update message on addition
function showUpdateMessage(name) {
    const updateMessage = document.getElementById("update-message");
    updateMessage.textContent = `${name} has been added! 🎉`;
    setTimeout(() => {
        updateMessage.textContent = "";
    }, 5000); // Clear message after 5 seconds
}

// Capitalizes the first later of the user name
function capitalizeFirstLetter(string) {
    return string.charAt(0).toUpperCase() + string.slice(1);
}

// Updates / Creates table
function updateTable() {
    const tableContainer = document.getElementById("tableContainer");

    if (!tableCreated) {
        const table = document.createElement("table");
        table.id = "birthdayTable";
        const thead = document.createElement("thead");
        const headerRow = document.createElement("tr");
        const headers = ["Name", "Date of Birth (dd/mm/yyy)", "Age", "Star Sign", "Actions"];

        headers.forEach((headerText) => {
            const th = document.createElement("th");
            th.textContent = headerText;
            headerRow.appendChild(th);
        });

        // Creates the table (only if it didn't exist before)
        thead.appendChild(headerRow);
        table.appendChild(thead);

        const tbody = document.createElement("tbody");
        table.appendChild(tbody);
        tableContainer.appendChild(table);
        tableCreated = true;
    }

    const tableBody = document.querySelector("#birthdayTable tbody");
    tableBody.innerHTML = "";

    // Fills table with user input + calculated information
    birthdays.forEach((birthday, index) => {
        const row = tableBody.insertRow();
        const nameCell = row.insertCell(0);
        const dobCell = row.insertCell(1);
        const ageCell = row.insertCell(2);
        const starSignCell = row.insertCell(3);
        const actionsCell = row.insertCell(4);

        // Capitalizes the first letter of the name
        nameCell.textContent = capitalizeFirstLetter(birthday.name);

        // Formats the date of birth
        const dobDate = new Date(birthday.dob);
        const day = String(dobDate.getDate()).padStart(2, '0');
        const month = String(dobDate.getMonth() + 1).padStart(2, '0'); // Months are 0-indexed
        const year = dobDate.getFullYear();
        dobCell.textContent = `${day}/${month}/${year}`;

        // Uses functions to calculate age and star sign
        ageCell.textContent = calculateAge(birthday.dob);
        starSignCell.textContent = getStarSign(birthday.dob);

        // Uses the deleteRow function on click
        const deleteButton = document.createElement("button");
        deleteButton.textContent = "Delete";
        deleteButton.addEventListener("click", () => deleteRow(index));
        actionsCell.appendChild(deleteButton);

        // Adds classes to dynamic element to access them in CSS
        deleteButton.classList.add("deleteButton");
        actionsCell.classList.add("deleteColumn");
    });
}

// Deletes an entire row
function deleteRow(index) {
    const deletedName = birthdays[index].name;
    birthdays.splice(index, 1);
    updateTable();
    showDeleteMessage(deletedName);
}

// Displays update message on deletion
function showDeleteMessage(name) {
    const updateMessage = document.getElementById("update-message");
    updateMessage.textContent = `${name} has been deleted! 🗑️`;
    setTimeout(() => {
        updateMessage.textContent = "";
    }, 5000);
}

// Deletes the entire table
function resetAll() {
    const errorMessage = document.getElementById("error-message");

    // Displays update message if the table is empty
    if (birthdays.length === 0) {
        errorMessage.textContent = "The birthday registry is already empty! 🤨";
        return;
    }

    // Displays confirmation pop-up before deletion of the entire table
    if (window.confirm("😧 Are you sure you want to delete all birthdays?")) {
        birthdays = [];
        tableCreated = false;
        document.getElementById("tableContainer").innerHTML = "";
        errorMessage.textContent = "";
    }
}