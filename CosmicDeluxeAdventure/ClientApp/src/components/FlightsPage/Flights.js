import React,  {useEffect } from 'react';
import { useState } from 'react';
import { Card } from 'react-bootstrap';
import FlightInformation from '../FlightsPage/FlightInformation'

const Flights = (props) => {

    const [flightData, setFlightData] = useState({});
    const [allFlights, setallFlights] = useState([]);
    useEffect(() => {
        fetchData();
    }, []);    
    const fetchData = () => {        
   fetch('api/Flight/getFlight/1')
        .then(data => data.json())
        .then(data => setFlightData(data))
        .catch(err => console.log(err));
    fetch('api/Flight/getAllFlights')
        .then(data => data.json())
        .then(data => setallFlights(data))   
    }    
    console.log('allFlights', allFlights);
   
    return (
        <>
            {(allFlights.length > 0) ? allFlights.forEach(fL => <FlightInformation flights={fL} key={fL.id} />) : <h1></h1>}
        </>
    );
    
}


export default Flights;