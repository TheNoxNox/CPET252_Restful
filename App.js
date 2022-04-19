
import { Routes, Route, Link } from "react-router-dom";
import "./App.css";
import logo from './logo.svg';
import { useParams} from 'react-router-dom';
import React from 'react';



function App() {
  
  //const element = <h1>Hello, world</h1>
  const { p } = useParams();
  
  return (
    <div className="App">
      <h1>Employees</h1>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="other" element={<Other />} />
        <Route path="/edit/:p" element={<Edit />}  />
        
        <Route path="Add" element={<Add />} />

      </Routes>
    </div>
  );
}

function Home()
{
  return (
    <>
    <nav>
    <Link to="/other"> Clock </Link> <Link to="/Add"> Add Employee </Link>
  </nav>
    <div className="Home">
      <Employees/>
    </div>
    </>
  );
}
function Other()
{
  return (
    <>
    <nav>
    <Link to="/"> Home </Link>
  </nav>
    <div className="clock">
      <Clock/>
    </div>
    </>
  );
}
const Edit = (props)=>
{
  console.log("ah");
  return (
    <>
    <nav>
    <Link to="/"> Home </Link>
  </nav>
    <div className="ed">
      <EditEmployee
      {...props}
      params = {useParams()}
      />

    </div>
    </>
  );
}
function Add()
{
  return (
    <>
    <nav>
    <Link to="/"> Home </Link>
  </nav>
    <div className="adde">
      <AddEmployee/>
    </div>
    </>
  );
}
/*
class Current {
  
  constructor(props) {
    super(props)
    this.state = {
        employees: true,
        clock: false
    }
  }
  
  
    
}
*/
 class Employees extends React.Component {
  
  constructor(props) {
      super(props)
      this.state = {
          employees: []
      }
      
  }

  componentDidMount() {
    
      let self = this;
      fetch('http://64.72.1.192/rest/employees', {
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
              <table className="table table-dark" border="1px solid black">
                  <thead>
                      <tr>
                          <th>First Name</th>
                          <th>M.I.</th>
                          <th>Last Name</th>
                          <th>Job ID</th>
                          <th>Job Level</th>
                          <th>Publisher</th>
                          <th>Hire Date</th>
                          <th>...</th>
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
                      <td><Link to={"/edit/" + employee.emp_id}> Edit </Link></td>
                      </tr>
                  )}
                  </tbody>
              </table>
          </div>
        </div>
      
      
    );
    
  }
}

class EditEmployee extends React.Component {
  
  constructor(props) {
      super(props)
      this.state = {
          employees: []
      }
      
  }

  componentDidMount() {
    let self = this;
    let emp = this.props.params;
      
      //add employee id to end
      fetch('http://64.72.1.192/rest/employees/' + emp.p, {
          method: 'GET'
      }).then(function(response) {
          if (response.status >= 400) {
              throw new Error("Bad response from server");
          }
          
          return response.json();
          
      }).then(function(data) {
        console.log("ah2");
          self.setState({employees: data});
          
      }).catch(err => {
      console.log('caught it!',err);
      })
  }
  
