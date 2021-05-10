import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { OfferCRUDComponent } from '../offer-crud/offer-crud.component';
import { Offer } from '../shared/offer.model';
import { OfferService } from '../shared/offer.service';

@Component({
  selector: 'app-page-offer',
  templateUrl: './page-offer.component.html',
  styleUrls: ['./page-offer.component.css']
})
export class PageOfferComponent implements OnInit {
  offerId: number;
  offer: Offer = new Offer()

  constructor(public offerService: OfferService, private route: ActivatedRoute) { }

  async ngOnInit(): Promise<void> {
    await this.route.queryParams.subscribe(params => {              //URL-ből az adatokat bekötjük
      this.offerId = params['offerID'];
    });

    this.offer = await this.offerService.getOffer(this.offerId).toPromise();
  }



}
