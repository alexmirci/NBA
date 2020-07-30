using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NBA.Models{
    public class Player{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int playerId {get; set; }
        
        [Display(Name = "Player name" )]
        [Required(ErrorMessage = "{0} is required!" )]
        public string playerName {get; set;}
        [Display(Name = "Player number" )]
        [Required(ErrorMessage = "{0} is required!" )]
        public string playerNumber {get; set;}
        [Display(Name = "Team name" )]
        [Required(ErrorMessage = "{0} is required!" )]
        public string teamName {get; set;}
    }
}