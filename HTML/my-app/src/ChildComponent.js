import React from 'react';

const ChildComponent = (props) => {

    return (
        <div>
            <button onClick={() => props.incrementLikeCount()}>Click Me</button>
        </div>
    )
}

export default ChildComponent