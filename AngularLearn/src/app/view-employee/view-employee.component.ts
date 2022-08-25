import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee.model';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-view-employee',
  templateUrl: './view-employee.component.html',
  styleUrls: ['./view-employee.component.css']
})
export class ViewEmployeeComponent implements OnInit {

  emparray: Employee[] = [];
  emparray2: Employee[] = [];
  constructor(private empservice: EmployeeService) { }

  ngOnInit(): void {
    this.empservice.getemployee().subscribe(res => {
      this.emparray.push(res);
    });
  }

  getdata()
  {
    this.emparray2 = this.emparray;
  }

}
