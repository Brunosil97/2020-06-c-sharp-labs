import React from 'react';

const PropComponent = ({incrementLikeCount}) => {

    return (
        <button onClick={() => incrementLikeCount()}>Likes</button>
    )
}

export default PropComponent