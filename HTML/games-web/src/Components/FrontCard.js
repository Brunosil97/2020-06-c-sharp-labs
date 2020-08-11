import React from 'react';

const FrontCard = ({game}) => {

    return (
        <div className="ui card eight wide coloumn gameTile">
            <img className="gameImg" src={game.imageUrl} />
            <div className="content">
               <h3>{game.name}</h3>
            </div>
        </div>
    )
}

export default FrontCard;