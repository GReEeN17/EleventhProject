"use client";
import '@/components/NewsContentSlider/NewsContentSlider.scss'
import Image from 'next/image'
import React, {useState} from 'react'


export default function Newsletter() {
    const orders = [
        {
            id: "1",
            name: 'Бобик',
            blood_type: 'O(I) Rh-',
            date_end: 'До 26 февраля',
            address: 'Санкт-Петербург, Кронверкский пр-т 49,',
            owner: 'Зелень Александр',
            required: '4',
            current: '1'
        },
        {
            id: "2",
            name: 'Зайчик',
            blood_type: 'A(II) Rh+',
            date_end: 'До 27 февраля',
            address: 'Москва, Тверская ул. 12, квартира 12',
            owner: 'Петров Петр',
            required: '2',
            current: '1'
        },
        {
            id: "3",
            name: 'Сидоджи',
            blood_type: 'B(III) Rh-',
            date_end: 'До 28 февраля',
            address: 'Новосибирск, Красный пр-т 100, квартира 200',
            owner: 'Иванов Иван',
            required: '3',
            current: '1'
        },
        {
            id: "4",
            name: 'Корнелиус',
            blood_type: 'AB(IV) Rh+',
            date_end: 'До 29 февраля',
            address: 'Екатеринбург, Ленина ул. 30, квартира 30',
            owner: 'Кузнецов Кирилл',
            required: '4',
            current: '1'
        },
        {
            id: "5",
            name: 'Бублик',
            blood_type: 'O(I) Rh-',
            date_end: 'До 30 февраля',
            address: 'Санкт-Петербург, Невский пр-т 1, квартира 1',
            owner: 'Смирнов Александр',
            required: '1',
            current: '1'
        }
    ]

    const [index, setIndex] = useState(0)
    const [trans, setTrans] = useState(false)
    const [transR, setTransR] = useState(false);
    const itemWidth = 401; // ширина одного элемента слайдера

    const handlePrev = () => {
        setTransR(true);
        setTrans(false);
        const nextIndex = index - 1;
        document.querySelector('.NewsArrowsRight')!.classList.remove('disabled');
        document.querySelector('.NewsArrowsRightBtn')!.classList.remove('disabled');
        if (nextIndex < 1) {
            document.querySelector('.NewsArrowsLeft')!.classList.add('disabled')
            document.querySelector('.NewsArrowsLeftBtn')!.classList.add('disabled')
            setIndex(nextIndex);
        } else {
            ;
            setIndex(nextIndex);
        }
    };

    const handleNext = () => {
        setTrans(true);
        setTransR(false);
        const nextIndex = index + 1;
        document.querySelector('.NewsArrowsLeft')!.classList.remove('disabled');
        document.querySelector('.NewsArrowsLeftBtn')!.classList.remove('disabled');
        if (nextIndex >= orders.length - 3) {
            document.querySelector('.NewsArrowsRight')!.classList.add('disabled')
            document.querySelector('.NewsArrowsRightBtn')!.classList.add('disabled')
            setIndex(nextIndex);
        } else {
            setIndex(nextIndex);
        }
    };

    const transformValue = `translateX(-${index * itemWidth}px)`;

    const Slides = () => orders.map((item) => (
        <div className="SliderItem" key={item.id}>
            <div className="SliderItemContent">
                <div className="SliderItemDate">
                    <p>{item.date_end}</p>
                </div>
                <div className="SliderUsername">
                    <p>{item.name}</p>
                    <div className="SliderItemBloodType">
                        {item.blood_type}
                    </div>
                </div>

                <div className="SliderItemAddress">
                    <svg width="24" height="24" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <path
                            d="M12 12.75C13.6569 12.75 15 11.4069 15 9.75C15 8.09315 13.6569 6.75 12 6.75C10.3431 6.75 9 8.09315 9 9.75C9 11.4069 10.3431 12.75 12 12.75Z"
                            stroke="#4E5355" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"></path>
                        <path
                            d="M19.5 9.75C19.5 16.5 12 21.75 12 21.75C12 21.75 4.5 16.5 4.5 9.75C4.5 7.76088 5.29018 5.85322 6.6967 4.4467C8.10322 3.04018 10.0109 2.25 12 2.25C13.9891 2.25 15.8968 3.04018 17.3033 4.4467C18.7098 5.85322 19.5 7.76088 19.5 9.75V9.75Z"
                            stroke="#4E5355" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"></path>
                    </svg>
                    <p>{item.address}</p>
                </div>
                <div>
                    <p>{item.current}/{item.required} уже найдено</p>
                </div>
                <div className="SliderItemOwner">
                    <p>Ищет</p>
                </div>
                <div>
                    <p>{item.owner}</p>
                </div>
            </div>
        </div>
    ));

    return (
        <div className="InTheNewsContainer">
            <div className="InTheNews">
                <div className="HeadNews">
                    <div className="InTheNewsText">
                        <p>Заявки на донорство</p>
                    </div>
                    <div className="NewsArrows">
                        <div className="NewsArrowsLeft disabled" onClick={handlePrev}>
                            <button className="NewsArrowsLeftBtn disabled"/>
                        </div>
                        <div className="NewsArrowsRight" onClick={handleNext}>
                            <button className="NewsArrowsRightBtn"/>
                        </div>
                    </div>

                </div>
                <div className="NewsContentSliderContainer">
                    <div className="NewsContentSlider">
                        <div className="SliderContent" style={{transform: transformValue}}>
                            <Slides/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}