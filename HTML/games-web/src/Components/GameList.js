import React from 'react'
import GameCard from '../Containers/GameCard'
import {Card} from 'semantic-ui-react';

const GameList = ({games}) => {
    return (
        <Card.Group>
            {games.map(game => (
                <GameCard game={game} key={game.name}/>
            ))}
        </Card.Group>
    )
}

export default GameList