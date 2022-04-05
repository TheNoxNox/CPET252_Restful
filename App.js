import logo from './logo.svg';
import './App.css';
import React from 'react';

function App() {
  
  //const element = <h1>Hello, world</h1>

  return (
    <div className="App">
      <Employees/>
    </div>
  );
}


 class Employees extends React.Component {
  constructor(props) {
      super(props)
      this.state = {
          employees: []
      }
  }

  componentDidMount() {
      let self = this;
      fetch('64.72.1.142/rest/employees', {
          method: 'GET'
      }).then(function(response) {
          if (response.status >= 400) {
              throw new Error("Bad response from server");
          }
          return response.json();
      }).then(function(data) {
          self.setState({employees: data});
      }).catch(err => {
      console.log('caught it!',err);
      })
  }

  render() {
      return (
      <div className="container"> 
          <div className="panel panel-default p50 uth-panel">
              <table className="table table-hover">
                  <thead>
                      <tr>
                          <th>First Name</th>
                          <th>Middle Initial</th>
                          <th>Last Name</th>
                          <th>Job ID</th>
                          <th>Job Level</th>
                          <th>Publisher</th>
                          <th>Hire Date</th>
                      </tr>
                  </thead>
                  <tbody>
                  {this.state.employees.map(employee =>
                      <tr key={employee.emp_id}>
                      <td>{employee.fname} </td>
                      <td>{employee.minit} </td>
                      <td>{employee.lname} </td>
                      <td>{employee.job_id} </td>
                      <td>{employee.job_lvl} </td>
                      <td>{employee.pub_id} </td>
                      <td>{employee.hire_date} </td>
                      <td><a>Edit</a>|<a>Delete</a></td>
                      </tr>
                  )}
                  </tbody>
              </table>
          </div>
      </div>
      );
  }
}


class Clock extends React.Component {

  // 1. ctor called by react 
  constructor(props) {
    super(props); // call base class ctor

    this.state = { datex: new Date(),
      count: props.start,
      start : props.start,
      max: props.max 
    };

    this.j = props.jolly; 
    
  }

  // 3. lifecycle method - called after the component is rendered to the DOM
  componentDidMount() {
    this.timerID = setInterval(
      () => this.tick(), 1000
    );
  }

  // another lifecycle method 
  componentWillUnmount() {
    clearInterval(this.timerID); // kill timer 
  }

  increment()
  {
    if(this.state.count >= this.state.max) return this.state.start; 

    return this.state.count + 1; 
  }

  tick() {

    // this should be the only place you change state, so render is called.  

    this.setState({  // 'schedules' call to render 
      datex: new Date(), // new value for inside of state property
      count: this.increment()
    });
  }

  // 2. called after ctor by React
  render() {
    return (
      <div>
        <h1>Hello {this.j}</h1>
        <h2>It is {this.state.datex.toLocaleTimeString()}.</h2>
        <h2>Count {this.state.count}</h2>
      </div>
    );
  }
}

// has to be after the creation of Clock
// could pass args here or in the call above.
// OR you can just  use <Clock, as you see here.  
// NOTE input for properties.  
const Clocker = <Clock jolly="ken" start={5} max={10}/>; 




export default App;
