import React,  {useEffect } from 'react';
//import { useState } from 'react';
import { Card } from 'react-bootstrap';
//import superagent from 'superagent';


const Flights = () => {
    useEffect(() => {
        fetchData();
    }, []);
    //const [GetUserData, setUserData] = useState([]);
    //let newUserData = superagent.get() 
    
    return (
      <Card>
            <Card.Body>Show me the flight options page</Card.Body>

    </Card>
    );
}

const fetchData = async () => {
   // const response = await fetch('home/GetData');
   // const data = await response.json();
    let jsonSampleData = [{ "id": 1, "firstName": "Fox", "lastName": "McCloud", "address": "1234 Corneria Way", "city": "Imperial Base", "state": "Alpha", "zipCode": 12345, "country": "Corneria", "phoneNumber": 1112223333, "userName": "barrelRoll1" }]
    console.log(jsonSampleData);
    const flightResponse = await fetch('home/flights/getFlight/1');
    const flightRespData = await flightResponse.json();
    console.log(flightResponse);
}


export default Flights;