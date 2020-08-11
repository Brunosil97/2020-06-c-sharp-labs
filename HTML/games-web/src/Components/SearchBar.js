import React from 'react';

const SearchBar = props => {
    return (
        <div className="search">
            <div className="ui icon input">
                <input placeholder="Search" className="prompt" onChange={props.onChangeSearch}/>
                <i className="search icon"/>
            </div>
        </div>
    )
}

export default SearchBar