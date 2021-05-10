import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { DomesticOffer } from '../shared/domestic-offer.model';
import { DomesticOfferService } from '../shared/domestic-offer.service';

@Component({
  selector: 'app-domesticoffers',
  templateUrl: './domesticoffers.component.html',
  styleUrls: ['./domesticoffers.component.css']
})
export class DomesticoffersComponent implements OnInit {

  domesticOffer: DomesticOffer[];
  constructor(public domesticService: DomesticOfferService, private router: Router) { }

  ngOnInit(): void {
    this.fetchDomestic();  
  }

  async fetchDomestic(){
    this.domesticOffer = await this.domesticService.getDomesticOffers().toPromise();
  }

  redirectToPage(id){
    this.router.navigate(['/pageDomOffer'], {queryParams: {offerID: id}});
  }

}
