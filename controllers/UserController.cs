using System;
using Microsoft.AspNetCore.Mvc;

using csharp.microservice.restful.models;

namespace csharp.microservice.restful.controllers;

/**
 * @author  Cristian Hume Henriquez
 * @version 1.0.0
 * @since   2022.11.11
 */
[ApiController]
[Route("api/csharp/v1")]
public class UserController : ControllerBase
{
    #region [CONSTRUCTORS]
    public UserController()
    {
            
    }
    #endregion [CONSTRUCTORS]

    #region [METHODS-PUBLICS]
    [HttpGet("users", Name = "FindAll")]
    public List<UserResponse> FindAll()
    {
        return this.FindData();
    }

    [HttpGet("users/{id}", Name = "FindById")]
    public UserResponse FindById(Int128 id)
    {
        return this.FindData().Find(item => item.Id == id);
    }
    #endregion [METHODS-PUBLICS]

    #region [METHODS-PRIVATES]
    private List<UserResponse> FindData()
    {
        List<UserResponse> usersList = new List<UserResponse>()
        {
            new UserResponse()
            {
                Id = 1,
                FirstName = "James",
                LastName = "Gosling",
                Email = "james.gosling@email.com",
                Phone = "1-463-123-4447",
                Nationality = "Canadian",
                KnownFor = "Java (Programming Language)"
            },
            new UserResponse()
            {
                Id = 2,
                FirstName = "Guido",
                LastName = "Van Rossum",
                Email = "guido.van.rossum@email.com",
                Phone = "2-770-736-8031",
                Nationality = "Netherlands",
                KnownFor = "Python (Programming Language)"
            },
            new UserResponse()
            {
                Id = 3,
                FirstName = "Ryan ",
                LastName = "Dahl ",
                Email = "ryan.dahl@email.com",
                Phone = "3-024-976-6794",
                Nationality = "American",
                KnownFor = "NodeJS (Programming Language)"
            },
            new UserResponse()
            {
                Id = 3,
                FirstName = "Anders",
                LastName = "Hejlsberg",
                Email = "anders.hejlsberg@email.com",
                Phone = "3-024-976-6794",
                Nationality = "Danish",
                KnownFor = "CSharp (Programming Language)"
            }
        };
        return usersList;
    }
    #endregion [METHODS-PRIVATES]

}

