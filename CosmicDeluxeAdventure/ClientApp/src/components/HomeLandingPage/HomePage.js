 import React from 'react';
import { Jumbotron, Container, Alert, Form, Col, Card, Button, Row, Image, Nav } from 'react-bootstrap';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faExclamationTriangle } from '@fortawesome/free-solid-svg-icons'
import Image1 from '../../assets/Images/image1.jpeg';
import Image2 from '../../assets/Images/image2.jpeg';
import Image3 from '../../assets/Images/image3.jpeg';
import Image4 from '../../assets/Images/image4.jpeg';
import '../HomeLandingPage/HomePage.scss';
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
        <Card className="search-container">
        <h1>Welcome Space Travelers!</h1>
        <br/>
        <Form className="search-form">
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
      <div className="d-flex justify-content-center">
  <Button className="btn btn-default" variant="success"><Nav>Search</Nav></Button>
</div>

</Form>

</Card>
<Container>
  <h2>Ideas for future travels</h2>
  <Row>
    <Col xs={4} md={3}>
      <Image src={Image1} rounded />
    </Col>
    <Col xs={4} md={3}>
      <Image src={Image2} rounded />
    </Col>
    <Col xs={4} md={3}>
      <Image src={Image3} rounded />
    </Col>
    <Col xs={4} md={3}>
      <Image src={Image4} rounded />
    </Col>
  </Row>
</Container>
      </div>
    );
  }


export default HomePage;

