﻿using HeadphoneStore.Domain.Aggregates.Identity.Entities;

using Microsoft.AspNetCore.Identity;

using Moq;

namespace HeadphoneStore.UnitTests;

public class BaseTest
{
    internal Mock<UserManager<AppUser>> _mockUserManager;
    internal Mock<RoleManager<AppRole>> _mockRoleManager;

    public BaseTest()
    {
        // Initialize mock user manager
        var userStore = new Mock<IUserStore<AppUser>>();
        _mockUserManager = new Mock<UserManager<AppUser>>(userStore.Object, null, null, null, null, null, null, null, null);

        // Initialize mock role manager
        var roleStore = new Mock<IRoleStore<AppRole>>();
        _mockRoleManager = new Mock<RoleManager<AppRole>>(roleStore.Object, null, null, null, null);
    }
}