  render() {  
      
    console.log(this.state.employees[0]);   
      return (     
        
          <div className="container"> 
          <div className="panel panel-default p50 uth-panel">
              <table className="table table-dark" border="1px solid black">
                  <thead>
                      <tr>
                          <th>First Name</th>
                          <th>M.I.</th>
                          <th>Last Name</th>
                          <th>Job ID</th>
                          <th>Job Level</th>
                          <th>Publisher</th>
                          <th>Hire Date</th>
                          <th>...</th>
                      </tr>
                  </thead>
                  <tbody>
                  {this.state.employees.map(({emp_id, fname, minit, lname, job_id, job_lvl, pub_id, hire_date}) =>
                      <tr >
                      <td>{fname} </td>
                      <td>{minit} </td>
                      <td>{lname} </td>
                     <td> <input defaultValue={job_id}></input> </td>      count: props.start,
356
      start : props.start,
357
      max: props.max 
358
    };
359
​
360
    this.j = props.jolly; 
361
    
362
  }
363
​
364
  // 3. lifecycle method - called after the component is rendered to the DOM
365
  componentDidMount() {
366
    this.timerID = setInterval(
367
      () => this.tick(), 1000
368
    );
369
  }
370
​
371
  // another lifecycle method 
372
  componentWillUnmount() {
373
    clearInterval(this.timerID); // kill timer 
374
  }
375
​
376
  increment()
377
  {
378
    if(this.state.count >= this.state.max) return this.state.start; 
379
​
380
    return this.state.count + 1; 
381
  }
382
​
383
  tick() {
384
​
385
    // this should be the only place you change state, so render is called.  
386
​
387
    this.setState({  // 'schedules' call to render 
388
      datex: new Date(), // new value for inside of state property
389
      count: this.increment()
390
    });
391
  }
392
​
393
  // 2. called after ctor by React
394
  render() {
395
    return (
396
      <div>
397
        <h1>Hello {this.j}</h1>
398
        <h2>It is {this.state.datex.toLocaleTimeString()}.</h2>
399
        <h2>Count {this.state.count}</h2>
400
      </div>
401
    );
402
  }
403
}
404
​
405
// has to be after the creation of Clock
406
// could pass args here or in the call above.
407
// OR you can just  use <Clock, as you see here.  
408
// NOTE input for properties.  
409
const Clocker = <Clock jolly="ken" start={5} max={10}/>; 
410
//const Clocker =<Clock oi="Employees" s
411
​
412
​
413
​
414
​
415
export default App;
                     <td> <input defaultValue={job_lvl}></input> </td>
                      <td>{pub_id} </td>
                      <td>{hire_date} </td>
                      
                      </tr>
                  )}
                  </tbody>
              </table>
          </div>
        </div>
      
      
    );
    
  }
}
class AddEmployee extends React.Component {
  
  constructor(props) {
      super(props)
      this.state = {
          employees: []
      }
      
  }

  componentDidUnmount() {
      let self = this;
      fetch('http://64.72.1.192/rest/employees', {
          method: 'POST'
      }).then(function(response) {
          if (response.status >= 400) {
              throw new Error("Bad response from server");
          }
          return response.json();
      }).then(function(data) {
        //send stuff here
          self.setState({employees: data});
      }).catch(err => {
      console.log('caught it!',err);
      })
  }
  render() {  
      return (  
          <div className="container"> 
          <div className="panel panel-default p50 uth-panel">
              <>
                <form className="form" align="left">
                <br></br>
                  <label>First Name</label><br></br>
                  <input name="fname"></input>
                  <br></br>
                  <br></br>

                  <label>M.I.</label><br></br>
                  <input name="mi"></input>
                  <br></br>
                  <br></br>

                  <label>Last Name</label><br></br>
                  <input name="lname"></input>
                  <br></br>
                  <br></br>
                  
                  <label>Job ID</label><br></br>
                  <input name="jid"></input>
                  <br></br>
                  <br></br>

                  <label>Job Level</label><br></br>
                  <input name="jlvl"></input>
                  <br></br>
                  <br></br>

                  <label>Publisher</label><br></br>
                  <select>
                    
                    <option value="0736">New Moon Books</option>
                    <option value="0877">Binnet and Hardley</option>
                    <option value="1389">Algodata Infosystems</option>
                    <option value="1622">Five Lakes Publishing</option>
                    <option value="1756">Ramona Publishers</option>
                    <option value="9901">GGG and G</option>
                    <option value="9952">Scootney Books</option>
                    <option value="9999">Lucerne Publishing</option>

                  </select>
                  <br></br>
                  <br></br>

                  <label>Hire Date</label><br></br>
                  <input name="hd"></input>
                  <br></br>
                  <br></br>
                </form>
             </>
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
//const Clocker =<Clock oi="Employees" s




export default App;
