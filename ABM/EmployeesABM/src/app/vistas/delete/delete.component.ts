import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { EmployeeI } from '../../modelos/empleado.interface';
import { ApiService } from '../../servicio/api/api.service';
import { AlertasService  } from '../../servicio/alertas/alertas.service';
import { FormGroup, FormControl, Validators, AbstractControl, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-delete',
  templateUrl: './delete.component.html',
  styleUrls: ['./delete.component.css']
})
export class DeleteComponent implements OnInit {

  constructor(private activeRouter:ActivatedRoute, private router:Router, private api:ApiService, private fb:FormBuilder, private alertas:AlertasService) { }
  
  datosEmpleado!: EmployeeI;
 obtenerEmpleado!:FormGroup;
  
  ngOnInit(): void {
    this.obtenerEmpleado = this.fb.group({
      Id: [''],
      Nombre: [''],
      Apellido: [''],
      Puesto: [''],
    })
    let EmployeeId = this.activeRouter.snapshot.paramMap.get('id');
    this.api.getSingleEmployee(EmployeeId).subscribe(data =>{
      this.datosEmpleado = data;
      this.obtenerEmpleado.setValue({
       'Id' : this.datosEmpleado.Id,
       'Nombre': this.datosEmpleado.Nombre,
       'Apellido': this.datosEmpleado.Apellido,
       'Puesto': this.datosEmpleado.Puesto,
      });
    })  
  }
  eliminar(id: any){
    this.api.deleteEmployee(id).subscribe(data =>{

     if(this.obtenerEmpleado.valid){
       this.alertas.showScuccess('Empleado eliminado', 'Hecho')
       this.router.navigate(["list"])
     }
     else{
       this.alertas.showError('Algo salio mal', 'Error')
     }
    } );
   }

   atras(){
    this.router.navigate(["list"])
   }
}