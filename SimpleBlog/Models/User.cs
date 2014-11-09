using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.Models
{
    public class User
    {
        // Class for representing the User entity

        public int Id { get; set; }
        [Required, StringLength(20, MinimumLength=5)]
        [Display(Name="Username", ResourceType=typeof(Resources.Resources))]
        public string Username { get; set; }
        [Required, StringLength(64)]
        [Display(Name="Password", ResourceType=typeof(Resources.Resources))]
        public string Password { get; set; }
        [Required, StringLength(300, MinimumLength=5)]
        [Display(Name="Email", ResourceType=typeof(Resources.Resources))]
        public string Email { get; set; }
        [Required, StringLength(300)]
        [Display(Name="FirstName", ResourceType=typeof(Resources.Resources))]
        public string FirstName { get; set; }
        [Required, StringLength(300)]
        [Display(Name="LastName", ResourceType=typeof(Resources.Resources))]
        public string LastName { get; set; }
        [Display(Name="Bio", ResourceType=typeof(Resources.Resources))]
        public string Bio { get; set; }
        [Required]
        [Display(Name="CreatedAt", ResourceType=typeof(Resources.Resources))]
        public DateTime CreatedAt { get; set; }
    }
}