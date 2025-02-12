namespace Atc.Azure.Options.Environment;

public class EnvironmentOptions
{
    public EnvironmentType EnvironmentType { get; set; }

    public string EnvironmentName { get; set; } = string.Empty;

    public string RegionAbbreviation { get; set; } = string.Empty;

    public override string ToString()
        => $"{nameof(EnvironmentType)}: {EnvironmentType}, {nameof(EnvironmentName)}: {EnvironmentName}, {nameof(RegionAbbreviation)}: {RegionAbbreviation}";
}