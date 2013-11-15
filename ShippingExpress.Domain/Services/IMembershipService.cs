﻿using System;
using System.Collections.Generic;
using ShippingExpress.Domain.Entities;
using ShippingExpress.Domain.Entities.Core;

namespace ShippingExpress.Domain.Services
{
    public interface IMembershipService
    {
        ValidUserContext ValidateUser(string userName, string password);
        OperationResult<UserWithRoles> CreateUser(string userName, string email, string password);
        OperationResult<UserWithRoles> CreateUser(
        string username, string email,
        string password, string role);

        OperationResult<UserWithRoles> CreateUser(string username, string email,string password, string[] roles);

        UserWithRoles UpdateUser(User user, string username, string email);

        bool ChangePassword(string username, string oldPassword, string newPassword);

        bool AddToRole(Guid userKey, string role);
        bool AddToRole(string username, string role);
        bool RemoveFromRole(string username, string role);

        IEnumerable<Role> GetRoles();
        Role GetRole(Guid key);
        Role GetRole(string name);

        PaginatedList<UserWithRoles> GetUsers(int pageIndex, int pageSize);
        UserWithRoles GetUser(Guid key);
        UserWithRoles GetUser(string name);
    }
}
