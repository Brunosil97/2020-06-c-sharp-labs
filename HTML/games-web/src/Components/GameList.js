import React from 'react'
import GameCard from '../Containers/GameCard'

const HogList = ({games}) => {

    
    return (
        <div>
           
            {games.map(game => (
                <GameCard game={game} key={game.name}/>
            ))}
        </div>
    )
}

export default HogList