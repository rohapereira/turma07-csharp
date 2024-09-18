import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { MedicamentoIndexComponent } from './pages/medicamento/medicamento-index/medicamento-index.component';
import { MedicamentoCreateComponent } from './pages/medicamento/medicamento-create/medicamento-create.component';
import { MedicamentoEditComponent } from './pages/medicamento/medicamento-edit/medicamento-edit.component';
import { MedicoIndexComponent } from './pages/medico/medico-index/medico-index.component';
import { MedicoCreateComponent } from './pages/medico/medico-create/medico-create.component';
import { MedicoEditComponent } from './pages/medico/medico-edit/medico-edit.component';
import { PacienteIndexComponent } from './pages/paciente/paciente-index/paciente-index.component';
import { PacienteCreateComponent } from './pages/paciente/paciente-create/paciente-create.component';
import { PacienteEditComponent } from './pages/paciente/paciente-edit/paciente-edit.component';
import { Message404Component } from './pages/messages/message404/message404.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'medicamentos',component:MedicamentoIndexComponent},
  {path:'medicamentos/create',component:MedicamentoCreateComponent},
  {path:'medicamentos/edit/:id',component:MedicamentoEditComponent},
  {path:'medicos',component:MedicoIndexComponent},
  {path:'medicos/create',component:MedicoCreateComponent},
  {path:'medicos/edit/:id',component:MedicoEditComponent},
  {path:'pacientes',component:PacienteIndexComponent},
  {path:'pacientes/create',component:PacienteCreateComponent},
  {path:'pacientes/edit/:codigo',component:PacienteEditComponent},
  {path:'**',component:Message404Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
