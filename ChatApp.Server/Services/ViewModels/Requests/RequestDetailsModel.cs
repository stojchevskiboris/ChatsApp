﻿using ChatApp.Server.Services.ViewModels.Users;

namespace ChatApp.Server.Services.ViewModels.Requests
{
    public class RequestDetailsModel
    {
        public int Id { get; set; }

        public AddUserModel UserFrom { get; set; }

        public AddUserModel UserTo { get; set; }

        public int RequestStatus { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }
    }
}
