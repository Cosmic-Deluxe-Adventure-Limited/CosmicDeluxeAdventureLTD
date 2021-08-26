import React,  {useEffect } from 'react';
import { useState } from 'react';

import CardGroup from 'react-bootstrap/CardGroup';
import Jumbotron from 'react-bootstrap/Jumbotron'
//import { Card } from 'react-bootstrap';
import FlightInformation from '../FlightsPage/FlightInformation'
import FlighSampleArrayJSON from '../../developmentAssets/flightsSeedData.json';

const Flights = (props) => {

    const [flightData, setFlightData] = useState({});
    const [allFlights, setallFlights] = useState([]);

    //Use this to turn on and off the fetch/sample JSON data.
    const [apiCall, setApiCall] = useState(false);
    useEffect(() => {
        fetchData();
    }, []);    
    const fetchData = () => {
        if (!apiCall) {
            console.log('true to form');
            console.log("flightSampleJSON", FlighSampleArrayJSON);
            setallFlights(FlighSampleArrayJSON);
        }
        if (apiCall) {
            fetch('api/Flight/getFlight/1')
                .then(data => data.json())
                .then(data => setFlightData(data))
                .catch(err => console.log(err));
            fetch('api/Flight/getAllFlights')
                .then(data => data.json())
                .then(data => setallFlights(data))
        }
    }
    console.log('allFlights', allFlights);
   
    return (
        <>
            <Jumbotron>
            <h1>We offer the adventure of a lifetime!</h1>            
            </Jumbotron>
            <CardGroup>
            {(allFlights.length > 0) ? allFlights.map(fl => <FlightInformation key={fl.id} flight={fl} />) :
            <h1>No Flight Information</h1>}
            </CardGroup>
        </>
    );
    
}


export default Flights;