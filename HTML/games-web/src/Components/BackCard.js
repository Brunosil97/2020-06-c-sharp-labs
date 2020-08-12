import React from 'react';
import {Card} from 'semantic-ui-react';

const BackCard = ({game, UpdateStateToEditGame}) => {

    return (
        <Card className="gameTile">
            <h3>{game.name}</h3>
            <img className="gameImg" src={game.imageUrl}></img>
            <div className = "backCard">
                <p>Description: {game.description}</p>
                <p>Rating: {game.rating}</p>
            </div>
            <div>
                <button>Delete</button>
                <button onClick={() => UpdateStateToEditGame(game)}>Update</button>
            </div>
        </Card>
    )
}

export default BackCard;