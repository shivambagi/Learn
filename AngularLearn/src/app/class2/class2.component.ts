import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-class2',
  templateUrl: './class2.component.html',
  styleUrls: ['./class2.component.css']
})
export class Class2Component implements OnInit {

  constructor() { }
  arr = ['Shivam','Bagi','Sangli','India'];
  ngOnInit(): void {
  }
 count = 2;
 index=0;
  selectvalue = "";

  selectfunc = (value:any) => {
    this.selectvalue = value;
  };

  submitform(data:any)
  {
    console.log(data.ntext1);
    console.log(data.ntext2);
  }

}
