import React from 'react';
import ChildComponent from './ChildComponent'
import ShowComponent from './ShowComponent'
import MapComponent from './MapComponent'

class LikeComponent extends React.Component {

    constructor() {
        super()
        this.state = {
            likes: 0,
            isShown: false,
            users: []
        }
    }

    //1. fetch from api of your choosing and store into state
    //2. Render a function component that MAPS through all the passed down array of objects
    //3. For each mapped item in the array, render a component and pass down that item
    //3. In component for specific item, display its content

    // 1 component to handle the array and map
    // For each mapped item in array, render a component file

    componentDidMount() {
        fetch("https://jsonplaceholder.typicode.com/users")
            .then(response => response.json())
            .then(usersJson => this.setState({users: usersJson}))
    }

    incrementLikeCount = () => {
        this.setState({
            likes: this.state.likes + 1
        })
    }

    handleShowChange = () => {
        this.setState({
            isShown: !this.state.isShown
        })
    }

    render() {
        return (
            <main>
                <div>
                    <h1>This is the amount of likes: {this.state.likes}</h1>
                    <ChildComponent incrementLikeCount={this.incrementLikeCount} />

                    <button onClick={() => this.handleShowChange()}>Show Me!</button>

                    { this.state.isShown ? <ShowComponent /> : null }
                </div>

                <div>
                    <h1>All Users:</h1>
                    <MapComponent allUsers={this.state.users}/>
                </div>
            </main>
        )
    }
}

export default LikeComponent