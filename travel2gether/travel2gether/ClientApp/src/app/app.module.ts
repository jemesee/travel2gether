import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { NavbarComponent } from './navbar/navbar.component';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { SearchComponent } from './search/search.component';
import { OffersComponent } from './offers/offers.component';
import { DomesticoffersComponent } from './domesticoffers/domesticoffers.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { OfferService } from './shared/offer.service';
import { CommonModule } from '@angular/common';
import { CreatorComponent } from './creator/creator.component';
import { DomesticOfferService } from './shared/domestic-offer.service';
import { NewsService } from './shared/news.service';
import { OfferCRUDComponent } from './offer-crud/offer-crud.component';
import { DomesticCRUDComponent } from './domestic-crud/domestic-crud.component';
import { NewsCRUDComponent } from './news-crud/news-crud.component';
import { FileHttpService } from './shared/file-http.service';
import { PageOfferComponent } from './page-offer/page-offer.component';
import { PageNewsComponent } from './page-news/page-news.component';
import { PageDomOfferComponent } from './page-dom-offer/page-dom-offer.component';
import { NewsComponent } from './news/news.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    NavbarComponent,
    HomeComponent,
    SearchComponent,
    OffersComponent,
    DomesticoffersComponent,
    CreatorComponent,
    OfferCRUDComponent,
    DomesticCRUDComponent,
    NewsCRUDComponent,
    PageOfferComponent,
    PageNewsComponent,
    PageDomOfferComponent,
    NewsComponent
  ],
  imports: [
    BrowserModule,
    CommonModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent },
      { path: 'navbar', component: NavbarComponent },
      { path: 'login', component: LoginComponent },
      { path: 'home', component: HomeComponent },
      { path: 'search', component: SearchComponent },
      { path: 'offers', component: OffersComponent },
      { path: 'domesticoffers', component: DomesticoffersComponent },
      { path: 'news', component: NewsComponent },
      { path: 'pageOffer', component: PageOfferComponent },
      { path: 'pageNews', component: PageNewsComponent },
      { path: 'pageDomOffer', component: PageDomOfferComponent },
      {
        path: 'creator', component: CreatorComponent,
        children: [
          {
            path: 'offerCrud',
            component: OfferCRUDComponent
          },
          {
            path: 'domesticCrud',
            component: DomesticCRUDComponent
          },
          {
            path: 'newsCrud',
            component: NewsCRUDComponent
          }
        ]
      }
    ]),
    NgbModule
  ],
  providers: [
    OfferService,
    DomesticOfferService,
    NewsService,
    FileHttpService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }


/*  narancs: #fcb900;
    kék: rgb(0, 195, 255);
    szürke: #f7f7f7 */