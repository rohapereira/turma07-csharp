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
import { Message404Component } from './pages/message/message404/message404.component';
import { provideHttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    FooterComponent,
    ContainerComponent,
    HomeComponent,
    HeaderComponent,
    MedicamentoIndexComponent,
    MedicamentoEditComponent,
    MedicamentoCreateComponent,
    Message404Component
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
