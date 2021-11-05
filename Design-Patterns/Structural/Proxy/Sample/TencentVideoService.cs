using System.Collections.Generic;

namespace Design_Patterns.Structural.ProxyPattern.Sample
{
	/// <summary>
	// 服务连接器的具体实现。该类的方法可以向腾讯视频请求信息。请求速度取决于
	// 用户和腾讯视频的互联网连接情况。如果同时发送大量请求，即使所请求的信息
	// 一模一样，程序的速度依然会减慢。
	/// </summary>
	class TencentVideoService : IThirdPartyVideoService
	{
		public void DownloadVideo(long id)
		{
			// 从腾讯视频下载一个视频文件。
		}

		public Video GetVideoInfo(long id)
		{
			// 获取某个视频的元数据。

			return new Video();
		}

		public IEnumerable<Video> ListVideos()
		{
			// 向腾讯视频发送一个 API 请求。

			return new List<Video>();
		}
	}
}
