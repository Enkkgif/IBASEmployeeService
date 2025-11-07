namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;
    
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }


        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>() {
            new Employee() {
                Id = "21",
                Name = "Mette Bangsbo",
                Email = "meba@ibas.dk",
                Department = new Department() {
                    Id = 1,
                    Name = "Salg"
                }
            },
            new Employee() {
                Id = "22",
                Name = "Hans Merkel",
                Email = "hame@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "23",
                Name = "Karsten Mikkelsen",
                Email = "kami@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            } ,
            new Employee() {
            Id = "60",
            Name = "Enni Korhonen",
            Email = "enko@ibas.dk",
            Department = new Department() {
                Id = 3,
                Name = "It"
                }
            },
            new Employee() {
                Id = "61",
                Name = "Elsi Korhonen",
                Email = "elko@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "It"
                    
                }
                },
                new Employee() {
                    Id = "62",
                    Name = "Olavi Korhonen",
                    Email = "olko@ibas.dk",
                    Department = new Department() {
                        Id = 3,
                        Name = "It"}
                },
                new Employee() {
                    Id = "70",
                    Name = "Jeppe Larsen",
                    Email = "jela@ibas.dk",
                    Department = new Department() {
                        Id = 4,
                        Name = "Kantinen"}
                },
                new Employee() {
                    Id = "71",
                    Name = "Pia Larsen",
                    Email = "pila@ibas.dk",
                    Department = new Department() {
                        Id = 4,
                        Name = "Kantinen"}
                },
                
            
        };
            return employees;
        }
    }


}