using CrudProdutos.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudProdutos.Validators
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            //Validação do campo 'Nome'
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Por favor, informe o {PropertyName} do produto.")
                .Length(8, 100).WithMessage("Por favor, informe o {PropertyName} do produto de {MinLength} a {MaxLength} caracteres.");

            RuleFor(p => p.Preco)
                .NotNull().WithMessage("Por favor, informe o {PropertyName} do produto.")
                .GreaterThan(0).WithMessage("Por favor, informe o {PropertyName} com valor maior do que zero.")
                .LessThanOrEqualTo(100000).WithMessage("Por favor, informe o {PropertyName} com valor até {ComparisonValue}");

            RuleFor(p => p.Quantidade)
                .NotNull().WithMessage("Por favor, informe a {PropertyName} do produto.")
                .GreaterThanOrEqualTo(1).WithMessage("Por favor, informe a {PropertyName} com valor maior ou igual a {ComparisonValue}.")
                .LessThanOrEqualTo(1000).WithMessage("Por favor, informe a {PropertyName} com valor até {ComparisonValue}.");
        }
    }
}
