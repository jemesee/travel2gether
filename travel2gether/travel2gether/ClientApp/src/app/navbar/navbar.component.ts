import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  searchshow(){
    var x = document.getElementById("search_text");
    x.style.display = "inline";
    setInterval(this.searchnoshow, 3000);
    //setInterval(()=> {document.getElementById("search_text").style.display = "none"}, 3000);
  }

  searchnoshow(){
    document.getElementById("search_text").style.display = "none"
  }

}
