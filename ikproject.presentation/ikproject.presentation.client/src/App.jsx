import { useEffect, useState } from 'react';
import './App.css';

function App() {
    const [managers, setManagers] = useState([]);

    useEffect(() => {
        fetch("https://localhost:7026/api/Yonetici/GetAllYoneticiler")
            .then(response => {
                return response.json();
            })
            .then(data => {
                setManagers(data);
            })
    }, []);

    const contents = <table className="table table-striped" aria-labelledby="tabelLabel">
        <thead>
            <tr>
                <th>Foto�raf: </th>
                <th>Ad: </th>
                <th>Soyad: </th>
                <th>Do�um Tarihi: </th>
                <th>Do�um Yeri: </th>
                <th>TC: </th>
                <th>i�e Giri� Tarihi: </th>
                <th>Mail: </th>
                <th>Adres: </th>           
                <th>Telefon: </th>           
            </tr>
        </thead>
        <tbody>
            {managers.map(manager => (
                <tr key={manager.id}>
                    <td>{manager.Photo}</td>
                    <td>{manager.firstName}</td>
                    <td>{manager.lastName}</td>
                    <td>{manager.DateOfBirth}</td>
                    <td>{manager.id}</td>
                    <td>{manager.SecondName}</td>
                    <td>{manager.email}</td>
                    <td>{manager.address}</td>
                    <td>{manager.phoneNumber}</td>
                    <td>{manager.department}</td>
                </tr>
            ))}
        </tbody>
    </table>;


    return (
        <div>
            <h1 id="tabelLabel">Y�neticiler</h1>
             {contents}
        </div>
    );
}

export default App;
