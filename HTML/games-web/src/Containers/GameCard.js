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
        return (
            <div onClick={this.handleClick}>
                {this.state.clicked ? <BackCard game={this.props.game}/> 
                : <FrontCard game={this.props.game}/>
            }
            </div>
        )
    }
}

export default GameCard