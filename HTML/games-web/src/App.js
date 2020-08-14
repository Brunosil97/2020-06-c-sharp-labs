import React from 'react';
import GameList from './Components/GameList'
import GameForm from './Containers/GameForm'
import SearchAndFilter from './Components/SearchAndFilter'
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
      search: '',
      filter: "None"
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
    ? this.consoleFilter().filter((game) => game.name.includes(this.state.search)) 
    : this.consoleFilter();

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

  DeleteGame = (gameId) => {
    const baseUrl = "https://localhost:44318/api/Games"
    fetch(`${baseUrl}/${gameId}`, {
      method: 'DELETE',
      headers: {
        Accept: 'application/json',
        'Content-Type' : 'application/json'
      }
    })
    .then(res => res.json())
  }

  setFilterType = (type) => {
    this.setState({
      filter: type
    })
  }

  consoleFilter = () => {
    if(this.state.filter === "None") {
      return this.state.gamesArray
    } else {
      return this.state.gamesArray.filter(g => g.console === this.state.filter)
    }
  }

  render() {
    return(
      <Container>
        <h1 className="pageTitle">Game Collector</h1>
        <GameForm addGame={this.addGame}/>
        <br/>
        <SearchAndFilter onChangeSearch={this.onChangeSearch} filter={this.state.filter} setFilterType={this.setFilterType}/>
        <br/>
        
        {this.state.editGame ? <UpdateGame game={this.state.selectedGame} getAllGames={this.GetAllGames} editGame ={this.handleEditChange}/>
        : null}

        
        <GameList games={this.filteredGames()} UpdateStateToEditGame={this.UpdateStateToEditGame} deleteGame={this.DeleteGame}/>
        
      </Container>
    )
  }
}

export default App;
