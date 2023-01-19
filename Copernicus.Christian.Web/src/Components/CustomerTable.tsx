import React from "react";
import { Button, Modal, ModalHeader, ModalBody, ModalFooter, FormGroup } from 'react-bootstrap';

const CustomerTable = (props: any) => {
    const [customer, setCustomer] = React.useState({
        first: '',
        last: '',
        company: '',
        country: '',
        email: '',
    });
    const [editarIsActive, setEditarIsActive] = React.useState(false);

    const EditCustomer = async () => {
        await fetch("https://localhost:7244/api/v1/customer/",{
            method: "PUT",
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(customer)
        }).catch(error => console.log(error));
        setEditarIsActive(false);
        window.location.reload();
    };

    const DeleteCustomer = async (id: number) => {
        await fetch("https://localhost:7244/api/v1/customer/" + id,{
            method: "DELETE"
        });
        window.location.reload();
    };

    const showEditModal = (record: any) => {
        setCustomer(record);
        setEditarIsActive(record);
    };

    const hideEditModal = () => {
        setEditarIsActive(false);
    };

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

    return (
        <div>
            <div className="table-responsive">
                <table className="table table-striped table-sm">
                    <thead>
                        <tr>
                            <th scope="col">Name</th>
                            <th scope="col">Surname</th>
                            <th scope="col">Company</th>
                            <th scope="col">Country</th>
                            <th scope="col">Email</th>
                            <th scope="col">Actions</th>
                        </tr>
                    </thead>
                    <tbody>
                        {props.customers.map((customer: any, index: any) => {
                            return (
                                <tr key={index}>
                                    <td>{customer.first}</td>
                                    <td>{customer.last}</td>
                                    <td>{customer.company}</td>
                                    <td>{customer.country}</td>
                                    <td>{customer.email}</td>
                                    <td>
                                        <button type="button" className="btn btn-success btn-sm" onClick={ () => showEditModal(customer) }>Edit</button>
                                        <button type="button" className="btn btn-danger btn-sm" onClick={ () => DeleteCustomer(customer.id) }>Delete</button>
                                    </td>
                                </tr>
                            )
                        })}
                    </tbody>
                </table>
            </div>
            <Modal show={editarIsActive}>
                <ModalHeader>
                    <div>
                        <h3>Editar Registro</h3>
                    </div>
                </ModalHeader>
                <ModalBody>
                    <FormGroup>
                        <label>Name</label>
                        <input type="text" className="form-control" value={customer.first} onChange={nameHandler} />
                    </FormGroup>
                    <FormGroup>
                        <label>Surname</label>
                        <input type="text" className="form-control" value={customer.last} onChange={surnameHandler} />
                    </FormGroup>
                    <FormGroup>
                        <label>Company</label>
                        <input type="text" className="form-control" value={customer.company} onChange={companyHandler} />
                    </FormGroup>
                    <FormGroup>
                        <label>Country</label>
                        <input type="text" className="form-control" value={customer.country} onChange={countryHandler} />
                    </FormGroup>
                    <FormGroup>
                        <label>Email</label>
                        <input type="text" className="form-control" value={customer.email} onChange={emailHandler} />
                    </FormGroup>
                </ModalBody>
                <ModalFooter>
                    <Button color="primary" onClick={EditCustomer}>Editar</Button>
                    <Button color="danger" onClick={hideEditModal}>Cancelar</Button>
                </ModalFooter>
            </Modal>
        </div>
    );
};

export default CustomerTable;
