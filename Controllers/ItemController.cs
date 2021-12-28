using System;
using System.Collections.Generic;
using Catalog.Entities;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemController : ControllerBase
    {
        private readonly InMemItemRepository repository;

        public ItemController(){
            repository = new InMemItemRepository();
        }

        [HttpGet]
        public IEnumerable<Item> GetItems() {
            var items =  repository.GetItems();
            return items;
        }

        [HttpGet("{id}")]
        public ActionResult<Item> Getitem(Guid id){
            var item = repository.GetItem(id);
            if(item is null){
                return NotFound();
            }
            return item;
        }
    }
}