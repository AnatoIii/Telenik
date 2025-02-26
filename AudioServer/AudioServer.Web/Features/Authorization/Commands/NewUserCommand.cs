﻿using System.ComponentModel.DataAnnotations;
using Infrastructure.CommandBase;
using Infrastructure.Results;

namespace AudioServer.Web.Features.Authorization.Commands
{
    /// <summary>
    /// Model for <see cref="AuthController.CreateNewUser(NewUserCommand)"/>
    /// </summary>
    public class NewUserCommand : ICommand<Result>
    {
        /// <summary>
        /// User email
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// User password
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [Required]
        public string Username { get; set; }
    }
}
