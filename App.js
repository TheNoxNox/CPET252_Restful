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
  <h1>Employees</h1>
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
    <h1>Edit Employee</h1>
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
const SaveEdit = (id, fn, mi, ln, jd, jl, pi, hd, met) => 
  {
    var empl = 
      {
          "emp_id": id, 
          "fname": fn, 
          "minit": mi, 
          "lname": ln, 
          "job_id": jd, 
          "job_lvl": jl, 
          "pub_id": pi, 
          "hire_date": hd
      }
    
    var da = JSON.stringify(empl);

    return (
   console.log(id),
   console.log(fn),


   fetch('http://64.72.1.222/rest/employees', {
          method: met,
          headers: {
            'Content-Type': 'application/json',
          },
          body: da
      }).then(function(response) {
          if (response.status >= 400) {
              throw new Error("Bad response from server");
          }
          return response.json();
      }).then(function(data) {
          //self.setState({employees: data});
      }).catch(err => {
      console.log('caught it!',err);
      })
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
      fetch('http://64.72.1.222/rest/employees', {
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
          <div style={{display: 'flex',  justifyContent:'center', alignItems:'center'}}>
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
      fetch('http://64.72.1.222/rest/employees/' + emp.p, {
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
    let t1 = React.createRef();
    let t2 = React.createRef();
    //console.log(this.state.employees[0]);   
      return (     
        
          <div className="container"> 
          <div className="panel panel-default p50 uth-panel">
          <div style={{display: 'flex',  justifyContent:'center', alignItems:'center'}}>
              <table className="table table-dark" border="1px solid black">
                  <thead>
                      <tr key="hi">
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
                      <>
                      
                      <tr key={emp_id}>
                      <td  key={fname}>{fname} </td>
                      <td  key={minit}>{minit} </td>
                      <td key={lname}>{lname} </td>
                      
                     <td  key={job_id}> <input ref={t1} defaultValue={job_id} id="jid"></input> </td>
                     <td  key={job_lvl}> <input ref={t2} defaultValue={job_lvl} id="jl"></input> </td>
                    
                      <td key={pub_id}>{pub_id} </td>
                      <td  key={hire_date}>{hire_date} </td>
                      <td key={"uy"}><button onClick={() => SaveEdit(emp_id, fname, minit, lname, t1.current.value, t2.current.value, pub_id, hire_date, 'PUT')}>
                      Save
                      </button></td>
                      </tr>
                      
                      
                      
                      </>
                      
                  )}
                  
                  </tbody>
              </table>
              <br></br>
              <br></br>
             
          </div>
          
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
      fetch('http://64.72.1.222/rest/employees', {
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
    let f1 = React.createRef();
    let f2 = React.createRef(); 
    let f3 = React.createRef();
    let f4 = React.createRef(); 
    let f5 = React.createRef();
    let f6 = React.createRef(); 
    let f7 = React.createRef();
    let f8 = React.createRef();  
      return (  
          <div className="container"> 
          <div className="panel panel-default p50 uth-panel">
              <>
                <form className="form" align="left">
                <br></br>

                  <label>Employee ID</label><br></br>
                  <input name="id" ref={f1}></input>
                  <br></br>
                  <br></br>

                  <label>First Name</label><br></br>
                  <input name="fname" ref={f2}></input>
                  <br></br>
                  <br></br>

                  <label>M.I.</label><br></br>
                  <input name="mi" ref={f3}></input>
                  <br></br>
                  <br></br>

                  <label>Last Name</label><br></br>
                  <input name="lname" ref={f4}></input>
                  <br></br>
                  <br></br>
                  
                  <label>Job ID</label><br></br>
                  <input name="jid" ref={f5}></input>
                  <br></br>
                  <br></br>

                  <label>Job Level</label><br></br>
                  <input name="jlvl" ref={f6}></input>
                  <br></br>
                  <br></br>

                  <label>Publisher</label><br></br>
                  <select ref={f7}>
                    
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
                  <input name="hd" ref={f8}></input>
                  <br></br>
                  <br></br>
                  <button onClick={() => SaveEdit(f1.current.value, f2.current.value, f3.current.value, f4.current.value, f5.current.value, f6.current.value, f7.current.value, f8.current.value, 'POST')}>
                      Save
                      </button>
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
export default App;
