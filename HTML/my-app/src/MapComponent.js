import React from 'react'
import UserComponent from './UserComponent'

const MapComponent = (props) => {

    const user = props.allUsers.map((user, idx) => {
        return <UserComponent key={idx} user={user}/>
    })
    return (
        <div>
            {user}
        </div>
    )
}

export default MapComponent