import React from 'react';
import ReactDOM from 'react-dom';
import Header from './header/index.js';
import Footer from './footer/index.js';
import MainPage from './mainpage/index.js';

export default class App extends React.Component {
    render() {
        return (
           <div>
                <Header />
                <Footer />
           </div>
       )
    }
}