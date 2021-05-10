import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class FileHttpService {
  readonly rootURL = "https://localhost:44399/api/UploadImage";
  formData: FormData = new FormData();
  DetailData: FormData = new FormData();

  constructor(private http: HttpClient) { }

  postOfferImage(fileToUpload: File){
    this.formData.append('Image', fileToUpload, fileToUpload.name);
    return this.http.post(this.rootURL + "/offerPic", this.formData);
  }

  putOfferImage(fileToUpload: File){
    this.formData.append('Image', fileToUpload, fileToUpload.name);
    return this.http.post(this.rootURL + "/offerPic", this.formData);
  }
  
  deleteOfferImage(id: number){
    return this.http.delete(this.rootURL + "/offerPic/" + id);
  }

  postOfferDetail(fileToUpload: File){
    this.DetailData.append('Detail', fileToUpload, fileToUpload.name);
    return this.http.post(this.rootURL + "/offerDetail", this.DetailData);    
  }

  putOfferDetail(fileToUpload: File){
    this.DetailData.append('Detail', fileToUpload, fileToUpload.name);
    return this.http.post(this.rootURL + "/offerDetail", this.DetailData);    
  }

  deleteOfferDetail(id: number){
    return this.http.delete(this.rootURL + "/offerDetail/" + id);    
  }

  postNewsImage(fileToUpload: File){
    this.formData.append('Image', fileToUpload, fileToUpload.name);
    return this.http.post(this.rootURL + "/newsPic", this.formData);
  }

  putNewsImage(fileToUpload: File){
    this.formData.append('Image', fileToUpload, fileToUpload.name);
    return this.http.post(this.rootURL + "/newsPic", this.formData);
  }
  
  deleteNewsImage(id: number){
    return this.http.delete(this.rootURL + "/newsPic/" + id);
  }

  postDomesticImage(fileToUpload: File){
    this.formData.append('Image', fileToUpload, fileToUpload.name);
    return this.http.post(this.rootURL + "/domesticPic", this.formData);
  }

  putDomesticImage(fileToUpload: File){
    this.formData.append('Image', fileToUpload, fileToUpload.name);
    return this.http.post(this.rootURL + "/domesticPic", this.formData);
  }
  
  deleteDomesticImage(id: number){
    return this.http.delete(this.rootURL + "/domesticPic/" + id);
  }
}
