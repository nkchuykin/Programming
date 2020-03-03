using System;

public class Download<T> : IDownload where T : Content
{
    private readonly T download;

    public Download(T download)
    {
        throw new System.NotImplementedException();
    }

    public bool DownloadContent()
    {
        throw new System.NotImplementedException();
    }
}
