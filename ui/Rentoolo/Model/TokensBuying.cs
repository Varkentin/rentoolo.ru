//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rentoolo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TokensBuying
    {
        public int Id { get; set; }
        public long Count { get; set; }
        public System.Guid UserId { get; set; }
        public double CostOneToken { get; set; }
        public double FullCost { get; set; }
        public System.DateTime WhenDate { get; set; }
    }
}