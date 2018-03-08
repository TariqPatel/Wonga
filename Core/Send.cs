using RabbitMQ.Client;
using System.Text;

namespace Core
{
	public class Send
    {
		public static void Execute(string queue, string data)
		{
			using (IConnection connection = new ConnectionFactory().CreateConnection())
			{
				using (IModel channel = connection.CreateModel())
				{
					channel.QueueDeclare(queue, false, false, false, null);
					channel.BasicPublish(string.Empty, queue, null, Encoding.UTF8.GetBytes(data));
				}
			}
		}
	}
}
