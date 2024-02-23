import './page.scss';
import { getProfile } from "@/http/userAPI";
import { notFound } from 'next/navigation'

interface pageProps {
    params: {
        id: number
    }
}

export default async function Profile({ params: { id } }: pageProps) {
    const data = await getProfile(id)
    if (!data){
        notFound()
    }
    console.log(data)
    return (
        <div className="Profile">
            <div className="HomeContent">
                <div className="headerContainer">
                    <div className="headerInfo">
                        <h1>{data.name}</h1>
                        <h2>{data.email}</h2>
                    </div>
                </div>
            </div>
        </div>
    )

}
