using System;
using System.Linq;
using System.Collections.Generic;
using Person = Money.Calculator.Person;
using Row = System.Tuple<Money.Calculator.Person, Money.Calculator.Person>;

namespace Money
{
    internal class Results
    {
        Dictionary<Row, decimal> debts;

        public Results()
        {
            debts = new Dictionary<Row, decimal>();
        }

        public void SetDebt(Person from, Person to, decimal debt)
        {
            Row t = new Row(from, to);
            if (debts.ContainsKey(t))
                debts[t] = debt;
            else
                debts.Add(t, debt);
        }

        public IEnumerable<Tuple<Person, Person, decimal>> GetDebts(Person from)
        {
            // Take all the records with the right byer
            return debts.Where(r => r.Key.Item1 == from).Select(r => new Tuple<Person, Person, decimal>(r.Key.Item1, r.Key.Item2, r.Value));
        }

        public decimal GetDebt(Person from)
        {
            return GetDebts(from).Sum(t => t.Item3);
        }

        public decimal GetDebt(Person from, Person to)
        {   
            // Take all the records with the right byer and receiver and sum the debt
            return GetDebts(from).Where(r => r.Item2 == to).Sum(r => r.Item3);
        }
    }
}