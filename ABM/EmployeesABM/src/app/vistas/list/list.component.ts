import { ThisReceiver } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../servicio/api/api.service';
import { EmployeeI } from '../../modelos/empleado.interface';
import { AlertasService  } from '../../servicio/alertas/alertas.service';
import { Router } from '@angular/router';
import { PageEvent } from '@angular/material/paginator';
import { MatButtonModule } from '@angular/material/button';



@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {

  pageSize= 10;
  desde: number = 0;
  hasta: number = 10;

  empleados!:EmployeeI[]

  constructor(private api:ApiService, private router:Router, private alertas:AlertasService) {}

  ngOnInit(): void {
    this.api.getAllEmployees().subscribe(data =>{
      this.empleados = data;
    })
  }

  promoverEmpleado(id: any){
    this.router.navigate(['update', id])
  }

  nuevoEmpleado(){
    this.router.navigate(["add"])
  }

  eliminar(id: any){
    console.log('entre');
    this.router.navigate(['delete', id])
  }

  cambiarPagina(e:PageEvent){
    console.log(e);
    this.desde= e.pageIndex * e.pageSize;
    this.hasta= this.desde + e.pageSize; 
  }
}
