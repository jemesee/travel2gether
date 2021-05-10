import { Component, OnInit } from '@angular/core';
import { NgbDate } from '@ng-bootstrap/ng-bootstrap';
import { DomesticOffer } from '../shared/domestic-offer.model';
import { DomesticOfferService } from '../shared/domestic-offer.service';
import { FileHttpService } from '../shared/file-http.service';

@Component({
  selector: 'app-domestic-crud',
  templateUrl: './domestic-crud.component.html',
  styleUrls: ['./domestic-crud.component.css']
})
export class DomesticCRUDComponent implements OnInit {
  imageUrl: string = "/assets/img/white.png";
  fileToUpload: File = null;
  
  domOfferList: DomesticOffer[];
  editDomOffer: DomesticOffer = new DomesticOffer();
  returnedDomOffer: DomesticOffer = new DomesticOffer();
  picChange: boolean = false
  startDate: string;
  startDatePicker: NgbDate
  endDate: string;
  endDatePicker: NgbDate

  constructor(private fileService: FileHttpService, public domOfferService: DomesticOfferService) { }

  async ngOnInit(): Promise<void> {
    this.domOfferService.formData = new DomesticOffer() 
    this.domOfferList = await this.domOfferService.getDomesticOffers().toPromise();
  }

  async loadDestination(offerid){
    this.editDomOffer = await this.domOfferService.getDomesticOffer(offerid).toPromise();
    console.log(this.editDomOffer)
    this.domOfferService.formData = this.editDomOffer;
    this.imageUrl = this.editDomOffer.picSrc
    var dates = this.editDomOffer.startTime.split(".")
    this.startDatePicker = new NgbDate(parseInt(dates[0]), parseInt(dates[1]), parseInt(dates[2]));
    dates = this.editDomOffer.endTime.split(".")
    this.endDatePicker = new NgbDate(parseInt(dates[0]), parseInt(dates[1]), parseInt(dates[2]));
  }

  deleteDomOffer(){
    let id = this.domOfferService.formData.id 
    if(id != 0){
      this.domOfferService.deleteDomesticOffer(id)
      .subscribe(
        async res=>{
          this.domOfferList = await this.domOfferService.getDomesticOffers().toPromise()
        },
        err=>{ console.log(err)}
      )
      this.fileService.deleteDomesticImage(id)
      .subscribe(
        res=>{ },
        err=>{ console.log(err)}
      )
    }
  }

  submitStimulate(){
    document.getElementById("domOfferSubmit").click()
  }

  OnDomOfferSubmit(Image){
    this.formatFormData()
    if(this.domOfferService.formData.id == 0){
      this.insertDomOffer(Image)
    }
    else{
      this.updateDomOffer(Image)
    }
  }

  formatFormData(){
    this.domOfferService.formData.startTime = this.startDate;
    this.domOfferService.formData.endTime = this.endDate;
    this.domOfferService.formData.cost = Number(this.domOfferService.formData.cost);
  }

  insertDomOffer(Image){
    var count = this.domOfferList[this.domOfferList.length-1].id + 1
    this.domOfferService.formData.picSrc = "/assets/domestic/img/" + count + ".png";

    this.domOfferService.postDomesticOffer().subscribe(
      res => 
        this.returnedDomOffer = res as DomesticOffer
      ,
      err => { console.log(err);}
    )

    var imgname = count + ".png";
    this.ImageSubmit(Image, imgname);
  }

  ImageSubmit(Image, name: string){
    var finalToUpload = new File([this.fileToUpload], name);  
    
    this.fileService.putDomesticImage(finalToUpload).subscribe(
      data => {
        console.log('done');
        Image.value = null;
        this.imageUrl = "/assets/img/upload.png";
      }
    )
  }

  updateDomOffer(Image){
    this.domOfferService.putDomesticOffer(this.domOfferService.formData.id).subscribe(
      async res => {
        this.returnedDomOffer = res as DomesticOffer
        this.domOfferList = await this.domOfferService.getDomesticOffers().toPromise()
      },
      err => { console.log(err);}
    )
    
    if(this.picChange){
      console.log("kép váltás lefut")
      var finalToUpload = new File([this.fileToUpload], this.domOfferService.formData.id +".png");
      this.fileService.putDomesticImage(finalToUpload).subscribe(
        res => { },
        err => { console.log(err);}
      )
    }
  }

  handleFileInput(file: FileList){
    this.fileToUpload = file.item(0);
    this.picChange = true

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
