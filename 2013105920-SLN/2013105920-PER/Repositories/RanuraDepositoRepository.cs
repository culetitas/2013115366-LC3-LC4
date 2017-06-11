﻿using _2013115366_ENT.Entities;
using _2013115366_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013115366_PER.Repositories
{
    public class RanuraDepositoRepository : Repository<RanuraDeposito>, IRanuraDepositoRepository
    {
        public RanuraDepositoRepository(CajeroDbContext context) : base(context)
        {

        }
    }
}
