import React from 'react';
import { Route, Switch } from 'react-router-dom';
import NavBar from './components/NavBar/NavBar';
import Flights from './components/FlightsPage/Flights';
import Packages from './components/PackagesPage/Packages';
import Activities from './components/ActivitiesPage/Activities';
import Deals from './components/DealsPage/Deals';
import CustomerSupport from './components/CustomerSupportPage/CustomerSupport';
import Trips from './components/TripsPage/TripsPage';
import Home  from './components/HomeLandingPage/HomePage';
import Footer from './components/FooterPage/Footer';
import Signup from './components/Signup/Signup';



function App () {

  return (
          <>
       <NavBar />
       {/* <Home/> */}
       <Switch>
        <Route exact path='/' component={Home} />
        <Route exact path='/Flights' component={Flights} />
        <Route exact path='/Packages' component={Packages} />
        <Route exact path='/Activities' component={Activities} />
        <Route exact path='/Deals' component={Deals} />
        <Route exact path='/CustomerSupport' component={CustomerSupport} />
        <Route exact path='/Trips' component={Trips} />
        <Route exact path='/Signup' component={Signup} />
      </Switch>
     <Footer/>        
      </>

  )

}
export default App;

