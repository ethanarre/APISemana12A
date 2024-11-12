﻿namespace APISemana11A.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public bool Active { get; set; } = true;



        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
