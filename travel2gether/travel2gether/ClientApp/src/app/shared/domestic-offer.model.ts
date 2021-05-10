export class DomesticOffer {
    id: number;
    destination: string;
    startTime: string;
    endTime: string;
    cost: number;
    picSrc: string;
    detailsSrc: string;
    shortDescription: string;

    constructor(){
        this.id = 0;
        this.destination = "";
        this.startTime = "";
        this.endTime = "";
        this.cost = 0;
        this.picSrc = "";
        this.detailsSrc = "";
        this.shortDescription = "";
    }
}
