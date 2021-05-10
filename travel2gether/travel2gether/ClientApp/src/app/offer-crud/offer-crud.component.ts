import { Component, OnInit } from '@angular/core';
import { NgbDate } from '@ng-bootstrap/ng-bootstrap';
import { FileHttpService } from '../shared/file-http.service';
import { Offer } from '../shared/offer.model';
import { OfferService } from '../shared/offer.service';

@Component({
  selector: 'app-offer-crud',
  templateUrl: './offer-crud.component.html',
  styleUrls: ['./offer-crud.component.css']
})
export class OfferCRUDComponent implements OnInit {
  imageUrl: string = "/assets/img/white.png";
  fileToUpload: File = null;
  detailToUpload: File = null;
  picChange: boolean = false

  startDate: string ="";
  startDatePicker: NgbDate
  endDate: string = "";
  endDatePicker: NgbDate
  returned: Offer = new Offer();
  editOffer: Offer = new Offer();
  offerList: Offer[];

  constructor(private imageService: FileHttpService, public offerService: OfferService) { }
  
  async ngOnInit(): Promise<void> {
    this.offerService.formData = new Offer()
    this.offerList = await this.offerService.getOfferList().toPromise();
  }

  async loadDestination(offerId: number){
    this.editOffer = await this.offerService.getOffer(offerId).toPromise();
    this.editOffer.cost = this.editOffer.cost as number
    this.offerService.formData = this.editOffer;
    this.imageUrl = this.editOffer.picSrc
    var dates = this.editOffer.startTime.split(".")
    this.startDatePicker = new NgbDate(parseInt(dates[0]), parseInt(dates[1]), parseInt(dates[2]));
    dates = this.editOffer.endTime.split(".")
    this.endDatePicker = new NgbDate(parseInt(dates[0]), parseInt(dates[1]), parseInt(dates[2]));
    
  }

  async deleteOffer(){
    let id = this.offerService.formData.id 
    if(id != 0){
      this.offerService.deleteOffer(id)
      .subscribe(
        async res=>{
          this.offerList = await this.offerService.getOfferList().toPromise()
        },
        err=>{ console.log(err)}
      )
      this.imageService.deleteOfferImage(id)
      .subscribe(
        res=>{ },
        err=>{ console.log(err)}
      )
    }
  }

  submitStimulate(){
    document.getElementById("OfferSubmit").click()
  }

  async OnOfferSubmit(Image){
    this.formatFormData()
    if(this.offerService.formData.id == 0){
      this.insertOffer(Image)
    }
    else{
      this.updateOffer(Image)
    }
  }

  formatFormData(){
    if(this.startDate != ""){
      this.offerService.formData.startTime = this.startDate;
      this.offerService.formData.endTime = this.endDate;
    }
    if(this.endDate != ""){
      this.offerService.formData.endTime = this.endDate;
    }
    this.offerService.formData.cost = Number(this.offerService.formData.cost);
  }

  updateOffer(Image){

    if(this.picChange){
      var finalToUpload = new File([this.fileToUpload], this.offerService.formData.id +".png");
      this.imageService.putOfferImage(finalToUpload).subscribe(
        res => { },
        err => { console.log(err);}
      )
    }

    this.offerService.putOffer(this.offerService.formData.id).subscribe(
      async res => {
        this.returned = res as Offer
        this.offerList = await this.offerService.getOfferList().toPromise()
      },
      err => { console.log(err);}
    )

  }

  insertOffer(Image){
    var count = this.offerList[this.offerList.length-1].id + 1
    this.offerService.formData.picSrc = "/assets/offers/img/" + count + ".png";

    this.offerService.postOffer().subscribe(
      res => 
        this.returned = res as Offer
      ,
      err => { console.log(err);}
    )

    var imgname = count + ".png";
    this.ImageSubmit(Image, imgname);
  }

  ImageSubmit(Image, name: string){
    var finalToUpload = new File([this.fileToUpload], name);  
    
    this.imageService.postOfferImage(finalToUpload).subscribe(
      data => {
        console.log('done');
        Image.value = null;
        this.imageUrl = "/assets/img/upload.png";
      }
    )
  }

  handleFileInput(file: FileList){
    this.fileToUpload = file.item(0);
    this.picChange=true

    var reader = new FileReader();
    reader.onload = (event:any) => {
      this.imageUrl = event.target.result;
    }
    reader.readAsDataURL(this.fileToUpload);
  }

  onStartSelect(evt:any){
    const year = evt.year;
    const month = evt.month;
    const day = evt.day;
    this.startDate = year  + "." + month + "." + day;
  }

  onEndSelect(evt:any){
    const year = evt.year;
    const month = evt.month;
    const day = evt.day;
    this.endDate = year  + "." + month + "." + day;
  }

}
