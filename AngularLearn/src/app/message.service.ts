import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MessageService {

  private subject = new  Subject<string>();

  constructor() { }

  sendmessage(message:string){
    this.subject.next(message);
  }

  receivemessage(): Observable<string>{
    return this.subject.asObservable();
  }
}
