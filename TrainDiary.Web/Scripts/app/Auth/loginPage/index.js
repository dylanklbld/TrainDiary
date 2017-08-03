import React from 'react';
import ReactDOM from 'react-dom';
import Login from '.login.js';

export default class Authentification extends React.Component {
  render () {
    return (
        <div className="auth-form">
           <Login />
        </div>
    );
  }
}