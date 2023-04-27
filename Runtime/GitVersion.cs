
namespace kamgam.editor.GitTool
{
    [UnityEngine.Scripting.Preserve]
    [System.Serializable]
    public class GitVersion
    {
        public int Major;
        public int Minor;
        public int Patch;
        public string PreReleaseTag;
        public string PreReleaseTagWithDash;
        public string PreReleaseLabel;
        public string PreReleaseLabelWithDash;
        // public int? PreReleaseNumber;
        public int WeightedPreReleaseNumber;
        public string BuildMetaData;
        public string BuildMetaDataPadded;
        public string FullBuildMetaData;
        public string MajorMinorPatch;
        public string SemVer;
        public string LegacySemVer;
        public string LegacySemVerPadded;
        public string AssemblySemVer;
        public string AssemblySemFileVer;
        public string FullSemVer;
        public string InformationalVersion;
        public string BranchName;
        public string EscapedBranchName;
        public string Sha;
        public string ShortSha;
        public string NuGetVersionV2;
        public string NuGetVersion;
        public string NuGetPreReleaseTagV2;
        public string NuGetPreReleaseTag;
        public string VersionSourceSha;
        public int CommitsSinceVersionSource;
        public string CommitsSinceVersionSourcePadded;
        public int UncommittedChanges;
        public string CommitDate;
    }
}
