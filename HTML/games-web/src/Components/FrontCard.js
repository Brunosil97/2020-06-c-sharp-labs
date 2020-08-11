import React from 'react';
import {Card } from 'semantic-ui-react';

const FrontCard = ({game}) => {

    return (
        // <div className="ui card eight wide coloumn gameTile">
        <Card className="gameTile">
            <img className="gameImg" src={game.imageUrl} />
            <div className="content">
               <h3>{game.name}</h3>
            </div>
        </Card>
        //</div>
    )
}

export default FrontCard;