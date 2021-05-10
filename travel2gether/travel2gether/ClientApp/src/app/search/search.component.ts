import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
    document.getElementById("searchtitle").addEventListener("click", this.searchbar_show);
  }

  searchbar_show() {
    var x = document.getElementById("searchbar");
    if (x.style.display === "none") {
      x.style.display = "flex";
      x.style.opacity = "1";
    } else {
      x.style.display = "none";
      x.style.opacity = "0";
    }
  }

}
