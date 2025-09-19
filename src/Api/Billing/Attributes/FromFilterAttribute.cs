using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Bit.Api.Billing.Attributes;

/// <summary>
/// An attribute that indicates a parameter should not be bound from the request
/// body, but is instead injected from a [<see cref="ActionFilterAttribute"/>]
/// </summary>
[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
public class FromFilterAttribute : BindingBehaviorAttribute, IBindingSourceMetadata
{
    public FromFilterAttribute() : base(BindingBehavior.Never) { }

    public static readonly BindingSource Source = new(
        "Filter",
        "Filter",
        isGreedy: false,
        isFromRequest: false);

    public BindingSource BindingSource => Source;
}
