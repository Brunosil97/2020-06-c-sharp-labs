import React from 'react'
import {Button, Header, Modal, Form} from 'semantic-ui-react'
import FrontCard from '../Components/FrontCard';

class UpdateGame extends React.Component {

    state = {
        name: this.props.game.name,
        description: this.props.game.description,
        console: this.props.game.console,
        rating: this.props.game.rating,
        imageUrl: this.props.game.imageUrl,
        errors: []
    }

    UpdatedGameInState = (event) => {
        if(event.target.name == "rating") {
            this.setState({
                rating: parseInt(event.target.value)
            })
        } else {
            this.setState({
                [event.target.name] : event.target.value
            })
        }
    }

    EditGameSubmit = (event) => {
        const {name, description, console, rating, imageUrl} = this.state;
        const baseUrl = "https://localhost:44318/api/Games"
        
        let selectedGame = {
            gameId: parseInt(this.props.game.gameId),
            name: name,
            description: description,
            console: console,
            rating: rating,
            imageUrl: imageUrl
        }
        fetch(`${baseUrl}/${this.props.game.gameId}`, {
            method: 'PUT',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(selectedGame)
        })
        this.props.editGame();
        this.props.getAllGames();
    }

    render() {
        const {name, description, console, rating, imageUrl, errors} = this.state;
        return (
            <Modal as={Form} open={true} onSubmit={this.EditGameSubmit} onClose={() => this.props.editGame()} closeIcon>
                <Header icon='archive' content="Update Game" size="tiny"/>
                <Modal.Content>
                <div className="Errors">
                    {errors.length > 0
                    ? errors.map((error, index) => {
                      return  <h1 key={index}>{error}</h1>
                    }) : null}
                </div>
                    <Form.Input label="Name:" type="text" name="name" value={name} onChange={this.UpdatedGameInState}/>
                    <Form.Input label="Description:" type="text" name="description" value={description} onChange={this.UpdatedGameInState}/>
                    <Form.Input label="Console:" type="text" name="console" value={console} onChange={this.UpdatedGameInState}/>
                    <Form.Input label="Rating:" type="number" step="1" name="rating" value={rating} onChange={this.UpdatedGameInState}/>
                    <Form.Input label="ImageUrl:" type="text" name="imageUrl" value={imageUrl} onChange={this.UpdatedGameInState}/>
                </Modal.Content>

                <Modal.Actions>
                    <Button type="submit" color="green" icon="save" content="Save"/>
                </Modal.Actions>
        

            </Modal>
        )
    }
}

export default UpdateGame