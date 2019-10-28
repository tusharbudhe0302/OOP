// const name = '';
// const age = 0;
// const values = [];
// const properties = {};
// const answer = name || age || values || properties;
// console.log(answer);
// const check = answer == [];
// console.log(check);


// fetch / writeFile are stubbed
// See the format of users/pets that are returned by the stubbed APIs
const fs = require('fs');

function fetch(url) {
    switch (url) {
        case 'https://mob-api.com/users':
            return Promise.resolve([
                { name: "Andrew", id: "1" },
                { name: "Sergio", id: "2" },
                { name: "Richard", id: "3" },
            ]);
        case 'https://mob-api.com/pets':
            return Promise.resolve([
                { name: "Layla", userId: "1" },
                { name: "Poopers", userId: "1" },
                { name: "Athena", userId: "2" },
                { name: "Fluffy", userId: "2" },
                { name: "Noelle", userId: "1" },
                { name: "Anubis", userId: "2" },
                { name: "Huckleberry", userId: "1" },
            ]);
    }
}

const outputFile = fs.createWriteStream(`sampleOp.json`, 'utf-8');

function writeFile(filename, content) {
    outputFile.write(`${filename}: ${content}\n`);

    return Promise.resolve();
}

function workWithData() {
    const users = fetch('https://mob-api.com/users').then(users => {
        return users;
    });

    const pets = fetch('https://mob-api.com/pets').then(pets => {
        return pets.sort();
    });

    return writeFile('sorted-pets.json', JSON.stringify(pets)).then((newPets) => {
        /* need help here */

        newPets.map((checkPetsObject) => {
            console.log(`Pets for  User : ${JSON.stringify(checkPetsObject)}`);
            return new Promise((resolve) => {
                const usersWithPets = users.then(newusers => {
                    newusers.map((currentUser) => {
                        console.log(`Current User : ${JSON.stringify(currentUser)}`);
                        var newUser = new Object(Object.prototype);
                        newUser = currentUser;
                        var filterPets = newPets.filter(function (pet) {
                            return pet.userId == currentUser.id;
                        })
                        newUser.pets = [];
                        resolve(newUser);
                    })
                })
            })

        })
        writeFile('users-with-pets.json', usersWithPets);
    });
}

workWithData().then(() => outputFile.end());