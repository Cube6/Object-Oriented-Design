namespace Design_Patterns.Structural.ProxyPattern.Sample
{
	class VideoManager
	{
		protected IThirdPartyVideoService _service;

		public VideoManager(IThirdPartyVideoService service)
		{
			_service = service;
		}

		public void RenderVideoPage(long id)
		{
			var info = _service.GetVideoInfo(id);
			// 渲染视频页面。
		}

		public void RenderListPanel()
		{
			var list = _service.ListVideos();
			// 渲染视频页面。
		}

		public void ReactOnUserInput(long id)
		{
			RenderVideoPage(id);
			RenderListPanel();
		}
	}
}
