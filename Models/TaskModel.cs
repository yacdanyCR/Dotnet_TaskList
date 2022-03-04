using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TaskList
{
    public class TaskModel
    {
        [Key]
       public int Id {get;set;}
       [Required]
       public string? Task{get;set;}
       [Required]
       public string? Description{get;set;}

       public DateTime CreatedDateTime{get;set;}=DateTime.Today;

    }
}