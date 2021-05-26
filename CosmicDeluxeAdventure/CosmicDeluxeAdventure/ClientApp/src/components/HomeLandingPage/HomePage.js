 import React from 'react';
import { Jumbotron, Container, Alert, Form, Col, Card, Button } from 'react-bootstrap';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faExclamationTriangle } from '@fortawesome/free-solid-svg-icons'


const HomePage = () => {

    return (
      <div>
        <Jumbotron fluid>
          <Container>
          <Alert variant='dark'>
        
            <h2>
             <FontAwesomeIcon icon={faExclamationTriangle}/>   
              Travel Advisory</h2>
            <p>
            We are experiencing high call volumes resulting in this new travel opportunity. Space travelers who are in-trip or have immediate departure dates will be prioritized. If you would like to speak to a Virtual Space Agent please click on the "Help" link below. We apologize for the inconvenience.</p>
          </Alert>
          </Container>
        </Jumbotron>
        <Card>
        <h1>Welcome Space Travelers!</h1>
        <br/>
        <Form>
      <Form.Row>
        <Col xs={2}>
          <Form.Control placeholder="Leaving from..." />
           </Col> 
            <Col><Form.Control placeholder="Going to..." />
        </Col>
        <Col xs={3}>
          <Form.Control placeholder="Departing" />
        </Col>
        <Col xs={3}>
          <Form.Control placeholder="Returning" />
        </Col>
      </Form.Row>
      <br/>
      <Button variant="primary">Search</Button>
</Form>

</Card>

      </div>
    );
  }


export default HomePage;

