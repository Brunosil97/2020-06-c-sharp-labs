import React from 'react';
import {Card} from 'semantic-ui-react';


const FrontCard = ({game}) => {

    return (
        <Card className="gameTile">
            <img className="gameImg" src={game.imageUrl} />
            
               {game.console === "Xbox" ? 
            <div className="xboxContainer">
                <i id="xboxLogo" class="xbox icon"></i>
            </div>
                : 
            <div className="psContainer">
                <i id="psLogo" class="playstation icon"></i>
            </div>}
            
            
            
        </Card>
    )
}

export default FrontCard;