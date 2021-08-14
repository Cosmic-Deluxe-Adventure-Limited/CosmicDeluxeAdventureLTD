import React, { useEffect } from 'react';
import { useState } from 'react';
import { Card, ListGroup, ListGroupItem } from 'react-bootstrap';

const FlightInformation = (props) => {
    console.log('props', props.flight);
        return (
            <Card>
                <ListGroup>
                    <ListGroupItem><strong>Arrival: </strong>{props.flight.arrival}</ListGroupItem>
                    <ListGroupItem><strong>Departure: </strong>{props.flight.departure}</ListGroupItem>

                </ListGroup>
            </Card>
        )
    
}

export default FlightInformation