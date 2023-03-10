using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public string Title { get; set; }
        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo obrigatório")]

        public bool Done { get; set; }
        [DisplayName("Concluído")]

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [DisplayName("Criado em")]

        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
        [DisplayName("Última atualização")]

        public string User { get; set; }
    }
}