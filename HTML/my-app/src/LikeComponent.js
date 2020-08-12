import React from 'react';
import PropComponent from './PropComponent'
import ShowComponent from './ShowComponent';

class LikeComponent extends React.Component {

    constructor() {
        super()
        this.state = {
            likes: 0,
            showComponent: false,
            pokemons: []
        }
    }

    componentDidMount() {
        fetch("https://pokeapi.co/api/v2/pokemon?limit=20")
        .then(res => res.json())
        .then(pokemons => this.setState({pokemons}))
    }

    incrementLikeCount = () => {
        this.setState({
            likes: this.state.likes + 1
        })
    }

    handleShowChange = () => {
        this.setState({
            showComponent: !this.state.showComponent
        })
    }

    render() {
        const {likes, showComponent} = this.state;
        return (
            <main>
                <div>
                    <h1>Hello World</h1>
                    <h1>Number of Likes {likes}</h1>
                    <PropComponent incrementLikeCount={this.incrementLikeCount}/>
                    <br/>
                <button onClick={() => this.handleShowChange()}>Click me</button>

                {showComponent 
                ? <ShowComponent /> 
                : <h3>Hidden</h3>
            }
                </div>
            </main>
        )
    }
}

export default LikeComponent