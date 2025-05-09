﻿using HeadphoneStore.Domain.Abstracts.ValueObjects;

namespace HeadphoneStore.Domain.Aggregates.Products.ValueObjects;

public class ProductPrice : ValueObject
{
    public decimal Amount { get; private set; }
    //public string Currency { get; private set; }

    protected ProductPrice() { }
    public ProductPrice(decimal amount) : this()
    {
        if (amount < 0) throw new ArgumentException("Amount must be positive.");

        Amount = amount;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Amount;
    }

    public static ProductPrice Create(decimal amount) => new(amount);

    public static ProductPrice CreateEmpty() => new(0);
}
