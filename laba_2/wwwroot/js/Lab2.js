const uri = 'api/Actors';
let actors = [];

function getActors() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayActors(data))
        .catch(error => console.error('Unable to get categories.', error));
}

function addActor() {
    const addNameTextbox = document.getElementById('add-name');
    const addInfoTextbox = document.getElementById('add-info');

    const actor = {
        name: addNameTextbox.value.trim(),
        info: addInfoTextbox.value.trim(),
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(actor
        )
    })
        .then(response => response.json())
        .then(() => {
            getActors();
            addNameTextbox.value = '';
            addInfoTextbox.value = '';
        })
        .catch(error => console.error('Unable to add actor.', error));
}

function deleteActor(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getActors())
        .catch(error => console.error('Unable to delete actor.', error));
}

function displayEditForm(id) {
    const actor = actors.find(actor => actor.id === id);

    document.getElementById('edit-id').value = actor.id;
    document.getElementById('edit-name').value = actor.name;
    document.getElementById('edit-info').value = actor.info;
    document.getElementById('editForm').style.display = 'block';
}

function updateActor() {
    const actorId = document.getElementById('edit-id').value;
    const actor = {
        id: parseInt(actorId, 10),
        name: document.getElementById('edit-name').value.trim(),
        info: document.getElementById('edit-info').value.trim()
    };

    fetch(`${uri}/${actorId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(actor)
    })
        .then(() => getActors())
        .catch(error => console.error('Unable to update actor.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}


function _displayActors(data) {
    const tBody = document.getElementById('actors');
    tBody.innerHTML = '';


    const button = document.createElement('button');

    data.forEach(actor => {
        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${actor.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteActor(${actor.id})`);

        let tr = tBody.insertRow();


        let td1 = tr.insertCell(0);
        let textNode = document.createTextNode(actor.name);
        td1.appendChild(textNode);

        let td2 = tr.insertCell(1);
        let textNodeInfo = document.createTextNode(actor.info);
        td2.appendChild(textNodeInfo);

        let td3 = tr.insertCell(2);
        td3.appendChild(editButton);

        let td4 = tr.insertCell(3);
        td4.appendChild(deleteButton);
    });

    actors = data;
}
