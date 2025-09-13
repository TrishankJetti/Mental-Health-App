using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MentalHealthApp.Models
{
    // A class to manage paginated lists of items
    public class PaginatedList<T> : List<T>
    {
        // The current page index. eg. 1 out of 3 pages.
        public int PageIndex { get; private set; }

        // The total number of pages that are the in the paginated list.
        public int TotalPages { get; private set; }

        // Constructor to initialize the paginated list
        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            // Set the current page index
            PageIndex = pageIndex;

            // Calculate the total number of pages
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);

            // Add the items to the list
            this.AddRange(items);
        }

        // Property to check if there is a previous page
        public bool HasPreviousPage => PageIndex > 1;

        // Property to check if there is a next page
        public bool HasNextPage => PageIndex < TotalPages;

        // Asynchronous method to create a paginated list from a queryable source
        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            // Get the total count of items in the source
            var count = await source.CountAsync();

            // Get the items for the current page
            var items = await source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToListAsync();

            // Create and return a new PaginatedList
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }
    }
}