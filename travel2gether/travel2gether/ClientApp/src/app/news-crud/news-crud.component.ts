import { Component, OnInit } from '@angular/core';
import { FileHttpService } from '../shared/file-http.service';
import { News } from '../shared/news.model';
import { NewsService } from '../shared/news.service';

@Component({
  selector: 'app-news-crud',
  templateUrl: './news-crud.component.html',
  styleUrls: ['./news-crud.component.css']
})
export class NewsCRUDComponent implements OnInit {
  imageUrl: string = "/assets/img/white.png";
  fileToUpload: File = null;
  picChange: boolean = false
  newsList: News[];

  returned: News = new News()
  editNews: News = new News()


  constructor(private fileService: FileHttpService, public newsService: NewsService) { }

  async ngOnInit(): Promise<void> {
    this.newsService.formData = new News()
    this.newsList = await this.newsService.getNews().toPromise();
  }

  async loadNews(id){
    this.editNews = await this.newsService.getNew(id).toPromise();
    this.newsService.formData = this.editNews;
    this.imageUrl = this.editNews.picSrc
  }

  deleteNews(){
    let id = this.newsService.formData.id
    if(id != 0){
      this.newsService.deleteNews(id)
      .subscribe(
        async res=>{
          this.newsList = await this.newsService.getNews().toPromise()
        },
        err=>{ console.log(err)}
      )
      this.fileService.deleteNewsImage(id)
      .subscribe(
        res=>{ },
        err=>{ console.log(err)}
      )
    }
  }

  submitStimulate(){
    document.getElementById("NewsSubmit").click()
  }

  async OnNewsSubmit(Image){
    if(this.newsService.formData.id == 0){
      this.insertNews(Image)
    }
    else{
      this.updateOffer(Image)
    }
  }

  insertNews(Image){
    var count = this.newsList[this.newsList.length-1].id + 1
    this.newsService.formData.picSrc = "/assets/news/img/" + count + ".png";

    this.newsService.postNews().subscribe(
      res => 
        this.returned = res as News
      ,
      err => { console.log(err);}
    )

    var imgname = count + ".png";
    this.ImageSubmit(Image, imgname);
  }

  ImageSubmit(Image, name: string){
    var finalToUpload = new File([this.fileToUpload], name);  
    
    this.fileService.postNewsImage(finalToUpload).subscribe(
      data => {
        console.log('done');
        Image.value = null;
        this.imageUrl = "/assets/img/upload.png";
      }
    )
  }

  updateOffer(Image){
    this.newsService.putNews(this.newsService.formData.id).subscribe(
      async res => {
        this.returned = res as News
        this.newsList = await this.newsService.getNews().toPromise()
      },
      err => { console.log(err);}
    )

    if(this.picChange){
      var finalToUpload = new File([this.fileToUpload], this.newsService.formData.id +".png");
      this.fileService.putNewsImage(finalToUpload).subscribe(
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

}
