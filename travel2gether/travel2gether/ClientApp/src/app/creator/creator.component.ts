import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { OfferCRUDComponent } from '../offer-crud/offer-crud.component';

@Component({
  providers:[OfferCRUDComponent],
  selector: 'app-creator',
  templateUrl: './creator.component.html',
  styleUrls: ['./creator.component.css']
})
export class CreatorComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  newsShow(){
    this.router.navigate(['/creator/newsCrud'])
  }

  abroadsShow(){
    this.router.navigate(['/creator/offerCrud'])
  }

  domesticsShow(){
    this.router.navigate(['/creator/domesticCrud'])
  }
 
}
