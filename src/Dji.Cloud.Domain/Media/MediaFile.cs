﻿namespace Dji.Cloud.Domain.Media;

public class MediaFile
{
    public string? FileId { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public string? ObjectKey { get; set; }

    public string? SubFileType { get; set; }

    public bool IsOriginal { get; set; }

    public string? Drone { get; set; }

    public string? Payload { get; set; }

    public string? TinnyFingerprint { get; set; }

    public string? Fingerprint { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? JobId { get; set; }
}
