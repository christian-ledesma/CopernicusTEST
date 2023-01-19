import React from 'react';

const NewCustomerForm = (props: any) => {
    const [customer, setCustomer] = React.useState({
        first: '',
        last: '',
        company: '',
        country: '',
        email: '',
    });
    if (!props.show) return <></>;

    const nameHandler = (event: any) => {
        setCustomer(prevState => {
            return {
                ...prevState,
                first: event.target.value
            };
        });
    };

    const surnameHandler = (event: any) => {
        setCustomer(prevState => {
            return {
                ...prevState,
                last: event.target.value
            };
        });
    };

    const companyHandler = (event: any) => {
        setCustomer(prevState => {
            return {
                ...prevState,
                company: event.target.value
            };
        });
    };

    const countryHandler = (event: any) => {
        setCustomer(prevState => {
            return {
                ...prevState,
                country: event.target.value
            };
        });
    };

    const emailHandler = (event: any) => {
        setCustomer(prevState => {
            return {
                ...prevState,
                email: event.target.value
            };
        });
    };

    const CreateCustomer = async (event: any) => {
        await fetch("https://localhost:7244/api/v1/customer/",{
            method: "POST",
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(customer)
        }).catch(error => console.log(error));
    };

    return (
        <form className="row g-3" onSubmit={CreateCustomer}>
            <div className="col-auto">
                <input type="text" className="form-control" value={customer.first} placeholder="Name" onChange={nameHandler}/>
            </div>
            <div className="col-auto">
                <input type="text" className="form-control" value={customer.last} placeholder="Surname" onChange={surnameHandler}/>
            </div>
            <div className="col-auto">
            <input type="text" className="form-control" value={customer.company} placeholder="Company" onChange={companyHandler}/>
            </div>
            <div className="col-auto">
                <input type="text" className="form-control" value={customer.country} placeholder="Country" onChange={countryHandler}/>
            </div>
            <div className="col-auto">
                <input type="text" className="form-control" value={customer.email} placeholder="Email" onChange={emailHandler}/>
            </div>
            <div className="col-auto">
                <button type="submit" className="btn btn-primary mb-3" >Send</button>
            </div>
        </form>
    );
};

export default NewCustomerForm;
