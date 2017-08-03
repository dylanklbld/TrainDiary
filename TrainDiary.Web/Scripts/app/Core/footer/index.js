import React from 'react';
import ReactDOM from 'react-dom';
import styles from './style.css'
import Info from './info.js';

export default class Footer extends React.Component {
  render () {
    return (
        <div className="footer">
            <Info/>
        </div>
    );
  }
}