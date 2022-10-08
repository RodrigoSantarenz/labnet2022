using System;
using System.Activities;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.Web;
using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;
using PracticaBF.Entities;

namespace MVC.Models
{
    public class RickAndMortyView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}