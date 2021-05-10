import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { News } from '../shared/news.model';
import { NewsService } from '../shared/news.service';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.css']
})
export class NewsComponent implements OnInit {

  news: News[];

  constructor(public service: NewsService, private router: Router) { }

  ngOnInit(): void {
    this.fetchNews()
  }

  async fetchNews(){
    this.news = await this.service.getNews().toPromise();
  }

  redirectToPage(id){
    this.router.navigate(['/pageNews'], {queryParams: {newsID: id}});
  }

}
