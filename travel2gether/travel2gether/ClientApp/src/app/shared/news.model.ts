export class News {
    id: number;
    header: string;
    body: string;
    hashtag: string;
    picSrc: string;
    date: string;

    constructor(){
        this.id = 0;
        this.header = "";
        this.body = "";
        this.hashtag = "";
        this.picSrc = "";
        this.date = "";
    }
}