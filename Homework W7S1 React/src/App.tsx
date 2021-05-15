import React from 'react';
import './App.css';
import Nav from './components/Nav/Nav';//import Nav from './components/Nav';?? 
import Main from './components/Main/Main';//import Main from './components/Main';??
import { BrowserRouter } from 'react-router-dom';
import 'semantic-ui-css/semantic.min.css';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Nav/>
        <Main/>
      </BrowserRouter>
    </div>
  );
}

export default App;
