import React, {useState} from 'react';
import { Navbar, Nav, NavDropdown, Button, Modal, Form } from 'react-bootstrap';



const NavBar = () => {
  const [show, setShow] = useState(false);
  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);

    return (


        <Navbar collapseOnSelect bg="dark" variant="dark" expand="lg">
          <Navbar.Brand href="/">Cosmic Deluxe Adventure Limited</Navbar.Brand>
          <Navbar.Toggle aria-controls='responsive-navbar-nav' />
          <Navbar.Collapse id="responsive-navbar-nav">
            <Nav className="mr-auto">
              <NavDropdown title="More travel" id="collasible-nav-dropdown">
              <NavDropdown.Item href="/Flights">Flights</NavDropdown.Item>
              <NavDropdown.Item href="/Packages">Packages</NavDropdown.Item>
              <NavDropdown.Item href="/Activities">Things to do</NavDropdown.Item>
              <NavDropdown.Divider />
              <NavDropdown.Item href="/Deals">Deals</NavDropdown.Item>
              </NavDropdown>
              <Nav.Link href="/CustomerSupport">Customer Support</Nav.Link>
              <Nav.Link href="/Trips">Trips</Nav.Link>
            </Nav>
            <Nav>
              <Nav.Link href="/">Home</Nav.Link>
              <Nav.Link href="#signup">Sign up</Nav.Link> 
              | <Nav.Link href="#signin" onClick={handleShow}>Sign in ↓ </Nav.Link>
      <Modal
        show={show}
        onHide={handleClose}
        backdrop="static"
        keyboard={false}
      >
        <Modal.Header closeButton>
          <Modal.Title>Sign in</Modal.Title>
        </Modal.Header>
        <Modal.Body>
        <Form>
        <Form.Group controlId="formBasicEmail">
          <Form.Label>Email address</Form.Label>
          <Form.Control type="email" placeholder="Enter email" />
          <Form.Text className="text-muted">
            We'll never share your email with anyone else.
          </Form.Text>
        </Form.Group>

        <Form.Group controlId="formBasicPassword">
          <Form.Label>Password</Form.Label>
          <Form.Control type="password" placeholder="Password" />
        </Form.Group>
        <Form.Label>Take me to</Form.Label>
        <Form.Check type="radio" label="Overview" />
        <Form.Check type="radio" label="My Trips" />
        <Form.Group controlId="formBasicCheckbox">
          <Form.Check type="checkbox" label="Remember Me" />
        </Form.Group>
{/*         
          <Button variant="primary" type="submit">
            Submit
          </Button> */}
</Form>
        </Modal.Body>
        <Modal.Footer>
          <Button variant="secondary" onClick={handleClose}>
            Sign in
          </Button>
          <Button variant="primary">Sign up</Button>
        </Modal.Footer>
      </Modal>
                
 
            </Nav>
          </Navbar.Collapse>
        </Navbar>
    );
  }

export default NavBar;
