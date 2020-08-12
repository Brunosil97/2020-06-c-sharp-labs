import React from 'react';
import {Card } from 'semantic-ui-react';

const FrontCard = ({game}) => {

    return (
        <Card className="gameTile">
            <img className="gameImg" src={game.imageUrl} />
            <div className="content">
               <h3>{game.console}</h3>
            </div>
        </Card>
    )
}

export default FrontCard;