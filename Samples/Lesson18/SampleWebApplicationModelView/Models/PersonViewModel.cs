using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SampleWebApplicationModelView.Models;

public class PersonViewModel
{
    [BindRequired]
    public Guid Id { get; set; }
    [BindingBehavior(BindingBehavior.Optional)]
    public string Name { get; set; }
    [BindNever]
    public string Status { get; set; }
}