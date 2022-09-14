using System.Threading;
using System.Threading.Tasks;

namespace Take.Elephant.Kafka
{
    public interface IKafkaQueue<T> : IBlockingQueue<T>
    {
        /// <summary>
        /// Enqueues an item with event key value.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="item"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task EnqueueAsync(string key, T item, CancellationToken cancellationToken = default);
    }
}