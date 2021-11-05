using System.Collections.Generic;

namespace Design_Patterns.Structural.ProxyPattern.Sample
{
	interface IThirdPartyVideoService
	{
		IEnumerable<Video> ListVideos();
		Video GetVideoInfo(long id);
		void DownloadVideo(long id);
	}
}
