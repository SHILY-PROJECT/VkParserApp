﻿namespace VkParser.WebRequests.Models;

public class AccountDataModel : IAccount
{
    public string Login { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}