﻿using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Author {
    public class AuthorReadOnlyDto : BaseDto {

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(250)]
        public string Bio { get; set; }
    }
}
