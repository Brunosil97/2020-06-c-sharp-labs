import React from 'react';
import GameList from './Components/GameList'
import logo from './logo.svg';
import './App.css';

class App extends React.Component {

  constructor() {
    super()
    this.state = {
      gamesArray : []
    }
  }

  componentDidMount() {
    fetch("https://localhost:44318/api/Games")
    .then(res => res.json())
    .then(gameJson => this.setState({ gamesArray: gameJson}))
    
  }

  render() {
    return(
      <div>
        <h1 className="pageTitle">Game Collector</h1>
        <GameList games={this.state.gamesArray}/>
      </div>
    )
  }
}

export default App;
