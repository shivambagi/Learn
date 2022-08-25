import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClassComponent } from './class/class.component';
import { Class2Component } from './class2/class2.component';

const routes: Routes = [
  {path:"class",component:ClassComponent},
  {path:"class2",component:Class2Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
