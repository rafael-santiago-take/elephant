﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takenet.Elephant.Specialized
{
    public class CacheSet<T> : CacheStrategy<ISet<T>>, ISet<T>
    {
        public CacheSet(ISet<T> source, ISet<T> cache, TimeSpan synchronizationTimeout, TimeSpan cacheExpiration = default(TimeSpan))
            : base(source, cache, new OverwriteSetSynchronizer<T>(synchronizationTimeout), cacheExpiration)
        {
        }

        protected CacheSet(ISet<T> source, ISet<T> cache, ISynchronizer<ISet<T>> synchronizer, TimeSpan cacheExpiration = default(TimeSpan)) 
            : base(source, cache, synchronizer, cacheExpiration)
        {
        }

        public Task AddAsync(T value)
        {
            return ExecuteWriteFunc(s => s.AddAsync(value));            
        }

        public Task<bool> TryRemoveAsync(T value)
        {
            return ExecuteWriteFunc(s => s.TryRemoveAsync(value));
        }

        public Task<IAsyncEnumerable<T>> AsEnumerableAsync()
        {
            return ExecuteQueryFunc(s => s.AsEnumerableAsync());
        }

        public Task<bool> ContainsAsync(T value)
        {
            return ExecuteQueryFunc(s => s.ContainsAsync(value));
        }

        public Task<long> GetLengthAsync()
        {
            return ExecuteQueryFunc(s => s.GetLengthAsync());
        }
    }
}
