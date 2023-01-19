import logo from '../logo.svg';
import { NavLink } from 'react-router-dom'

export const Navbar = () => {
    return (
        <header className="d-flex flex-wrap align-items-center justify-content-center justify-content-md-between py-3 mb-4 border-bottom">
            <a href="/" className="d-flex align-items-center col-md-3 mb-2 mb-md-0 text-dark text-decoration-none">
                <img src={logo} className="App-logo" alt="logo" />
            </a>
            <ul className="nav col-12 col-md-auto mb-2 justify-content-center mb-md-0">
                <li>
                    <NavLink className="nav-link px-2 link-dark" to="/home">Home</NavLink>
                </li>
                <li>
                    <NavLink className="nav-link px-2 link-dark" to="/customers">Customers</NavLink>
                </li>
            </ul>
        </header>
    );
};
