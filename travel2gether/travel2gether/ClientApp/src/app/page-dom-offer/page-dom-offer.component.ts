import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DomesticOffer } from '../shared/domestic-offer.model';
import { DomesticOfferService } from '../shared/domestic-offer.service';

@Component({
  selector: 'app-page-dom-offer',
  templateUrl: './page-dom-offer.component.html',
  styleUrls: ['./page-dom-offer.component.css']
})
export class PageDomOfferComponent implements OnInit {
  offerId: number;
  offer: DomesticOffer = new DomesticOffer()

  constructor(public domOfferService: DomesticOfferService, private route: ActivatedRoute) { }

  async ngOnInit(): Promise<void> {
    await this.route.queryParams.subscribe(params => {              //URL-ből az adatokat bekötjük
      this.offerId = params['offerID'];
    });

    this.offer = await this.domOfferService.getDomesticOffer(this.offerId).toPromise();
  }
}
