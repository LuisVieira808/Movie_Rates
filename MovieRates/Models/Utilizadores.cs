using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRates.Models
{
    /// <summary>
    /// Descrição de cada utilizador
    /// </summary>
    public class Utilizadores
    {
        /// <summary>
        /// Construtor dos utilizadores
        /// </summary>
        public Utilizadores()
        {
            ListaDeReviews = new HashSet<Reviews>();
        }

        /// <summary>
        /// Identificador do utilizador
        /// </summary>
        [Key]
        public int IdUtilizador { get; set; }

        /// <summary>
        /// Nome do utilizador inscrito no site
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// Email do utilizador
        /// </summary>
        [StringLength(50, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        [Required]
        [EmailAddress(ErrorMessage = "O {0} introduzido não é válido")]
        public string Email { get; set; }

        /// <summary>
        /// Password do utilizador para aceder à sua conta no site
        /// </summary>
        //[Required]
        //public string Password { get; set; }

        /// <summary>
        /// Icon (avatar) do utilizador no site
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Lista das reviews dos utilizadores
        /// </summary>
        public ICollection<Reviews> ListaDeReviews { get; set; }
    }
}
