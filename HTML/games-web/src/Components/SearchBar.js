import React from 'react';

const SearchBar = props => {
    return (
        <div className="ui search">
            <div className="ui icon input">
                <input className="prompt" onChange={props.onChangeSearch}/>
                <i className="search icon"/>
            </div>
        </div>
    )
}

export default SearchBar