using System.Collections.Generic;

namespace Design_Patterns.Structural.ProxyPattern.Sample
{
	/// <summary>
	// 为了节省网络带宽，我们可以将请求结果缓存下来并保存一段时间。但你可能无
	// 法直接将这些代码放入服务类中。比如该类可能是第三方程序库的一部分或其签
	// 名是`final（最终）`。因此我们会在一个实现了服务类接口的新代理类中放入
	// 缓存代码。当代理类接收到真实请求后，才会将其委派给服务对象。
	/// </summary>
	class CachedVideoService : IThirdPartyVideoService
	{
		private IThirdPartyVideoService _service;
		private IEnumerable<Video> listCache;
		private Video videoCache;
		private bool needReset;

		public CachedVideoService(IThirdPartyVideoService service)
		{
			_service = service;
		}

		public IEnumerable<Video> ListVideos()
		{
			if (listCache == null || needReset)
			{
				listCache = _service.ListVideos();
			}

			return listCache;
		}

		public Video GetVideoInfo(long id)
		{
			if (videoCache == null || needReset)
			{
				videoCache = _service.GetVideoInfo(id);
			}

			return videoCache;
		}

		public void DownloadVideo(long id)
		{
			if (!DownloadExists(id) || needReset)
			{
				_service.DownloadVideo(id);
			}
		}

		private bool DownloadExists(long id)
		{
			//Check if already downloaded the video with the Id

			return false;
		}
	}
}
