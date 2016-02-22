using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class Calculator
    {
        [Serializable]
        internal class Product : ISerializable
        {
            string name;
            decimal price;
            Payment payment;
            List<Person> receivers;


            public Product(string name, decimal price, Payment transaction, List<Person> receivers)
            {
                this.name = name;
                this.price = price;
                this.payment = transaction;
                this.receivers = receivers;

                if (payment != null)
                    payment.Products.Add(this);
            }

            protected Product(SerializationInfo info, StreamingContext context)
            {
                name = info.GetString("name");
                price = info.GetDecimal("price");
                payment = info.GetValue("payment", typeof(Payment)) as Payment;
                receivers = info.GetValue("receivers", typeof(List<Person>)) as List<Person>;
            }


            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public decimal Price
            {
                get
                {
                    return price;
                }

                set
                {
                    price = value;
                }
            }

            public Payment Transaction
            {
                get
                {
                    return payment;
                }

                set
                {
                    if (payment != null)
                        payment.Products.Remove(this);

                    payment = value;

                    if (value != null)
                        value.Products.Add(this);
                }
            }

            public List<Person> Receivers
            {
                get
                {
                    return receivers;
                }

                set
                {
                    receivers = value;
                }
            }

            public override string ToString()
            {
                return name;
            }

            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("name", name);
                info.AddValue("price", price);
                info.AddValue("payment", payment);
                info.AddValue("receivers", receivers);
            }
        }

        [Serializable]
        internal class Payment : ISerializable
        {
            string name;
            Person byer;
            List<Product> products;

            public Payment(string name, Person byer)
            {
                this.name = name;
                this.byer = byer;
                products = new List<Product>();

                if (byer != null)
                    byer.Payments.Add(this);
            }

            protected Payment(SerializationInfo info, StreamingContext context)
            {
                name = info.GetString("name");
                byer = info.GetValue("byer", typeof(Person)) as Person;
                products = info.GetValue("products", typeof(List<Product>)) as List<Product>;
            }

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public Person Byer
            {
                get
                {
                    return byer;
                }

                set
                {
                    if (byer != null)
                        byer.Payments.Remove(this);

                    byer = value;

                    if (value != null)
                        value.Payments.Add(this);
                }
            }

            public List<Product> Products
            {
                get
                {
                    return products;
                }

                set
                {
                    products = value;
                }
            }

            public override string ToString()
            {
                return name;
            }
            

            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("name", name);
                info.AddValue("byer", byer);
                info.AddValue("products", products);
            }
        }

        [Serializable]
        internal class Person : ISerializable
        {
            string name;
            List<Payment> payments;


            public Person(string name)
            {
                this.name = name;
                payments = new List<Payment>();
            }

            protected Person(SerializationInfo info, StreamingContext context)
            {
                name = info.GetString("name");
                payments = info.GetValue("payments", typeof(List<Payment>)) as List<Payment>;
            }


            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public List<Payment> Payments
            {
                get
                {
                    return payments;
                }

                set
                {
                    payments = value;
                }
            }

            public decimal GetTotalSpent()
            {
                return payments.SelectMany(p => p.Products).Sum(p => p.Price);
            }

            public decimal GetTotalSpentFor(params Person[] persons)
            {
                return GetTotalSpentFor((IEnumerable<Person>)persons);
            }

            public decimal GetTotalSpentFor(IEnumerable<Person> persons)
            {
                if (persons == null)
                    return 0;

                decimal totalSum = 0;
                foreach (Product prod in payments.SelectMany(p => p.Products))
                {
                    List<Person> intersection = prod.Receivers.Intersect(persons).ToList();

                    totalSum += prod.Price / prod.Receivers.Count * intersection.Count;
                    // If the byer bought the product to 4 persons, but we're only interested in what he spent on one of them
                    // we have to divide by the number of persons he bought it for, and multiply by the number of people we're interested in
                }
                return totalSum;
            }

            public override string ToString()
            {
                return name;
            }


            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("name", name);
                info.AddValue("payments", payments);
            }
        }



        public static Results CalculateDebt(List<Person> persons)
        {
            Results r = new Results();

            foreach (Person p in persons)
            {
                foreach (Person other in persons)
                {
                    if (p != other)
                    {
                        decimal totSpent = p.GetTotalSpentFor(other);
                        decimal totRecvd = other.GetTotalSpentFor(p);
                        decimal debt = totRecvd - totSpent;
                        r.SetDebt(p, other, debt);
                    }
                }
            }

            return r;
        }
    }
}
