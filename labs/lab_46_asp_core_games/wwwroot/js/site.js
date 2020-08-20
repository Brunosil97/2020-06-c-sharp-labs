// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function getUsers() {
    let users = [];
    var li = document.createElement("LI");

    fetch('https://jsonplaceholder.typicode.com/users')
        .then(response => response.json())
        .then(userArr => {
            const html = userArr.map(user => {
                return li.innerText = user.name
            }).join(" ");
            console.log(html)
            document.getElementById("nameList").appendChild(html);
        })


    //console.log(users);

    //return users;
}

const displayUsers = () => {
        //getUsers();

        //console.log(getUsers());

        var list = document.getElementById("nameList");

        getUsers().forEach(user => {
            list.appendChild(`<li>${user.name}</li>`);
        });

    }

