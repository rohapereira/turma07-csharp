import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { MedicamentoIndexComponent } from './pages/medicamento/medicamento-index/medicamento-index.component';
import { MedicamentoCreateComponent } from './pages/medicamento/medicamento-create/medicamento-create.component';
import { MedicamentoEditComponent } from './pages/medicamento/medicamento-edit/medicamento-edit.component';
import { Message404Component } from './pages/message/message404/message404.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'medicamentos',component:MedicamentoIndexComponent},
  {path:'medicamentos/create',component:MedicamentoCreateComponent},
  {path:'medicamentos/edit/:id',component:MedicamentoEditComponent},
  {path:'**',component:Message404Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }