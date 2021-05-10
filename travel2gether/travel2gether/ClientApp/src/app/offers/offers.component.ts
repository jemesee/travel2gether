import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Offer } from '../shared/offer.model';
import { OfferService } from '../shared/offer.service';

@Component({
  selector: 'app-offers',
  templateUrl: './offers.component.html',
  styleUrls: ['./offers.component.css']
})
export class OffersComponent implements OnInit {
  
  offers: Offer[];
  error: any;

  constructor(public service: OfferService, private router: Router) { 
    this.offers = [];
  }

  ngOnInit(): void {
    //document.getElementById("searchtitle").addEventListener("click", this.searchbar_show);
    this.fetchData();  
  }

  async fetchData(){
    this.offers = await this.service.getOfferList().toPromise();
    console.log("Data: " + JSON.stringify(this.offers));
    console.log("Data: " + this.offers[0].destination);
    this.offers.forEach(element => console.log(element.destination));
  }

  searchbar_show() {
    var x = document.getElementById("searchbar");
    if (x.style.display === "none") {
      x.style.display = "flex";
      x.style.opacity = "1";
    } else {
      x.style.display = "none";
      x.style.opacity = "0";
    }
  }

  routeToOffer(offerid){
    this.router.navigate(['/pageOffer'], {queryParams: {offerID: offerid}});
  }

}
