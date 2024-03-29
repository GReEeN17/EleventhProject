'use client';
import './globals.css'
import { Inter } from 'next/font/google'
import Header from '@/components/Header/Header';

import { useEffect, useState } from 'react';
import UserStore from '@/app/(site)/store/UserStore';
import { check } from '@/http/userAPI';
import { observer } from 'mobx-react-lite';
import { AuthComp, RegComp } from '@/components/AuthModal/AuthModal';
import modalAuthStore from './(site)/store/modalAuth';

const inter = Inter({ subsets: ['latin'] })


export default observer(function RootLayout({ children }: { children: React.ReactNode }) {
  const [loading, setLoading] = useState(true)
  const isLogin = modalAuthStore.IsLoginWindow;
  useEffect(() => {
    check().then(data => {
      UserStore.setIsAuth(true);
      UserStore.setUser(data);
      localStorage.setItem('data', JSON.stringify(data));
    }).finally(() => setLoading(false))
  }, [])

  if (false) {
    return (
      <html lang="en">
        <body className={inter.className}>
          <div>Loading...</div>
        </body>
      </html>
    )
  }

  return (
    <html lang="en">
      <body className={inter.className}>
        <Header />
        {isLogin ? <AuthComp /> : <RegComp />}
        <main>{children}</main>
      </body>
    </html>
  )
}
)