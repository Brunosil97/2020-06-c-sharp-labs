import React from 'react';
import {Card} from 'semantic-ui-react';

const BackCard = ({game}) => {

    return (
        <Card classNmae="gameTile">
            <h3>{game.name}</h3>
            <img className="gameImg" src={game.imageUrl}></img>
            <div className = "backCard">
                <p>Description: {game.description}</p>
                <p>Rating: {game.rating}</p>
            </div>

        </Card>
    )
}

export default BackCard;