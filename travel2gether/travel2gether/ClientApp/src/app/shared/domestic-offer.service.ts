import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { DomesticOffer } from './domestic-offer.model';

@Injectable({
  providedIn: 'root'
})
export class DomesticOfferService {
  formData: DomesticOffer = new DomesticOffer();
  readonly rootUrl = "https://localhost:44399/api/DomesticOffers";
  list: DomesticOffer[];

  constructor(private http: HttpClient) { }

  getDomesticOffers(){
    return this.http.get<DomesticOffer[]>(this.rootUrl);
  }
  
  postDomesticOffer(){
    return this.http.post(this.rootUrl, this.formData);
  }

  getDomesticOffer(id: number){
    return this.http.get<DomesticOffer>(this.rootUrl + "/" + id);
  }

  putDomesticOffer(id: number){
    return this.http.put(this.rootUrl + "/" + id, this.formData);
  }

  deleteDomesticOffer(id: number){
    this.formData = new DomesticOffer()
    return this.http.delete(this.rootUrl + "/" +  id)
  }
}
