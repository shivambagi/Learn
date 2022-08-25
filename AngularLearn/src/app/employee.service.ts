import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { Employee } from './employee.model';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  employeesubject = new Subject<Employee>();

  constructor() { }

  sendemployee(emp:Employee)
  {
    this.employeesubject.next(emp);
  }

  getemployee():Observable<Employee>
  {
    return this.employeesubject.asObservable();
  }

}
