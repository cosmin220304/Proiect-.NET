import { Tweet } from "./tweet";

export interface Profile {
    id: number;
    name: string;
    username: string;
    imageUrl: string;
    tweets: Tweet[];
}
