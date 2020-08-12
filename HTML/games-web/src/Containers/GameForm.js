import React from 'react';
import {Form} from 'semantic-ui-react'


class GameForm extends React.Component {

    constructor() {
        super()
        this.state = {
            nameBox: '',
            descriptionBox: '',
            consoleBox: '',
            ratingBox: 0,
            imageUrlBox: ''
        }
    }

    handleChange = (event) => {
        let value = event.target.value;

        switch(event.target.name) {
            case 'name' :
                this.setState({nameBox: value})
                break;
            case 'description':
                this.setState({descriptionBox: value})
                break;
            case 'console':
                this.setState({consoleBox: value})
                break;
            case 'rating':
                this.setState({ratingBox: parseInt(value)})
                break;
            case 'imageUrl':
                this.setState({imageUrlBox: value})
                break;
                default:
        }
    }

    

    handleSubmit = (event) => {
        event.preventDefault();
        const form = document.querySelector("form");

        let {nameBox, descriptionBox, consoleBox, ratingBox, imageUrlBox} = this.state
        fetch("https://localhost:44318/api/Games", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            },
            body: JSON.stringify({
                name: nameBox,
                rating: ratingBox,
                description: descriptionBox,
                console: consoleBox,
                imageUrl: imageUrlBox
            })
        })
        .then(res => res.json())
        .then(game => this.props.addGame(game))
        .then(form.reset());
    }

    render() {
        return (
            <div className="addForm">
                <h3>Add A New Game</h3>
                <Form className="form" onSubmit={this.handleSubmit}>
                    <Form.Group widths="equal">
                        <Form.Input fluid label="Name" placeholder="Name" name="name" onChange={this.handleChange}></Form.Input>
                        <Form.Input fluid label="Description" placeholder="Description" name="description" onChange={this.handleChange}></Form.Input>
                        <Form.Input fluid label="Console" placeholder="Console" name="console" onChange={this.handleChange}></Form.Input>
                        <Form.Input fluid label="Rating" type="number" step="1" placeholder="Rating" name="rating" onChange={this.handleChange}></Form.Input>
                        <Form.Input fluid label="Image Url" placeholder="Image Url" name="imageUrl" onChange={this.handleChange}></Form.Input>
                        <Form.Button>Submit</Form.Button>
                    </Form.Group>
                </Form>
            </div>
        )
    }
}

export default GameForm