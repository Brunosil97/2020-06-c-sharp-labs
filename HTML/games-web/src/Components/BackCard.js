import React from 'react';
import {Card} from 'semantic-ui-react';
import {Delete, Icon} from '@material-ui/core/Icon';
import DeleteIcon from '@material-ui/icons/Delete';
import CloudUploadIcon from '@material-ui/icons/CloudUpload';
import Button from '@material-ui/core/Button';

const BackCard = ({game, UpdateStateToEditGame, deleteGame}) => {

    return (
        <Card className="gameTileBack" >
            
            {/* <img className="gameImg" src={game.imageUrl}></img> */}
            <div className = "backCard">
                <h3>{game.name}</h3>
                <p>Description:<br/> {game.description}</p>
                <p>Rating:  {game.rating}</p>
            </div>
            <div className="cardButtons">
                <Button color="secondary" variant="contained" startIcon={<DeleteIcon/>} onClick={() => deleteGame(game.gameId)}>Delete</Button>
                <Button color="default"  variant="contained" startIcon={<CloudUploadIcon/>} onClick={() => UpdateStateToEditGame(game)}>Update</Button>
            </div>
        </Card>
    )
}

export default BackCard;