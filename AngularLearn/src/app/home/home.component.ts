import { Component, OnInit } from '@angular/core';
import { MessageService } from '../message.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  message: string = "";

  constructor(private msgservice: MessageService) { }

  ngOnInit(): void {
    this.msgservice.receivemessage().subscribe((d) => {
      this.message = d;
    })
  }

  

}
