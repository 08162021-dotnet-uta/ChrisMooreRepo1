using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Project0.StoreApplication.Domain.Models;
using Project0.StoreApplication.Storage.Adapters;


namespace Project0.StoreApplication.Storage
{
  public class DBdemo
  {
    private readonly  DataAdapter _da = new DataAdapter();
    public List<Customer> GetCustomers()
    {
        return _da.Customers.FromSqlRaw("select * from Customer.Customer;").ToList();
    }

    // public void SetCustomer (Customer customer)
    // {
    //   _da.Database.ExecuteSqlRaw("insert into Customer.Customer(Name) value ({0})", customer.Name);
    // }

  }

}