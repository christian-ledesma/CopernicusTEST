import React from 'react';
import CustomerTable from "../Components/CustomerTable";
import NewCustomerForm from '../Components/NewCustomerForm';

const Customers = () => {
  const [customers, setCustomers] = React.useState([]);
  const [isLoading, setIsLoading] = React.useState(false);
  const [formIsActive, setFormIsActive] = React.useState(false);

  React.useEffect(() => {
    const fetchUrl = async (url: string) => {
      setIsLoading(true);
      const response = await fetch(url);
      const data = await response.json();
      setCustomers(data);
      setIsLoading(false);
    };

    const url = "https://localhost:7244/api/v1/customer/list";
    fetchUrl(url);
  }, []);

  const Create = async () => {
    setFormIsActive(true);
  }

  return (
    <div>
      <NewCustomerForm show={formIsActive} />
      <h2 className="text-start">
        Customers
        <button type="button" className="btn btn-primary btn-sm" onClick={Create}>New</button>
      </h2>
      {!isLoading && <CustomerTable customers={customers} />}
      {isLoading && <h3>Loading...</h3>}
    </div>
  );
};

export default Customers;
