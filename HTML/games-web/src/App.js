import React from 'react';
import GameList from './Components/GameList'
import GameForm from './Containers/GameForm'
import SearchBar from './Components/SearchBar'
import UpdateGame from './Containers/UpdateGame'
import {Container} from 'semantic-ui-react'
import './App.css';

class App extends React.Component {

  constructor() {
    super()
    this.state = {
      gamesArray : [],
      selectedGame: [],
      editGame: false,
      search: ''
    }
  }

  componentDidMount() {
   this.GetAllGames(); 
  }

  GetAllGames = () => {
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
    const filter = this.state.search 
    ? this.state.gamesArray.filter((game) => game.name.includes(this.state.search)) 
    : this.state.gamesArray;

    return filter;
  }

  handleEditChange = () => {
    this.setState({editGame: !this.state.editGame})
  }

  UpdateStateToEditGame = (game) => {
    this.setState({
      selectedGame: game,
      editGame: !this.state.editGame
    })
  }

  render() {
    return(
      <Container>
        <h1 className="pageTitle">Game Collector</h1>
        <GameForm addGame={this.addGame}/>
        <br/>
        <SearchBar onChangeSearch={this.onChangeSearch}/>
        <br/>
        
        {this.state.editGame ? <UpdateGame game={this.state.selectedGame} getAllGames={this.GetAllGames} editGame ={this.handleEditChange}/>
        : null}

        
        <GameList  games={this.filteredGames()}  UpdateStateToEditGame={this.UpdateStateToEditGame}/>
        
      </Container>
    )
  }
}

export default App;
