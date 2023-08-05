namespace CardAdministration.CodeGenerator.Artifacts.Files;

public class ClassModel {

    public ClassModel(string name, string directory)
    {
        Name = name;
        Directory = directory;
    }

    public string Extension { get; set; } = ".cs";
    public string Directory { get; set; }
    public string Name { get; set; }
}
