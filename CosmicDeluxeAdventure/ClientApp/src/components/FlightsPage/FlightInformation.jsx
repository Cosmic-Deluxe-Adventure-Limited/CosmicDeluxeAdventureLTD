import React, { useEffect } from 'react';
import { useState } from 'react';
import ListGroup from 'react-bootstrap/ListGroup';
import ListGroupItem from 'react-bootstrap/ListGroupItem'
import Card from 'react-bootstrap/Card';
import Button from 'react-bootstrap/Button'

const FlightInformation = (props) => {
    console.log('props', props.flight);
    return (
        <Card className="m-3">
                <ListGroup>
                    <ListGroupItem><strong>Arrival: </strong>{props.flight.arrival}</ListGroupItem>
                    <ListGroupItem><strong>Departure: </strong>{props.flight.departure}</ListGroupItem>
                <ListGroupItem style={{ height: '5rem' }}><strong>Traveling To: </strong>{props.flight.location.name}</ListGroupItem>
                    <ListGroupItem><strong>Ship: </strong>{props.flight.ship.name}</ListGroupItem>
                    <ListGroupItem><Button onClick="">Click to Book</Button></ListGroupItem>
                </ListGroup>
            </Card>
        )
    
}

export default FlightInformation