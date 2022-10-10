using PracticaBF.Entities;
using PracticasBF.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class EmployeesController : ApiController
    {

        private EmployeesLogic logic = new EmployeesLogic();

        // GET: Api/Employees
        public List<EmployeesView> GetEmployees()
        {
            List<Employees> employees = logic.GetAll();
            List<EmployeesView> employeesViews = employees.Select(e => new EmployeesView
            {
                Id = e.EmployeeID,
                Nombre = e.FirstName,
                Apellido = e.LastName,
                Puesto = e.Title,
            }).ToList();

            return employeesViews;
        }

        // GET: Api/Employees/5
        [ResponseType(typeof(EmployeesView))]
        public IHttpActionResult GetEmloyees(int id)
        {
            try
            {
                Employees employees = logic.GetOne(id);
                if (employees == null)
                {
                    return NotFound();
                }
                try
                {
                    EmployeesView employeesView = new EmployeesView
                    {
                        Id = employees.EmployeeID,
                        Nombre = employees.FirstName,
                        Apellido = employees.LastName,
                        Puesto = employees.Title,
                    };

                    return Ok(employeesView);
                }
                catch (Exception)
                {
                    return InternalServerError();
                }
            }
            catch (NullReferenceException)
            {
                return InternalServerError();
            }
            catch (FormatException)
            {
                return InternalServerError();
            }
            catch (SqlException)
            {
                return InternalServerError();
            }

        }
        //POST: api/Employees
        [ResponseType(typeof(EmployeesView))]
        public IHttpActionResult PostEmployees(EmployeesView employees)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                try
                {
                    Employees employeesEntity = new Employees
                    {
                        EmployeeID = employees.Id,
                        FirstName = employees.Nombre,
                        LastName = employees.Apellido,
                        Title = employees.Puesto
                    };

                    logic.add(employeesEntity);
                    return CreatedAtRoute("DefaultApi", new { id = employees.Id }, employees);
                }
                catch (Exception)
                {
                    return InternalServerError();
                }
            }
            catch (NullReferenceException)
            {
                return InternalServerError();
            }
            catch (FormatException)
            {
                return InternalServerError();
            }
            catch (SqlException)
            {
                return InternalServerError();
            }
        }

        //PUT: api/Employees/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployees(int id, EmployeesView employees)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (id != employees.Id)
                {
                    return BadRequest();
                }
                try
                {
                    Employees employeesview = new Employees
                    {
                        EmployeeID = employees.Id,
                        Title = employees.Puesto
                    };

                    logic.Update(employeesview);
                    return StatusCode(HttpStatusCode.NoContent);
                }
                catch (Exception)
                {
                    return InternalServerError();
                }
            }
            catch (NullReferenceException)
            {
                return InternalServerError();
            }
            catch (FormatException)
            {
                return InternalServerError();
            }
            catch (SqlException)
            {
                return InternalServerError();
            }
        }

        //DELETE: api/Employees/5
        [ResponseType(typeof(Employees))]
        public IHttpActionResult DeleteEmployees(int id)
        {
            try
            {
                Employees employees = logic.GetOne(id);
                if (employees == null)
                {
                    return NotFound();
                }
                try
                {
                    logic.Delete(id);
                    return Ok(employees);
                }
                catch (Exception)
                {
                    return InternalServerError();
                }
            }
            catch (NullReferenceException)
            {
                return InternalServerError();
            }
            catch (FormatException)
            {
                return InternalServerError();
            }
            catch (SqlException)
            {
                return InternalServerError();
            }
        }
    }
}
