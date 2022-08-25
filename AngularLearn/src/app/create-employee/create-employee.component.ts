import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee.model';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-create-employee',
  templateUrl: './create-employee.component.html',
  styleUrls: ['./create-employee.component.css']
})
export class CreateEmployeeComponent implements OnInit {

  

  constructor(private empservice: EmployeeService) { }

  ngOnInit(): void {
  }

  createemployee(emp: Employee)
  {
    console.log(emp.ID);
    console.log(emp.Name);
    console.log(emp.Mobile);
    emp = new Employee(emp.ID,emp.Name,emp.Mobile);
    this.empservice.sendemployee(emp);
  }

}
