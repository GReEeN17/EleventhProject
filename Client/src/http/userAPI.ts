import jwtDecode from "jwt-decode";
import { $authHost, $host } from "./index";

export const registration = async (username: string, email: string, password: string) => {
    const { data } = await $host.post("api/user/registration", {username, password});
    return jwtDecode(data.token);
}

export const login = async (username: string, password: string) => {
    const { data } = await $host.post("api/user/login", { username, password });
    return jwtDecode(data.token);
}

export const check = async () => {
    const { data } = await $authHost.get("api/user/auth");
    return jwtDecode(data.token);
}

export async function getProfile(id: number) {
    const { data } = await $host.get(`api/profile/getProfile?id=${id}`);
    return data;
}
