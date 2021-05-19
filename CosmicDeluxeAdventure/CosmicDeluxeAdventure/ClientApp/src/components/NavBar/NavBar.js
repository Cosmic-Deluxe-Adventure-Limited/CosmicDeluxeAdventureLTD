import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import '../NavBar/NavBar.css';
import NavDropdown from 'react-bootstrap/NavDropdown';

export class NavMenu extends Component {
  static displayName = NavMenu.name;

  constructor (props) {
    super(props);

    this.toggleNavbar = this.toggleNavbar.bind(this);
    this.state = {
      collapsed: true
    };
  }

  toggleNavbar () {
    this.setState({
      collapsed: !this.state.collapsed
    });
  }

  render () {
    return (
      <header>
        <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" light>
          <Container>
            <NavbarBrand tag={Link} to="/">Cosmic Deluxe Adventure Limited</NavbarBrand>
                <NavDropdown title="More travel" id="collasible-nav-dropdown">
                <NavDropdown.Item href="#action/3.1">Stays</NavDropdown.Item>
                <NavDropdown.Item href="#action/3.2">Flights</NavDropdown.Item>
                <NavDropdown.Item href="#action/3.3">Cars</NavDropdown.Item>
                <NavDropdown.Item href="#action/3.2">Packages</NavDropdown.Item>
                <NavDropdown.Item href="#action/3.3">Things to do</NavDropdown.Item>
                <NavDropdown.Divider />
                <NavDropdown.Item href="#action/3.4">Deals</NavDropdown.Item>
              </NavDropdown>
            <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
            <Collapse className="d-sm-inline-flex flex-sm-row-reverse" isOpen={!this.state.collapsed} navbar>
             <ul className="navbar-nav flex-grow">

                <NavItem>
                  <NavLink tag={Link} className="text-dark" to="/">Home</NavLink>
                </NavItem>
                <NavItem>
                  <NavLink tag={Link} className="text-dark" to="/counter">Customer Support</NavLink>
                </NavItem>
                <NavItem>
                  <NavLink tag={Link} className="text-dark" to="/trips">Trips</NavLink>
                </NavItem>
              </ul>
            </Collapse>
          </Container>
        </Navbar>
      </header>
    );
  }
}
