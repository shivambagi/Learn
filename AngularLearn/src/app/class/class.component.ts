import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-class',
  templateUrl: './class.component.html',
  styleUrls: ['./class.component.css']
})
export class ClassComponent implements OnInit {

  constructor() { }
  public index = 0;
  val:string = "shivam"
 arr = ['Shivam','Bagi','Sangli','India'];
 count = 2;
msg = "";

public twoway = "bagi";

  ngOnInit(): void {
  }

  listadd = () => {
    this.msg = "kuch bhi";
  };

}
