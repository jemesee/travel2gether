import { Component, OnInit } from '@angular/core';
import { EmailValidator, NgForm } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  myInput;
  myInput2;
  letter;
  capital;
  number;
  length;
  same;
  username; 
  password;
  usr_er;
  psw_er;

  constructor() {     
  }

  ngOnInit(): void {
    this.myInput = document.getElementById("password_reg1");
    this.myInput2 = document.getElementById("password_reg2");
    this.letter = document.getElementById("letter");
    this.capital = document.getElementById("capital");
    this.number = document.getElementById("number");
    this.length = document.getElementById("length");
    this.same = document.getElementById("same");
    this.username = document.forms['login_form']['username'];
    this.password = document.forms['login_form']['password_log'];
    this.usr_er = document.getElementById("usrname_error");
    this.psw_er = document.getElementById("psw_error");
    this.username.onkeypress = function(){
      if(this.username.value.length >= 8){
        alert('bela');
        this.username.style.border =  "1px solid #b5b5b5";
        this.usr_er.style.visibility = "hidden";
        return true;
      }
    };
    this.password.addEventListener('onkeyup', function(){
      if(this.password.value.length >= 8){
        this.password.style.border =  "1px solid #b5b5b5";
        this.psw_er.style.visibility = "hidden";
        return true;
      }
    });
  }

  valid_password(){
    var lowerCaseLetters = /[a-z]/g;
    if(this.myInput.value.match(lowerCaseLetters)) {  
      this.letter.classList.remove("invalid");
      this.letter.classList.add("valid");
    } else {
      this.letter.classList.remove("valid");
      this.letter.classList.add("invalid");
    }
      
      // Validate capital letters
    var upperCaseLetters = /[A-Z]/g;
    if(this.myInput.value.match(upperCaseLetters)) {  
      this.capital.classList.remove("invalid");
      this.capital.classList.add("valid");
    } else {
      this.capital.classList.remove("valid");
      this.capital.classList.add("invalid");
    }
    
      // Validate numbers
    var numbers = /[0-9]/g;
    if(this.myInput.value.match(numbers)) {  
      this.number.classList.remove("invalid");
      this.number.classList.add("valid");
    } else {
      this.number.classList.remove("valid");
      this.number.classList.add("invalid");
    }
      
    if(this.myInput.value.length >= 8) {
      this.length.classList.remove("invalid");
      this.length.classList.add("valid");
    } else {
      this.length.classList.remove("valid");
      this.length.classList.add("invalid");
    }

    if(this.myInput.value == this.myInput2.value) {
      this.same.classList.remove("invalid");
      this.same.classList.add("valid");
    } else {
      this.same.classList.remove("valid");
      this.same.classList.add("invalid");
    }
  }

  same_password(){
    if(this.myInput.value == this.myInput2.value) {
      this.same.classList.remove("invalid");
      this.same.classList.add("valid");
    } else {
      this.same.classList.remove("valid");
      this.same.classList.add("invalid");
    }
  }

  registrate(){
    document.getElementById("regbox").style.display = "none";
    document.getElementById("login_panel").style.display = "none";
    document.getElementById("reg_panel").style.display = "block";
    document.getElementById("message").style.display = "block";
  }

  validated(please: NgForm){
    if(this.username.value.length < 8){
      this.username.style.border = "1px solid red";
      this.usr_er.style.visibility = "visible";
      this.username.focus()
      //return false;
    }
    else{
      this.username.style.border =  "1px solid #b5b5b5";
      this.usr_er.style.visibility = "hidden";
    }

    if(this.password.value.length < 8){
      this.password.style.border = "1px solid red";
      this.psw_er.style.visibility = "visible";
      this.password.focus()
      return false;
    }
    else{
      this.password.style.border =  "1px solid #b5b5b5";
      this.psw_er.style.visibility = "hidden";
      alert('bela submit: '+ this.username.value);
      return true;
    }
  }

 /* user_Verify(){
    if(this.username.value.length >= 8){
      alert('bela');
      this.username.style.border =  "1px solid #b5b5b5";
      this.usr_er.style.visibility = "hidden";
      return true;
    }
  }*/
}
