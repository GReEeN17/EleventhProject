import axios from "axios";

const $host = axios.create({
    baseURL: 'http://31.129.48.39:5108/'
});

const $authHost = axios.create({
    baseURL: 'http://31.129.48.39:5108/'
});

const authInterceptor = (config: any) => {
    return config;
}

$authHost.interceptors.request.use(authInterceptor);

export {
    $host,
    $authHost
}
