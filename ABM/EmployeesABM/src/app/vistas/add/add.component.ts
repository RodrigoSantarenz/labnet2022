import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { EmployeeI } from '../../modelos/empleado.interface';
import { ApiService } from '../../servicio/api/api.service';
import { AlertasService  } from '../../servicio/alertas/alertas.service';
import { FormGroup, FormControl, Validators, AbstractControl, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent implements OnInit {

  constructor(private activeRouter:ActivatedRoute, private router:Router, private api:ApiService, private fb:FormBuilder, private alertas:AlertasService) { }

  datosEmpleado!: EmployeeI;
  agregarEmpleado!:FormGroup;

  ngOnInit(): void {
    this.agregarEmpleado = this.fb.group({
      Nombre: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(10), Validators.pattern(/^[ a-zA-ZñÑáéíóúÁÉÍÓÚ]+$/)]],
      Apellido: ['', [Validators.required, Validators.minLength(3), Validators.maxLength(10), Validators.pattern(/^[ a-zA-ZñÑáéíóúÁÉÍÓÚ]+$/)]],
      Puesto: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(30), Validators.pattern(/^[ a-zA-ZñÑáéíóúÁÉÍÓÚ]+$/)]],
    }) 
  }
  
  postForm(forms:EmployeeI){
    this.api.postEmployee(forms).subscribe(data => {
      if(this.agregarEmpleado.valid){
        this.alertas.showScuccess('Empleado agregado', 'Echo')
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
