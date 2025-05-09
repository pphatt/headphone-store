﻿using Microsoft.AspNetCore.Mvc;

namespace HeadphoneStore.Shared.Services.Brand.Update;

public class UpdateBrandRequestDto
{
    [FromRoute]
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public string Slug { get; set; }
    public string? Description { get; set; }
    public string Status { get; set; }
}
