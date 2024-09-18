import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuComponent } from './shared/menu/menu.component';
import { FooterComponent } from './shared/footer/footer.component';
import { HomeComponent } from './pages/home/home.component';
import { HeaderComponent } from './shared/header/header.component';
import { MedicamentoIndexComponent } from './pages/medicamento/medicamento-index/medicamento-index.component';
import { MedicamentoEditComponent } from './pages/medicamento/medicamento-edit/medicamento-edit.component';
import { MedicamentoCreateComponent } from './pages/medicamento/medicamento-create/medicamento-create.component';
import { ContainerComponent } from './shared/container/container.component';
import { Message404Component } from './pages/messages/message404/message404.component';
import { HttpClient, provideHttpClient } from '@angular/common/http';
import { MedicoIndexComponent } from './pages/medico/medico-index/medico-index.component';
import { MedicoCreateComponent } from './pages/medico/medico-create/medico-create.component';
import { MedicoEditComponent } from './pages/medico/medico-edit/medico-edit.component';
import { PacienteIndexComponent } from './pages/paciente/paciente-index/paciente-index.component';
import { PacienteCreateComponent } from './pages/paciente/paciente-create/paciente-create.component';
import { PacienteEditComponent } from './pages/paciente/paciente-edit/paciente-edit.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    FooterComponent,
    HomeComponent,
    HeaderComponent,
    MedicamentoIndexComponent,
    MedicamentoEditComponent,
    MedicamentoCreateComponent,
    ContainerComponent,
    Message404Component,
    MedicoIndexComponent,
    MedicoCreateComponent,
    MedicoEditComponent,
    PacienteIndexComponent,
    PacienteCreateComponent,
    PacienteEditComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [
    provideHttpClient()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
