using System;

namespace Catalog.Dtos
{
        public record ItemDTO
    {
        public Guid Id { get; init; }

        public string Name {get; init;}
        public int Price { get; init; }

        public DateTimeOffset CreatedDate { get; init; }
    }

}