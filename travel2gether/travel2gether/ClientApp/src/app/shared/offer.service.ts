import { Injectable } from '@angular/core';
import { Offer } from './offer.model';
import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Observable, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OfferService {
  readonly rootUrl = "https://localhost:44399/api/Offer";
  formData: Offer = new Offer();
  list: Offer[];

  constructor(private http: HttpClient) { }

  getOfferList(){
    return this.http.get<Offer[]>(this.rootUrl);
  }

  postOffer(){
    return this.http.post(this.rootUrl, this.formData);
  }

  getOffer(id: number){
    return this.http.get<Offer>(this.rootUrl + "/" + id);
  }

  putOffer(id: number){
    return this.http.put(this.rootUrl + "/" + id, this.formData);
  }

  deleteOffer(id: number){
    this.formData = new Offer()
    return this.http.delete(this.rootUrl + "/" +  id)
  }

}
