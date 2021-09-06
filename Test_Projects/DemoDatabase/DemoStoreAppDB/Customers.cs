namespace DemoStoreAppDB
{
  public class Customer
  {
    private string fname;
    public string Fname 
    { 
      get
      {
        return this.fname;

      } 
      set
      {
        if(value.Length > 50 || value.Length == 0)
        {
          this.fname = "Invalid name input";
        }
        else
        {
          this.fname = value;
        }
      } 
    }
    public string Lname { get; set; }

    public Customer() {}

    public Customer(string fname, string lname)
    {
      this.Fname = fname;
      this.Lname = lname;
    }


  }
}