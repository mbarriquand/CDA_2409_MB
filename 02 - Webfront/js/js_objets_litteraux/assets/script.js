const myEmployee = {
    lastname: "Doe",
    firstname: "John",
    birthday: "1981-11-12",
    salary: 2150
};

function createEmployeeTable(employee) {
    // 1. Create the h1 title
    const title = document.createElement('h1');
    title.textContent = `Profil de ${employee.firstname} ${employee.lastname}`;
    document.body.appendChild(title);

    // 2. Create the table
    const table = document.createElement('table');
    table.style.borderCollapse = 'collapse';

    // 3. Create the table header (<thead>)
    const thead = document.createElement('thead');
    const headerRow = document.createElement('tr');

    let keys = Object.keys(employee);

    // Rename headers here:
    keys = keys.map(key => {
        if (key === "lastname") {
            return "Nom";
        } else if (key === "firstname") {
            return "Prénom";
        } else if (key === "birthday") {
            return "Date de naissance";
        } else if (key === "salary"){
            return "Salaire";
        } else {
            return key; // Keep other headers as they are
        }
    });

    //insert email header.
    keys.splice(keys.indexOf("Annual Salary"),0,"Email");

    keys.forEach(key => {
        const th = document.createElement('th');
        th.textContent = key;
        
        headerRow.appendChild(th);
    });

    thead.appendChild(headerRow);
    table.appendChild(thead);

    // 4. Create the table body (<tbody>)
    const tbody = document.createElement('tbody');
    const dataRow = document.createElement('tr');

    const values = Object.values(employee);
    //insert email value.
    values.splice(values.indexOf(employee.salary),0,`${employee.firstname.toLowerCase()}.${employee.lastname.toLowerCase()}@example.com`);

    values.forEach(value => {
        const td = document.createElement('td');
        // Add dollar sign after salary
        if (typeof value === 'number' && keys[values.indexOf(value)] === "Salaire") {
        td.textContent = '€ ' + value;
        } else {
            td.textContent = value;
        }
        
        dataRow.appendChild(td);
    });

    tbody.appendChild(dataRow);
    table.appendChild(tbody);

    // 5. Append the table to the document body
    document.body.appendChild(table);
}

createEmployeeTable(myEmployee);