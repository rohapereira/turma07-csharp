import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { ProdutoIndexComponent } from './pages/produto/produto-index/produto-index.component';
import { ProdutoCreateComponent } from './pages/produto/produto-create/produto-create.component';
import { ProdutoEditComponent } from './pages/produto/produto-edit/produto-edit.component';
import { Message404Component } from './pages/messages/message404/message404.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'produtos',component:ProdutoIndexComponent},
  {path:'produtos/create',component:ProdutoCreateComponent},
  {path:'produtos/edit/:id',component:ProdutoEditComponent},
  {path:'**',component:Message404Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
