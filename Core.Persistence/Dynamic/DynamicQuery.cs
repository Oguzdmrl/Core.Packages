﻿namespace Core.Persistence.Dynamic
{
    public class DynamicQuery
    {
        public IEnumerable<Sort>? Sort { get; set; }
        public Filter? Filter { get; set; }
        public DynamicQuery()
        {

        }
        public DynamicQuery(IEnumerable<Sort>? sorts, Filter? filter)
        {
            Filter = filter;
            Sort = sorts;
        }
    }
}