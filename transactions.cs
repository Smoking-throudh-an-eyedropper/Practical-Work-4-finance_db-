//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practical_Work__4
{
    using System;
    using System.Collections.Generic;
    
    public partial class transactions
    {
        public int transaction_id { get; set; }
        public System.DateTime transaction_date { get; set; }
        public decimal transaction_amount { get; set; }
        public string transaction_type { get; set; }
        public string transaction_description { get; set; }
        public int account_id { get; set; }
        public virtual accounts accounts { get; set; }
    }
}
