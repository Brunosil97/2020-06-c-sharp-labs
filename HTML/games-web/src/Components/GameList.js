import React from 'react'
import GameCard from '../Containers/GameCard'
import {Card} from 'semantic-ui-react';

const GameList = ({games, UpdateStateToEditGame, deleteGame}) => {
    return (
        <Card.Group itemsPerRow={3} className="gamesListBox">
            {games.map(game => {
               return <GameCard  game={game} key={game.name} UpdateStateToEditGame={UpdateStateToEditGame} deleteGame={deleteGame}/>
            })}
        </Card.Group>
    )
}

export default GameList