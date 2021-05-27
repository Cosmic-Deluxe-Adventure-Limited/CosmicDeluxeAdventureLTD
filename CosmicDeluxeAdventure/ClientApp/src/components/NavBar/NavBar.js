import React from 'react';
import { Navbar, Nav, NavDropdown } from 'react-bootstrap';



const NavBar = () => {

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
              <Nav.Link href="#something">Something</Nav.Link>
            </Nav>
          </Navbar.Collapse>
        </Navbar>
    );
  }

export default NavBar;
