import React from 'react';
import BackCard from '../Components/BackCard';
import FrontCard from '../Components/FrontCard';

class GameCard extends React.Component {
    state = {
        clicked: false
    }

    handleClick = () => {
        this.setState({
            clicked: !this.state.clicked
        })
    }

    render() {
        const { game, UpdateStateToEditGame, deleteGame} = this.props;
        return (
            <div onClick={this.handleClick}>
                {this.state.clicked ? <BackCard game={game} UpdateStateToEditGame={UpdateStateToEditGame} deleteGame={deleteGame}/> 
                : <FrontCard game={this.props.game}/>
            }
            </div>
        )
    }
}

export default GameCard