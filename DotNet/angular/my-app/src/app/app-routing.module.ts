import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { ReportComponent } from './report/report.component';

const routes: Routes = [
  { path: '', component: HomeComponent, title: 'Home page' },
  { path: 'home', component: HomeComponent, title: 'Home page' },
  { path: 'login', component: LoginComponent, title: 'Login page' },
  { path: 'register', component: RegisterComponent },
  { path: 'report', component: ReportComponent },
  { path: '**', redirectTo: '/login' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
