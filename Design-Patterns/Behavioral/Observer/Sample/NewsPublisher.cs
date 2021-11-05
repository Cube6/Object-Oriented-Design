using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral.Observer
{
	public class NewsPublisher
	{
		protected List<Subscriber> subscribers = new List<Subscriber>();
		protected List<string> newsList = new List<string>();

		public void Attach(Subscriber subscriber)
		{
			subscribers.Add(subscriber);
		}

		public void DeAttach(Subscriber subscriber)
		{
			subscribers.Remove(subscriber);
		}

		public void Notify()
		{
			foreach(var subscriber in subscribers)
			{
				subscriber.Update(this);
			}
		}

		public void AddNews(string news)
		{
			newsList.Add(news);
		}

		public string GetLatestNews()
		{
			return newsList.FirstOrDefault();
		}
	}
}
