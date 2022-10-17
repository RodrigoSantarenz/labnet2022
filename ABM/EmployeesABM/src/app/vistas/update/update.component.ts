import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { EmployeeI } from '../../modelos/empleado.interface';
import { ApiService } from '../../servicio/api/api.service';
import { AlertasService  } from '../../servicio/alertas/alertas.service';
import { FormGroup, FormControl, Validators, AbstractControl, FormBuilder } from '@angular/forms';


@Component({
  selector: 'app-update',
  templateUrl: './update.component.html',
  styleUrls: ['./update.component.css']
})
export class UpdateComponent implements OnInit {

  constructor(private activeRouter:ActivatedRoute, private router:Router, private api:ApiService, private fb:FormBuilder, private alertas:AlertasService) { }

  datosEmpleado!: EmployeeI;
  editarEmpleado!:FormGroup;

  

  ngOnInit(): void {
    this.editarEmpleado = this.fb.group({
      Id: [''],
      Nombre: [''],
      Apellido: [''],
      Puesto: ['', [Validators.required, Validators.minLength(5), Validators.maxLength(30), Validators.pattern(/^[ a-zA-ZñÑáéíóúÁÉÍÓÚ]+$/)]],
    })
    let EmployeeId = this.activeRouter.snapshot.paramMap.get('id');
    this.api.getSingleEmployee(EmployeeId).subscribe(data =>{
      this.datosEmpleado = data;
      this.editarEmpleado.setValue({
       'Id' : this.datosEmpleado.Id,
       'Nombre': this.datosEmpleado.Nombre,
       'Apellido': this.datosEmpleado.Apellido,
       'Puesto': this.datosEmpleado.Puesto,
      });
    })  
  }

  postForm(form:EmployeeI){
     let EmployeeId = this.activeRouter.snapshot.paramMap.get('id');
     this.api.putEmployee(form, EmployeeId).subscribe(data =>{
      
      if(this.editarEmpleado.valid){
        this.alertas.showScuccess('Empleado promovido', 'Hecho')
        this.router.navigate(["list"])
      }
      else{
        this.alertas.showError('Algo salio mal', 'Error')
      }
    })
  }


   atras(){
    this.router.navigate(["list"])
   }

}

