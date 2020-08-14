import React from 'react';

const SearchAndFilter = props => {
    return (
        <div>
            <strong>Filter: </strong>
            <div>
                <select onChange={(e) => props.setFilterType(e.target.value)} value={props.filter}> 
                    <option value="None"> - None - </option>
                    <option value="Xbox"> Xbox </option>
                    <option value="Playstation"> Playstation </option>
                </select>
            </div>

            <div className="search">
                <div className="ui icon input">
                    <input placeholder="Search" className="prompt" onChange={props.onChangeSearch}/>
                    <i className="search icon"/>
                </div>
            </div>
        </div>
    )
}

export default SearchAndFilter