import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { News } from '../shared/news.model';
import { NewsService } from '../shared/news.service';
import { Offer } from '../shared/offer.model';
import { OfferService } from '../shared/offer.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  offers: Offer[];
  news: News[];
  slideOffers: Offer[];

  constructor(public service: OfferService, public newsService: NewsService, private router: Router) {
    this.slideOffers = [];
  }

  ngOnInit(): void {
    this.fetchOffers();
    this.fetchNews();

  }

  async fetchOffers() {
    this.offers = await this.service.getOfferList().toPromise();
    this.offers.length = 5
    this.slideFilter();
  }

  async fetchNews() {
    this.news = await this.newsService.getNews().toPromise();
    console.log("news" + this.news[2].date);

    this.news = this.news.sort((n1, n2) => {
      if (n1.date > n2.date) {
        return 1;
      }
      if (n1.date < n2.date) {
        return -1;
      }
      return 0;
    });
    this.news.length = 5
  }

  slideFilter() {
    for (let i = 0; i < 4; i++) {
      var number = this.getRandomInt(this.offers.length);
      this.slideOffers[i] = this.offers[number];
    }
    console.log(this.slideOffers);
  }

  getRandomInt(max) {
    return Math.floor(Math.random() * max);
  }

  offerRedirect(offerid: number){
    this.router.navigate(['/pageOffer'], {queryParams: {offerID: offerid}});
  }

  newsRedirect(newsid: number){
    this.router.navigate(['/pageNews'], {queryParams: {newsID: newsid}});
  }

}
