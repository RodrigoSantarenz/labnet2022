import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListComponent } from './vistas/list/list.component';
import { AddComponent } from './vistas/add/add.component';
import { UpdateComponent } from './vistas/update/update.component';
import { DeleteComponent } from './vistas/delete/delete.component';

const routes: Routes = [
  { path :'', redirectTo: 'list', pathMatch: 'full' },
  { path: 'list', component: ListComponent },
  { path: 'add', component: AddComponent },
  { path: 'update/:id', component : UpdateComponent },
  { path: 'delete/:id', component : DeleteComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingComponents = [ListComponent, AddComponent, UpdateComponent, DeleteComponent]