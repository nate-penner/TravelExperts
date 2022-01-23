﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelExpertsData;

/* A class to hold all error handles for the TravelExpertsDataAPI
 * Author: Daniel Palmer
 * 2022-01-21
 */

namespace TravelExpertsDataAPI
{
    public static class Handles
    { 
        public static void HandleDbUpdateException(DbUpdateException ex) // problems with performing SaveChanges
        {
            // get the inner exception with potentially multiple errors
            SqlException innerException = (SqlException)ex.InnerException;
            string message = "";
            foreach (SqlError err in innerException.Errors)
            {
                message += $"Error {err.Number}: {err.Message}\n";
            }
        }
        // Method for handling Concurrency Errors, for products
        public static void HandleConcurrencyError(DbUpdateConcurrencyException ex, TravelExpertsContext db, Product product)
        {
            ex.Entries.Single().Reload();
            var state = db.Entry(product).State;
            if (state == EntityState.Detached) // record was deleted
            {

            }
            else // it was updated
            {

            }
        }
        // Method for handling Concurrency Errors, overload for supplier
        public static void HandleConcurrencyError(DbUpdateConcurrencyException ex, TravelExpertsContext db, Supplier supplier)
        {
            ex.Entries.Single().Reload();
            var state = db.Entry(supplier).State;
            if (state == EntityState.Detached) // record was deleted
            {

            }
            else // it was updated
            {

            }
        }

        // Method for handling Concurrency Errors, overload for packages
        public static void HandleConcurrencyError(DbUpdateConcurrencyException ex, TravelExpertsContext db, Package package)
        {
            ex.Entries.Single().Reload();
            var state = db.Entry(package).State;
            if (state == EntityState.Detached) // record was deleted
            {

            }
            else // it was updated
            {

            }
        }
    }
}
