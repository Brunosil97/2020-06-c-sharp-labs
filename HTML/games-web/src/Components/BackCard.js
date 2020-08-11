import React from 'react';

const BackCard = ({game}) => {

    return (
        <div className="ui card eight wide coloumn gameTile">
            <h3>{game.name}</h3>
            <img className="gameImg" src={game.imageUrl}></img>
            <div className = "backCard">
                <p>Description: {game.description}</p>
                <p>Rating: {game.rating}</p>
            </div>

        </div>
    )
}

export default BackCard;