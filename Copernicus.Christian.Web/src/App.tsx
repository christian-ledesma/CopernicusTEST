import { Navbar } from './Components/Navbar';
import { Route, Routes, Navigate } from 'react-router-dom'
import Home from './Pages/Home';
import Customers from './Pages/Customers';
import './App.css';

function App() {
  return (
    <div className="App">
      <div className='container'>
        <Navbar />
        <Routes>
          <Route
            path="*"
            element={<Navigate to="/home" replace />}
          />
          <Route path='/home' element={<Home />} />
          <Route path='/customers' element={<Customers />} />
        </Routes>
      </div>
    </div>
  );
}

export default App;
