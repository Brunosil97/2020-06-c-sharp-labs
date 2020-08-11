import React from 'react';
import GameList from './Components/GameList'
import GameForm from './Containers/GameForm'
import SearchBar from './Components/SearchBar'
import {Container} from 'semantic-ui-react'
import './App.css';

class App extends React.Component {

  constructor() {
    super()
    this.state = {
      gamesArray : [],
      search: ''
    }
  }

  componentDidMount() {
    fetch("https://localhost:44318/api/Games")
    .then(res => res.json())
    .then(gameJson => this.setState({ gamesArray: gameJson}))
    
  }

  addGame = (game) => {
    this.setState({gamesArray: [...this.state.gamesArray], game})
  }

  onChangeSearch = (event) => {
    this.setState({
      search: event.target.value
    })
  }

  filteredGames = () => {
    const filter = this.state.search ? this.state.gamesArray.includes((game) => {
      game.name.includes(this.state.search)
    }) : this.state.gamesArray;

    return filter;
  }

  render() {
    return(
      <Container>
        
        <h1 className="pageTitle">Game Collector</h1>
        <GameForm addGame={this.addGame}/>
        <br/>
        <SearchBar onChangeSearch={this.onChangeSearch}/>
        <br/>
        
        <GameList games={this.filteredGames()}/>
      
      
      </Container>
    )
  }
}

export default App;
