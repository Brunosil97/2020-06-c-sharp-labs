import React from 'react';
import {Card} from 'semantic-ui-react';


const FrontCard = ({game}) => {

    const buttonRedirect = (name) => {
        switch (name) {
            case 'xbox':
                window.open("https://www.xbox.com/en-GB/", '_blank')
                break;
            case 'playstation':
                window.open("https://www.playstation.com/en-gb/", '_blank')
                break;
                default:
                break
        }
    }

    return (
        <Card className="gameTile">
            <img className="gameImg" src={game.imageUrl} />
            
               {game.console === "Xbox" ? 
            <div className="xboxContainer">
                <i id="xboxLogo" class="xbox icon" onClick={() => buttonRedirect('xbox')}></i>
            </div>
                : 
            <div className="psContainer">
                <i id="psLogo" class="playstation icon" onClick={() => buttonRedirect('playstation')}></i>
            </div>}
            
            
            
        </Card>
    )
}

export default FrontCard;