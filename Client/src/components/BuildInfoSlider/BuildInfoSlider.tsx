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
                        <div className={`buttonTab ${activeTab === 'Здоровье' ? 'active' : ''}`} onClick={() => openTab('Здоровье')}>
                            <button className="Здоровье">Здоровье</button>
                        </div>
                        <div className={`buttonTab ${activeTab === 'Обследование' ? 'active' : ''}`} onClick={() => openTab('Обследование')}>
                            <button className="Обследование">Обследование</button>
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
                                <h2>Поддержание здорового состояния кровеносной системы</h2>
                                <p>Пожертвование крови может стимулировать организм к производству новых красных кровяных клеток, что способствует обновлению кровеносной системы и может снизить риск сердечно-сосудистых заболеваний.</p>
                            </div>
                        </div>
                    </div>
                    <div id="Бонусы" className="tabcontent" style={{ display: activeTab === 'Бонусы' ? 'block' : 'none' }}>
                        <div className="BuildInfoSliderItem">
                            <div className="BuildInfoSliderItemImg" >
                                <Image src="/images/buildTabs/photo2.jpg" width={409} height={279} alt="GamingPic" />
                            </div>
                            <div className="BuildInfoSliderItemText">
                                <h2>Вакцинация</h2>
                                <p>Донорам начиная со второй донации, бесплатно проводится комплексная ежегодная вакцинация с занесением отметки в паспорт!</p>
                            </div>
                        </div>
                    </div>
                    <div id="Здоровье" className="tabcontent" style={{ display: activeTab === 'Здоровье' ? 'block' : 'none' }}>
                        <div className="BuildInfoSliderItem">
                            <div className="BuildInfoSliderItemImg">
                                <Image src="/images/buildTabs/photo1.jpg" width={409} height={279} alt="Здоровье" />
                            </div>
                            <div className="BuildInfoSliderItemText">
                                <h2>Снижение уровня железа в организме</h2>
                                <p>Пожертвование крови может помочь снизить уровень железа в крови донора, что может быть полезно для здоровья сердца и общего состояния.</p>
                            </div>
                        </div>
                    </div>
                    <div id="Social Media" className="tabcontent" style={{ display: activeTab === 'Обследование' ? 'block' : 'none' }}>
                        <div className="BuildInfoSliderItem">
                            <div className="BuildInfoSliderItemImg">
                                <Image src="/images/buildTabs/photo2.jpg" width={409} height={279} alt="Обследование" />
                            </div>
                            <div className="BuildInfoSliderItemText">
                                <h2>Проверка здоровья</h2>
                                <p>Процесс донорства обычно включает в себя медицинские обследования, чтобы убедиться, что донор находится в хорошем состоянии здоровья. Это может помочь выявить потенциальные проблемы со здоровьем и предотвратить развитие болезней.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}