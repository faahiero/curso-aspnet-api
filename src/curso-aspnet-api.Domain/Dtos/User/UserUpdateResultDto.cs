using System;

namespace curso_aspnet_api.Domain.Dtos.User
{
    public class UserUpdateResultDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}