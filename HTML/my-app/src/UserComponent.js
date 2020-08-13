import React from 'react';

const UserComponent = (props) => {


    return (
        <div>
            <h1>My name is: {props.user.name}</h1>
        </div>
    )
}

export default UserComponent