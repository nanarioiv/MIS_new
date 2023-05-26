﻿namespace MIS.Data
{
    /// <summary>
    /// Клас для представления сгруппированых по типу неисправности заявок
    /// </summary>
   public class RequestByTechnicType
    {
        public TechnicType TechnicType { get; set; }
        public int Count { get; set; }
    }
}
