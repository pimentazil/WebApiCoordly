using FluentValidation;
using WebApiCoordly.Communication.Requests;
using WebApiCoordly.Exception.ExceptionBase;

namespace WebApiCoordly.Application.UseCases.Products
{
    public class ProductValidator : AbstractValidator<RequestRegisterProductJson>
    {
        public ProductValidator() 
        {
            RuleFor(expense => expense.Name).NotEmpty().WithMessage(ResourceErrorMessages.NAME_REQUIRED);
            RuleFor(expense => expense.Price).GreaterThan(0).WithMessage(ResourceErrorMessages.PRICE_MUST_BE_GREATER_THAN_ZERO);
            RuleFor(expense => expense.StockQuantity).GreaterThan(0).WithMessage(ResourceErrorMessages.STOCK_QUANTITY_MUST_BE_GREATHER_THAN_ZERO);
        }   
    }
}
