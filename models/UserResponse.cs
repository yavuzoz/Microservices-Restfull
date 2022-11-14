using System;

namespace csharp.microservice.restful.models;

/**
 * @author  Cristian Hume Henriquez
 * @version 1.0.0
 * @since   2022.11.11
 */
public class UserResponse
{
    public Int32 Id { get; set; }

    public String FirstName { get; set; }

    public String LastName { get; set; }

    public String Nationality { get; set; }

    public String Occupation { get; set; }

    public String Phone { get; set; }

    public String Email { get; set; }

    public String KnownFor { get; set; }

}

