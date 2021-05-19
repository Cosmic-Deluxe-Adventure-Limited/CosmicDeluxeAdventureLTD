import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Trips } from './components/Trips';
import { Counter } from './components/Counter';
import Footer from '../src/components/Footer/Footer';
import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <>
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/trips' component={Trips} />

     <Footer/>        
      </Layout>
 
      </>
    );
  }
}
