import React,  {useEffect } from 'react';
import { useState } from 'react';
import { Card } from 'react-bootstrap';
//import superagent from 'superagent';


 

const Flights = (props) => {

    const [flightData, setFlightData] = useState({});
    const [allUsers, setAllUsers] = useState([]);
    useEffect(() => {
        fetchData();
    }, []);    
const fetchData = () => {        
    const flightResponse = fetch('home/flights/getFlight/1')
        .then(data => data.json())
        .then(data => setFlightData(data))
        .catch(err => console.log(err));   
    return flightResponse;
    }    
    return (        
        <>
            <h1>{flightData.arrival}</h1>
        <Card>
            <Card.Body>Show me the flight options page</Card.Body>

            </Card>
            </>
    );
    
}


export default Flights;