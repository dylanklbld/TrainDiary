import React from 'react';
import ReactDOM from 'react-dom';

export default class Login extends React.Component {
     constructor(props){
        super(props);
        
        this.state = {
            username:'',
            password:''
        };
    }

    handleClick(event){
        event.preventDefault();
        var el = event.target;
        console.log(el);
        
        var data = new FormData();
        data.append('name', this.state.username);
        data.append('password', this.state.password);

        var xhr = new XMLHttpRequest();
        xhr.open('post', '/Home/Test', true);
        xhr.send(data);
    };

    render () {
        return (
            <div className="login-form">
                <input type="text" value={this.state.username} id="username" />  
                <input type="password" value={this.state.password} id="password" />  
                <input type="submit" value='Sign In' onClick={this.handleClick.bind(this)} />
            </div>
        );
    };
}