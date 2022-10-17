import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, observable } from 'rxjs'
import { EmployeeI } from '../../modelos/empleado.interface'


@Injectable({
  providedIn: 'root'
})
export class ApiService {

  url:string = 'https://localhost:44357/'

  constructor( private http:HttpClient ) { }

  getAllEmployees():Observable<EmployeeI[]>{
    let direccion = this.url + "Api/Employees"
    return this.http.get<EmployeeI[]>(direccion);
  }

  getSingleEmployee(id: any):Observable<EmployeeI>{
    let direccion = this.url + 'api/Employees/' + id;
    return this.http.get<EmployeeI>(direccion);
  }

  putEmployee(form:EmployeeI, id: any):Observable<EmployeeI>{
    let direccion = this.url + "api/Employees/" + id;
    return this.http.put<EmployeeI>(direccion, form);
  }

  deleteEmployee(id: any):Observable<EmployeeI>{
    let direccion = this.url + "api/Employees/" + id;
    return this.http.delete<EmployeeI>(direccion);
  }

  postEmployee(form:EmployeeI):Observable<EmployeeI>{
    let direccion = this.url + "Api/Employees"
    return this.http.post<EmployeeI>(direccion,form);
  }
}