"use client";
import '@/components/BuildInfoSlider/BuildInfoSlider.scss'
import Image from 'next/image'
import React, { useState } from 'react'



export default function BuildInfoSlider() {
    const [activeTab, setActiveTab] = useState('Польза');

    const openTab = (tabName: string) => {
        setActiveTab(tabName);
    }

    return (
        <div className="BuildInfoTabsContainer">
            <div className="BuildInfoTabs">
                <div className="BuildHeader">
                    <h1>Почему это важно?</h1>
                    <div className="BuildBtns">
                        <div className={`buttonTab ${activeTab === 'Польза' ? 'active' : ''}`} onClick={() => openTab('Польза')}>
                            <button className="Gaming active">Польза</button>
                        </div>
                        <div className={`buttonTab ${activeTab === 'Бонусы' ? 'active' : ''}`} onClick={() => openTab('Бонусы')}>
                            <button className="Software">Бонусы</button>
                        </div>
                        <div className={`buttonTab ${activeTab === 'Game coins' ? 'active' : ''}`} onClick={() => openTab('Game coins')}>
                            <button className="Game coins">Game coins</button>
                        </div>
                        <div className={`buttonTab ${activeTab === 'Social Media' ? 'active' : ''}`} onClick={() => openTab('Social Media')}>
                            <button className="Social Media">Social Media</button>
                        </div>
                    </div>
                </div>
                <div className="InfoTabs">
                    <div id="Польза" className="tabcontent" style={{ display: activeTab === 'Польза' ? 'block' : 'none' }}>
                        <div className="BuildInfoSliderItem">
                            <div className="BuildInfoSliderItemImg">
                                <Image src="/images/buildTabs/photo1.jpg" width={409} height={279} alt="GamingPic" />
                            </div>
                            <div className="BuildInfoSliderItemText">
                                <h2>Типа польза</h2>
                                <p>Сдача крови полезна для донора! Быстрее происходит обновление клеточного сустава.</p>
                            </div>
                        </div>
                    </div>
                    <div id="Software" className="tabcontent" style={{ display: activeTab === 'Бонусы' ? 'block' : 'none' }}>
                        <div className="BuildInfoSliderItem">
                            <div className="BuildInfoSliderItemImg" >
                                <Image src="/images/buildTabs/photo2.jpg" width={409} height={279} alt="GamingPic" />
                            </div>
                            <div className="BuildInfoSliderItemText">
                                <h2>Типонусы</h2>
                                <p>Донорам начиная со второй донации, бесплатно проводится комплексная ежегодная вакцинация с занесением отметки в паспорт!</p>
                            </div>
                        </div>
                    </div>
                    <div id="Game coins" className="tabcontent" style={{ display: activeTab === 'Game coins' ? 'block' : 'none' }}>
                        <div className="BuildInfoSliderItem">
                            <div className="BuildInfoSliderItemImg">
                                <Image src="/images/buildTabs/photo1.jpg" width={409} height={279} alt="GamingPic" />
                            </div>
                            <div className="BuildInfoSliderItemText">
                                <h2>Lorem ipsum dolor sim dolor sit amet, consectetur</h2>
                                <p>Learn more about Game coins</p>
                            </div>
                        </div>
                    </div>
                    <div id="Social Media" className="tabcontent" style={{ display: activeTab === 'Social Media' ? 'block' : 'none' }}>
                        <div className="BuildInfoSliderItem">
                            <div className="BuildInfoSliderItemImg">
                                <Image src="/images/buildTabs/photo2.jpg" width={409} height={279} alt="GamingPic" />
                            </div>
                            <div className="BuildInfoSliderItemText">
                                <h2>Lorsectetur lorem ipsum dolor sit amet, consectetur</h2>
                                <p>Learn more about Social Media</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}