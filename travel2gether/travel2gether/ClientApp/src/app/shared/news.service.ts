import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { News } from './news.model';

@Injectable({
  providedIn: 'root'
})
export class NewsService {
  readonly rootUrl = "https://localhost:44399/api/News";
  formData: News = new News()
  list: News[];

  constructor(private http: HttpClient) { }

  getNews(){
    return this.http.get<News[]>(this.rootUrl);
  }

  postNews(){
    return this.http.post(this.rootUrl, this.formData);
  }

  getNew(id: number){
    console.log("getnewban: " + this.rootUrl + "/" + id)
    return this.http.get<News>(this.rootUrl + "/" + id);
  }

  putNews(id: number){
    return this.http.put(this.rootUrl + "/" + id, this.formData);
  }

  deleteNews(id: number){
    this.formData = new News()
    return this.http.delete(this.rootUrl + "/" +  id)
  }
}
