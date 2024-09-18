import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MenuComponent } from './shared/menu/menu.component';
import { HeaderComponent } from './shared/header/header.component';
import { FooterComponent } from './shared/footer/footer.component';
import { HomeComponent } from './pages/home/home.component';
import { ContainerComponent } from './shared/container/container.component';
import { ProdutoIndexComponent } from './pages/produto/produto-index/produto-index.component';
import { ProdutoEditComponent } from './pages/produto/produto-edit/produto-edit.component';
import { ProdutoCreateComponent } from './pages/produto/produto-create/produto-create.component';
import { Message404Component } from './pages/messages/message404/message404.component';
import { HttpClient, provideHttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    HeaderComponent,
    FooterComponent,
    HomeComponent,
    ContainerComponent,
    ProdutoIndexComponent,
    ProdutoEditComponent,
    ProdutoCreateComponent,
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
