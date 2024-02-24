'use client';
import './page.scss';
import {notFound} from 'next/navigation'
import {useState} from "react";

interface pageProps {
    params: {
        id: number
    }
}

const handleEdit = (index: number) => {
    console.log(index)
}

interface Pet {
    name: string;
    type: string;
    age: number;
}

export default function Profile({params: {id}}: pageProps) {
    // const data = await getProfile(id)const [isEditing, setIsEditing] = useState(false);
    const [isEditing, setIsEditing] = useState(false);
    const [editStatus, setEditStatus] = useState<boolean[]>([]);

    const handleEdit = () => {
        setIsEditing(true);

        setEditStatus(Array(data.pets.length).fill(true));
    };

    const handleChange = (index: number, field: keyof Pet, value: string | number) => {
        const updatedPets = [...editedPets];
        // @ts-ignore
        updatedPets[index][field] = value;
        setEditedPets(updatedPets);
    };
    const handleConfirm = () => {
        setIsEditing(false);
        setEditStatus(Array(data.pets.length).fill(false));
        // Дополнительная логика для отправки данных на сервер
        console.log("Отправка данных на сервер:", editedPets);
    };


    const data = {
        name: "Vlad",
        email: "vlad@mail.ru",
        pets: [
            {
                id: 1,
                name: "Bobik",
                type: "dog",
                age: 3
            },
            {
                id: 2,
                name: "Sharik",
                type: "dog",
                age: 5
            }
        ],
        donations: [
            {
                id: 1,
                name: "Bobik",
                date: "12.12.2021",
                type: "Плазма",
                amount: "500мл"
            }
        ]
    }
    const [editedPets, setEditedPets] = useState<Pet[]>(data.pets);

    if (!data) {
        notFound()
    }


    return (
        <div className="Profile">
            <h1>Профиль</h1>
            <div className="ProfileContent">
                <div className="leftProfile">
                    <div className="headerContainer">
                        <div className="avatar">
                            <img src="/images/no-profile.png" alt="avatar"/>
                        </div>
                        <div className="headerInfo">
                            <h2>Информация о пользователе</h2>
                            <p>ID: {id}</p>
                            <p>Имя: {data.name}</p>
                            <p>Почта: {data.email}</p>
                        </div>
                    </div>
                    <div className="petsContainer">
                        <h2>Ваши питомцы:</h2>
                        <div className="pets">
                            {editedPets.map((pet, index) => (
                                <div className="pet" key={index}>
                                    <input type="text" value={pet.name} onChange={(e) => handleChange(index, 'name', e.target.value)} disabled={!editStatus[index]} />
                                    <input type="text" value={pet.type} onChange={(e) => handleChange(index, 'type', e.target.value)} disabled={!editStatus[index]} />
                                    <input type="number" value={pet.age} onChange={(e) => handleChange(index, 'age', parseInt(e.target.value))} disabled={!editStatus[index]} />
                                </div>
                            ))}
                        </div>
                        {isEditing ? (
                            <button onClick={handleConfirm}>Подтвердить</button>
                        ) : (
                            <button onClick={handleEdit}>Редактировать</button>
                        )}
                    </div>
                </div>
                <div className="rightProfile">
                    <div className="donationHistory">
                        <h2>История донорства:</h2>
                        <div className="donations">
                            {data.donations.map((donation, index) => {
                                return (
                                    <div className="donation" key={index}>
                                        <p>Донор: {donation.name}</p>
                                        <p>Дата: {donation.date}</p>
                                        <p>Тип: {donation.type}</p>
                                        <p>Объем: {donation.amount}</p>
                                    </div>
                                )
                            })}
                        </div>
                    </div>
                </div>


            </div>
        </div>
    )

}
