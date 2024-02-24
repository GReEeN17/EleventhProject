"use client";

import './Header.scss';
import Link from 'next/link';
import { observer } from 'mobx-react-lite';
import { Logo, DefaultAvatar } from '../../../public/images/imgs'
import authStore from '@/app/(site)/store/UserStore';
import modalAuthStore from '@/app/(site)/store/modalAuth';
import dropsStore from '@/app/(site)/store/dropsStore';
import { useClickOutside } from '@/app/(site)/hooks/useClickOutside';
import { useRef } from 'react';


const Header = observer(() => {
    const menuRef = useRef(null);

    useClickOutside(menuRef, () => dropsStore.setIsProfileActive(false));

    let avatar
    if (authStore?._user?.avatar) {
        avatar = authStore._user?.avatar;
    }
    const logout = () => {
        authStore.setIsAuth(false);
        authStore.setUser({
            'id': null,
            'email': null,
            'name': null,
            'role': null,
            'avatar': null
        });
        dropsStore.setIsProfileActive(false);
        localStorage.removeItem('token');
    }

    return (
        <header className="header">
            <nav className="navigate">
                <Link href="/">
                    <div className="logo">
                        <Logo />
                    </div>
                </Link>
                <div className="links">
                    <div className="AboutUs">
                        <Link href={"/AboutUs"}>О нас</Link>
                    </div>

                </div>
                {/* <Socials /> */}
                {authStore._isAuth ? (
                    <div className="authLogin" ref={menuRef}>
                        <button className='avatarbnt' onClick={() => dropsStore.setIsProfileActive(!dropsStore.isProfileActive)}>
                            <div className="avatar">
                                {avatar ? <img src={avatar} alt="avatar" /> : <DefaultAvatar />}
                            </div>
                        </button>
                        <div className={dropsStore.isProfileActive ? 'dropdown active' : 'dropdown'}>
                            <Link className='dropitem' href="/"  onClick={() => dropsStore.setIsProfileActive(false)}>Profile</Link>
                            <Link className='dropitem' href="/settings" onClick={() => dropsStore.setIsProfileActive(false)}>Settings</Link>
                            <button className='dropitem' onClick={logout}>Выйти</button>
                        </div>
                    </div>
                ) : (
                    <div className="auth">
                        <button className="Signin" onClick={() => modalAuthStore.setIsActive(true)}>Войти</button>
                    </div>
                )}
            </nav>
        </header>
    );
});

export default Header;
