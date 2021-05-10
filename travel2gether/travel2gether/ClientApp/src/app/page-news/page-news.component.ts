import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { News } from '../shared/news.model';
import { NewsService } from '../shared/news.service';

@Component({
  selector: 'app-page-news',
  templateUrl: './page-news.component.html',
  styleUrls: ['./page-news.component.css']
})
export class PageNewsComponent implements OnInit {

  newsId: number;
  news: News = new News()
  body: string = ""

  constructor(public newsService: NewsService, private route: ActivatedRoute) { }

  async ngOnInit(): Promise<void> {
    await this.route.queryParams.subscribe(params => {              //URL-ből az adatokat bekötjük
      this.newsId = params['newsID'];
    });

    this.news = await this.newsService.getNew(this.newsId).toPromise();
  }

  /*readTextFile(file) {
    fetch("C:\Users\ASUS\Angular\travel2gether\travel2gether\travel2gether\ClientApp\src\assets\news\txt\2.txt")
    .then(response =>  response.text())
    .then(text => this.body = text)
    console.log("body: " + JSON.stringify(this.body))
  }*/
  /*readTextFile(file)
  {
    var rawFile = new XMLHttpRequest();
    rawFile.open("GET", "C:\Users\ASUS\Angular\travel2gether\travel2gether\travel2gether\ClientApp\src\assets\news\txt\2.txt", false);
    rawFile.onreadystatechange = function ()
    {
        if(rawFile.readyState === 4)
        {
            if(rawFile.status === 200 || rawFile.status == 0)
            {
                var allText = rawFile.responseText;
                console.log(allText);
            }
        }
    }
    rawFile.send(null);
}*/

}
