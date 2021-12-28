using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public class InMemItemRepository
    {
        private readonly List<Item> items = new()
        {
            new Item{ Id = Guid.NewGuid(), Name = "Bronze Sword", Price = 5, CreatedDate = DateTimeOffset.UtcNow},
            new Item{ Id = Guid.NewGuid(), Name = "Dagger", Price = 7, CreatedDate = DateTimeOffset.UtcNow},
            new Item{ Id = Guid.NewGuid(), Name = "Silver Shield", Price = 15, CreatedDate = DateTimeOffset.UtcNow},
            new Item{ Id = Guid.NewGuid(), Name = "Magic Staff", Price = 12, CreatedDate = DateTimeOffset.UtcNow},
            new Item{ Id = Guid.NewGuid(), Name = "Health Potion", Price = 6, CreatedDate = DateTimeOffset.UtcNow},
            new Item{ Id = Guid.NewGuid(), Name = "Mana Potion", Price = 7, CreatedDate = DateTimeOffset.UtcNow}
        };

        public IEnumerable<Item> GetItems() {
            return items;
        }

        public Item GetItem(Guid id) {
            return items.Where(item => item.Id ==id).SingleOrDefault();
        }
    }
}