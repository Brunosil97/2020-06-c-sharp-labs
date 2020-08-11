import React from 'react'
import GameCard from '../Containers/GameCard'
import {Card} from 'semantic-ui-react';

const GameList = ({games}) => {
    return (
        <Card.Group itemsPerRow={3}>
            {games.map(game => {
               return <GameCard game={game} key={game.name}/>
            })}
        </Card.Group>
    )
}

export default GameList