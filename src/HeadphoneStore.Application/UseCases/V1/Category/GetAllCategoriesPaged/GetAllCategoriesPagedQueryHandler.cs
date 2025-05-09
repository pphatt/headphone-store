﻿using HeadphoneStore.Domain.Abstracts.Repositories;
using HeadphoneStore.Shared.Abstracts.Queries;
using HeadphoneStore.Shared.Abstracts.Shared;
using HeadphoneStore.Shared.Dtos.Category;

namespace HeadphoneStore.Application.UseCases.V1.Category.GetAllCategoriesPaged;

public class GetAllCategoriesPagedQueryHandler : IQueryHandler<GetAllCategoriesPagedQuery, PagedResult<CategoryDto>>
{
    private readonly ICategoryRepository _categoryRepository;

    public GetAllCategoriesPagedQueryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<Result<PagedResult<CategoryDto>>> Handle(GetAllCategoriesPagedQuery request, CancellationToken cancellationToken)
    {
        var result = await _categoryRepository.GetAllCategoriesPagination(
            searchTerm: request.SearchTerm,
            pageIndex: request.PageIndex,
            pageSize: request.PageSize
        );

        return Result.Success(result);
    }
}
