using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation_HAS__A_relationship_
{
    public class Address
    {
        public string addressLine, city, state;

        public Address(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }
    public class Employee
    {
        public int id;
        public string name;
        public Address address;

        public Employee(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + "" + name + "" + address.addressLine + "" + address.city + "" + address.state);
        }

    }
    internal class TestAggregation
    {
        static void Main(string[] args)
        {
            Address Add = new Address("G-13, Sec-3", "Noida","UP");
            Employee emp = new Employee(1, "Saanvi", Add);
            emp.display();
            Console.ReadLine();
        }
    }
}
