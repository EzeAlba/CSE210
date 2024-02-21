using System;
using System.Runtime.CompilerServices;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool isInUsa()
    {
        return true;
    }

    public string Name { get { return _name; } }
    public Address Address { get { return _address; } }

}